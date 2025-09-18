using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoForms.Entidades 
{
    public class E_Socio 
    {
        // Propiedades básicas
        public int IDSocio { get; set; }
        public string? NombreS { get; set; }
        public string? ApellidoS { get; set; }
        public int? DocS { get; set; }
        public bool EstaActivo { get; set; }  // Para saber si el socio está activo
        public DateTime? FechaVencimientoCuota { get; set; }
        public List<Actividad> ActividadesInscritas { get; private set; } = new List<Actividad>();

        // Método para inscribirse a una actividad
        public void InscribirEnActividad(Actividad actividad)
        {
            if (actividad == null)
            {
                throw new ArgumentNullException(nameof(actividad), "La actividad no puede ser nula");
            }

            if (EstaActivo && FechaVencimientoCuota.HasValue && FechaVencimientoCuota > DateTime.Now)
            {
                ActividadesInscritas.Add(actividad);
                // Aquí podría agregar lógica adicional, como notificar al sistema de la inscripción
            }
            else
            {
                throw new InvalidOperationException("El socio no puede inscribirse: cuota vencida o socio inactivo");
            }
        }

        // Método para verificar si el socio está inscripto en una actividad específica
        public bool EstaInscriptoEnActividad(int idActividad)
        {
            return ActividadesInscritas.Any(a => a.Id == idActividad);
        }

        // Método para verificar si la cuota está vencida
        public bool TieneCuotaVencida()
        {
            return !FechaVencimientoCuota.HasValue || FechaVencimientoCuota < DateTime.Now;
        }

        // Método para renovar la cuota
        public void RenovarCuota(int meses = 1)
        {
            if (meses <= 0)
                throw new ArgumentException("El número de meses debe ser mayor a cero", nameof(meses));

            var fechaBase = FechaVencimientoCuota > DateTime.Now 
                ? FechaVencimientoCuota.Value 
                : DateTime.Now;

            FechaVencimientoCuota = fechaBase.AddMonths(meses);
            EstaActivo = true;
        }
    }
}