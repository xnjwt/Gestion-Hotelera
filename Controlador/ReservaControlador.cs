using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controlador
{
    public class ReservaControlador
    {
        ReservaModelo mdl { get; set; }

        public ReservaControlador(ReservaModelo modelo)
        {
            mdl = modelo;
        }
        public void CancelarReserva(int idReserva)
        {
           mdl.Cancelar(idReserva);
        }
        public Reserva BuscarReservaPorId(int idReserva)
        {
            return mdl.BuscarPorId(idReserva);
        }
        public Boolean validarReserva(int clienteId, int habitacionId, int empleadoId, DateTime fechaIngreso, DateTime fechaSalida, int? idPago = null, int idReserva = -1, EstadoReserva estado = EstadoReserva.Pendiente)
        {
            try
            {
                if (clienteId <= 0)
                    throw new ArgumentException("Debe seleccionar un cliente válido.");

                if (habitacionId <= 0)
                    throw new ArgumentException("Debe seleccionar una habitación válida.");

                if (empleadoId <= 0)
                    throw new ArgumentException("El empleado que registra la reserva no es válido.");

                // Validaciones de Fechas
                if (fechaIngreso.Date < DateTime.Now.Date)
                    throw new ArgumentException("La fecha de ingreso no puede ser anterior a la fecha actual.");

                if (fechaSalida.Date <= fechaIngreso.Date)
                    throw new ArgumentException("La fecha de salida debe ser mayor a la fecha de ingreso.");

                // Validación de lógica de negocio: Mínimo 1 día
                TimeSpan duracion = fechaSalida - fechaIngreso;
                if (duracion.TotalDays < 1)
                    throw new ArgumentException("La estancia mínima es de un día.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de validación: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            var reserva = new Reserva(
                clienteId,
                habitacionId,
                empleadoId,
                fechaIngreso,
                fechaSalida,
                idReserva,
                estado
            );

            // Si viene un pago, lo asignamos (aunque el constructor lo pone null por defecto)
            reserva.IdPago = idPago;

            try
            {
                // Según tu capa de datos, solo existe Guardar (INSERT). 
                // Si existiera Actualizar en Datos, aquí iría el if(idReserva == -1).
                // Por ahora, se asume creación de nueva reserva.

                if (idReserva == -1)
                {
                    mdl.Guardar(reserva);
                }
                else
                {

                    mdl.Actualizar(reserva);
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar");
                return true;
            }
        }

        public void AsignarPago(int idReserva, int idPago)
        {
            try
            {
                var reserva = mdl.BuscarPorId(idReserva);
                if (reserva == null)
                {
                    MessageBox.Show("No se encontró la reserva especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                mdl.AsignarPago(reserva, idPago);
                MessageBox.Show("Pago asignado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al asignar pago");
            }
        }

        public List<Reserva> ListarReservas()
        {
            return mdl.Listar();
        }

        public List<Reserva> ListarReservasActivas()
        {
            return mdl.ListarActivas();
        }
        public List<Reserva> ListarReservasConfirmadas()
        {
            return mdl.ListarConfirmadas();
        }
        public List<Reserva> ListarReservasCanceladas()
        {
            return mdl.ListarCanceladas();
        }

        public List<Reserva> BuscarReservas(string criterio)
        {
            return mdl.Buscar(criterio);
        }

        public List<Reserva> BuscarReservasPorCliente(int clienteId)
        {
            return mdl.BuscarPorCliente(clienteId);
        }
    }
}