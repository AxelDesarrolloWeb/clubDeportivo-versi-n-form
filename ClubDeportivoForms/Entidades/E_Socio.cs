using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubDeportivoForms.Entidades 
{
    public class E_Socio 
    {
        // ... (código anterior se mantiene igual) ...

        public void PagarCuota(Cuota cuota) 
        {
            if (cuota == null)
                throw new ArgumentNullException(nameof(cuota), "La cuota no puede ser nula");

            if (cuota.Monto <= 0)
                throw new ArgumentException("El monto de la cuota debe ser mayor a cero", nameof(cuota.Monto));

            // Registrar el pago
            cuota.FechaPago = DateTime.Now;
            cuota.Estado = EstadoCuota.Pagada;
            
            // Si la cuota estaba vencida, actualizamos el estado del socio
            if (TieneCuotaVencida())
            {
                RenovarCuota(1); // Renovar por 1 mes al pagar una cuota vencida
            }
            
            // Aquí podrías agregar lógica adicional como:
            // - Registrar el pago en un historial
            // - Enviar un comprobante por email
            // - Actualizar la base de datos
        }

        public RegistroEntrada RegistrarEntrada()
        {
            if (!EstaActivo || TieneCuotaVencida())
            {
                throw new InvalidOperationException("El socio no puede ingresar: cuota vencida o socio inactivo");
            }

            var registro = new RegistroEntrada
            {
                SocioId = this.IDSocio,
                FechaHoraEntrada = DateTime.Now,
                FechaHoraSalida = null // Se actualizará al registrar la salida
            };

            // Aquí podrías guardar el registro en la base de datos
            // _registroEntradaRepository.Guardar(registro);
            
            return registro;
        }

        public void RegistrarSalida(int registroEntradaId)
        {
            // En una implementación real, obtendrías el registro de la base de datos
            // var registro = _registroEntradaRepository.ObtenerPorId(registroEntradaId);
            
            // Simulación de obtención del registro
            var registro = new RegistroEntrada { Id = registroEntradaId };
            
            if (registro == null)
                throw new InvalidOperationException("No se encontró el registro de entrada");

            if (registro.FechaHoraSalida.HasValue)
                throw new InvalidOperationException("Ya se registró la salida para esta entrada");

            registro.FechaHoraSalida = DateTime.Now;
            
            // Aquí podrías actualizar el registro en la base de datos
            // _registroEntradaRepository.Actualizar(registro);
        }

        public TurnoMedico SacarTurno(Medico medico, DateTime fechaHora)
        {
            if (medico == null)
                throw new ArgumentNullException(nameof(medico), "El médico no puede ser nulo");

            if (fechaHora < DateTime.Now)
                throw new ArgumentException("La fecha y hora del turno no pueden ser en el pasado", nameof(fechaHora));

            if (!EstaActivo)
                throw new InvalidOperationException("El socio debe estar activo para sacar un turno");

            var turno = new TurnoMedico
            {
                SocioId = this.IDSocio,
                MedicoId = medico.Id,
                FechaHora = fechaHora,
                Estado = EstadoTurno.Pendiente,
                FechaCreacion = DateTime.Now
            };

            // Aquí podrías validar disponibilidad del médico
            // y guardar el turno en la base de datos
            // _turnoRepository.Guardar(turno);

            return turno;
        }
    }

    // Clases auxiliares (deberían estar en sus propios archivos)
    public enum EstadoCuota
    {
        Pendiente,
        Pagada,
        Vencida
    }

    public class Cuota
    {
        public int Id { get; set; }
        public int SocioId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaPago { get; set; }
        public EstadoCuota Estado { get; set; }
    }

    public class RegistroEntrada
    {
        public int Id { get; set; }
        public int SocioId { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime? FechaHoraSalida { get; set; }
    }

    public class TurnoMedico
    {
        public int Id { get; set; }
        public int SocioId { get; set; }
        public int MedicoId { get; set; }
        public DateTime FechaHora { get; set; }
        public EstadoTurno Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }

    public enum EstadoTurno
    {
        Pendiente,
        Confirmado,
        Cancelado,
        Completado
    }

    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
    }
}