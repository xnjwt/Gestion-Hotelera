using System;

namespace Entidades
{
    public enum EstadoReserva
    {
        Pendiente,
        Confirmada,
        Cancelada,
        CheckIn,
        CheckOut
    }

    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int HabitacionId { get; set; }
        public int EmpleadoId { get; set; }
        public int? IdPago { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public EstadoReserva Estado { get; set; }

        private static int contadorIds = 1;

        public Reserva(
            int clienteId,
            int habitacionId,
            int empleadoId,
            DateTime fechaIngreso,
            DateTime fechaSalida)
        {
            Id = GenerarId();
            ClienteId = clienteId;
            HabitacionId = habitacionId;
            EmpleadoId = empleadoId;
            FechaIngreso = fechaIngreso;
            FechaSalida = fechaSalida;
            Estado = EstadoReserva.Pendiente;
            IdPago = null;
        }

        private int GenerarId()
        {
            return contadorIds++;
        }

        public override string ToString() { 
            return $"FechaIngreso: {FechaIngreso.ToShortDateString()}, FechaSalida: {FechaSalida.ToShortDateString()}, Estado: {Estado}";
        }

        public decimal CalcularCosto(decimal precioNoche, decimal impuestoPercent = 0m, decimal descuentoPercent = 0m)
        {
            int noches = (FechaSalida.Date - FechaIngreso.Date).Days;
            if (noches < 1) noches = 1;

            var subtotal = precioNoche * noches;
            var impuesto = subtotal * (impuestoPercent / 100m);
            var descuento = subtotal * (descuentoPercent / 100m);

            return subtotal + impuesto - descuento;
        }
    }
}

