using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controlador
{
    public class PagoControlador
    {
        PagoModelo mdl { get; set; }

        public PagoControlador(PagoModelo modelo)
        {
            mdl = modelo;
        }

        public bool validarPago(int reservaId, decimal monto, string metodo, int idPago = -1)
        {
            try
            {
                if (reservaId <= 0)
                    throw new ArgumentException("Debe asociar el pago a una reserva válida.");

                if (monto <= 0)
                    throw new ArgumentException("El monto a pagar debe ser mayor a 0.");

                if (string.IsNullOrWhiteSpace(metodo))
                    throw new ArgumentException("Debe especificar el método de pago (Efectivo, Tarjeta, etc).");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            // El constructor de Pago asigna FechaPago = DateTime.UtcNow automáticamente
            var pago = new Pago(reservaId, monto, metodo, idPago);

            try
            {
                if (idPago == -1)
                {
                    mdl.Guardar(pago);
                }
                else
                {
                    // Nota: Al usar new Pago(), la fecha se resetea a hoy. 
                    // Si se quisiera mantener la fecha original al editar, 
                    // se debería buscar el objeto antes o modificar el constructor.
                    // Trabajamos con lo provisto.
                    mdl.Actualizar(pago);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return true;
            }
        }

        public List<Pago> ListarPagos()
        {
            return mdl.Listar();
        }

        public Pago BuscarPagoPorId(int id)
        {
            return mdl.BuscarPorId(id);
        }
        public void EliminarPago(int id)
        {
            mdl.Eliminar(id);
        }

        public List<Pago> BuscarPagosPorMetodo(string criterio)
        {
            return mdl.Buscar(criterio);
        }
    }
}