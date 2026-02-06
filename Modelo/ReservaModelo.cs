using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public class ReservaModelo
    {
        ReservasDatos Dts { get; set; }

        public ReservaModelo(ReservasDatos dts)
        {
            Dts = dts;
        }

        public void Guardar(Reserva reserva)
        {
            if (reserva == null) throw new ArgumentNullException(nameof(reserva));

            // Validaciones
            if (reserva.FechaSalida <= reserva.FechaIngreso)
            {
                throw new ArgumentException("La fecha de salida debe ser posterior a la fecha de ingreso.");
            }

            Dts.Guardar(reserva);
        }

        public List<Reserva> Listar()
        {
            return Dts.Listar();
        }

        public List<Reserva> ListarActivas()
        {
            return Dts.ListarActivas();
        }

        public Reserva BuscarPorId(int id)
        {
            return Dts.BuscarPorId(id);
        }

        public List<Reserva> Buscar(string coincidencia)
        {
            return Dts.Buscar(coincidencia);
        }

        public List<Reserva> BuscarPorCliente(int clienteId)
        {
            return Dts.BuscarPorCliente(clienteId);
        }

        public void AsignarPago(Reserva reserva, int idPago)
        {
            if (reserva == null) throw new ArgumentNullException(nameof(reserva));
            if (idPago <= 0) throw new ArgumentException("El ID del pago debe ser válido.");

            Dts.AsignarPago(reserva, idPago);
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}