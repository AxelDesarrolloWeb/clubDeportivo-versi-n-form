using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoForms.Entidades 
{
    public class E_Socio 
    {
        // Propiedades
        public int IDSocio { get; set; }
        public string? NombreS { get; set; }
        public string? ApellidoS { get; set; }
        public int? DocS { get; set; }
        public int asociarse { get; set; }
        
        // Propiedad para almacenar la fecha de vencimiento
        public DateTime? FechaVencimientoCuota { get; set; }

        // Método para verificar el vencimiento de la cuota
        public DateTime VerVencimientoCuota()
        {
            if (!FechaVencimientoCuota.HasValue)
            {
                throw new InvalidOperationException("No se ha establecido una fecha de vencimiento para este socio.");
            }
            return FechaVencimientoCuota.Value;
        }

        // Opcional: Método para verificar si la cuota está vencida
        public bool CuotaVencida()
        {
            if (!FechaVencimientoCuota.HasValue)
                return true; // Si no tiene fecha de vencimiento, se considera vencida
                
            return FechaVencimientoCuota.Value < DateTime.Now;
        }
    }
}