using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Controlador
{
    public class PagoControlador
    {
        PagoModelo mdl { get; set; }

        public PagoControlador(PagoModelo modelo)
        {
            mdl = modelo;
        }
        public int ObtenerIdPago(int idReserva)
        {
            return mdl.ObtenerIdPago(idReserva);
        }
        public bool validarPago(int reservaId, string monto, string metodo, int idPago = -1)
        {
            var mMonto = Regex.Match(monto, @"\d+(\.\d+)?");
            Decimal montoCorrecto;
            try
            {
                if (reservaId <= 0)
                    throw new ArgumentException("Debe asociar el pago a una reserva válida.");

                if (!mMonto.Success)
                    throw new ArgumentException("El monto a pagar debe ser mayor a 0.");
                else montoCorrecto = Decimal.Parse(mMonto.Value);

                if (string.IsNullOrWhiteSpace(metodo))
                    throw new ArgumentException("Debe especificar el método de pago (Efectivo, Tarjeta, etc).");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            
            var pago = new Pago(reservaId, montoCorrecto, metodo, idPago);

            try
            {
                if (idPago == -1)
                {
                    mdl.Guardar(pago);
                }
                else
                {
                    
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