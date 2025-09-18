using System;
using System.Collections.Generic;

namespace ClubDeportivoForms.Entidades 
{
    public class E_NoSocio 
    {
        public int IDNoSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public bool TieneAntecedentesMedicos { get; set; }
        public bool AceptaTerminos { get; set; }

        // Método para que un no socio se asocie al club
        public E_Socio Asociarse(string plan, decimal montoCuota, int duracionMeses)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(plan))
                throw new ArgumentException("El plan no puede estar vacío", nameof(plan));

            if (montoCuota <= 0)
                throw new ArgumentException("El monto de la cuota debe ser mayor a cero", nameof(montoCuota));

            if (duracionMeses <= 0)
                throw new ArgumentException("La duración debe ser mayor a cero", nameof(duracionMeses));

            if (!AceptaTerminos)
                throw new InvalidOperationException("Debe aceptar los términos y condiciones para asociarse");

            // Crear un nuevo socio a partir de los datos del no socio
            var nuevoSocio = new E_Socio
            {
                Nombre = this.Nombre,
                Apellido = this.Apellido,
                DNI = this.DNI,
                Email = this.Email,
                Telefono = this.Telefono,
                FechaNacimiento = this.FechaNacimiento,
                Domicilio = this.Domicilio,
                TieneAntecedentesMedicos = this.TieneAntecedentesMedicos,
                FechaInscripcion = DateTime.Now,
                EstaActivo = true
            };

            // Configurar la cuota inicial
            var cuotaInicial = new Cuota
            {
                Monto = montoCuota,
                FechaEmision = DateTime.Now,
                FechaVencimiento = DateTime.Now.AddMonths(1), // La primera cuota vence en 1 mes
                Estado = EstadoCuota.Pendiente,
                Concepto = $"Cuota de asociación - {plan}"
            };

            // Si el plan incluye meses de cortesía o promoción
            if (duracionMeses > 0)
            {
                nuevoSocio.FechaVencimientoCuota = DateTime.Now.AddMonths(duracionMeses);
            }

            // Aquí podría agregar lógica adicional como:
            // - Guardar el nuevo socio en la base de datos
            // - Enviar un correo de bienvenida
            // - Generar un carnet de socio
            // - Registrar el pago de la cuota

            return nuevoSocio;
        }

        // Método para validar si el no socio puede asociarse
        public bool PuedeAsociarse(out string mensajeError)
        {
            mensajeError = string.Empty;

            if (DateTime.Now.Year - FechaNacimiento.Year < 18)
            {
                mensajeError = "Debe ser mayor de 18 años para asociarse";
                return false;
            }

            if (string.IsNullOrWhiteSpace(DNI) || DNI.Length < 7)
            {
                mensajeError = "El DNI no es válido";
                return false;
            }

            if (!TieneAntecedentesMedicos)
            {
                mensajeError = "Debe presentar los antecedentes médicos";
                return false;
            }

            return true;
        }
    }
}