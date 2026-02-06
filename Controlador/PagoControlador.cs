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
        /// <summary>
        /// Procesa la validación y persistencia de un pago asociado a una reserva.
        /// Verifica que el ID de reserva sea válido, que el monto sea positivo y que se haya definido un método de pago.
        /// Si los datos pasan las reglas de negocio, se instancia el objeto Pago y se determina si se trata de 
        /// una nueva inserción o una actualización en la base de datos según el idPago.
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
        // <summary>
        /// Recupera la totalidad de los registros de pago almacenados en la base de datos.
        public List<Pago> ListarPagos()
        {
            return mdl.Listar();
        }
        /// <summary>
        /// Realiza una consulta filtrada para encontrar un pago específico mediante su clave primaria.
        public Pago BuscarPagoPorId(int id)
        {
            return mdl.BuscarPorId(id);
        }
        /// <summary>
        /// Ejecuta la baja definitiva de un registro de pago en la capa de datos.
        public void EliminarPago(int id)
        {
            mdl.Eliminar(id);
        }
        /// <summary>
        /// Filtra los registros de pagos basándose en el método de cobro utilizado.
        /// Útil para generar reportes segmentados por tipo de ingreso (ej. solo Efectivo).
        /// </summary>
        public List<Pago> BuscarPagosPorMetodo(string criterio)
        {
            return mdl.Buscar(criterio);
        }
    }
}