using System;
using System.Windows.Forms;
using Controlador;
using Entidades;

namespace Vista
{
    public partial class ActualizarReserva : Form
    {
        private ReservaControlador Rsc;
        private PagoControlador Pgc;
        private ClienteControlador Clc;
        private HabitacionControlador Hbc;
        private Reserva ReservaSeleccionada;

        public ActualizarReserva(ReservaControlador rsc, PagoControlador pgc, ClienteControlador clc, HabitacionControlador hbc, Reserva reserva)
        {
            InitializeComponent();
            Rsc = rsc;
            Pgc = pgc;
            Clc = clc;
            Hbc = hbc;
            ReservaSeleccionada = reserva;
        }

        private void ActualizarReserva_Load(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Capturar datos modificados
            int clienteId = ReservaSeleccionada.ClienteId;
            int habitacionId = ReservaSeleccionada.HabitacionId;
            DateTime ingreso = dtpIngreso.Value;
            DateTime salida = dtpSalida.Value;


            int empleadoId = ReservaSeleccionada.EmpleadoId;
            var huboError = false;

            if ((ReservaSeleccionada.IdPago == null || ReservaSeleccionada.IdPago == -1) && (cmbMetodo.Text != "" || txtMonto.Text != ""))
            {
                Pgc.validarPago(ReservaSeleccionada.Id, txtMonto.Text, cmbMetodo.Text);
                int idPago = Pgc.ObtenerIdPago(ReservaSeleccionada.Id);

                huboError = Rsc.validarReserva(
                    clienteId,
                    habitacionId,
                    empleadoId,
                    ingreso,
                    salida,
                    idPago,
                    ReservaSeleccionada.Id,
                    EstadoReserva.Confirmada
                );
            }
            else if( ReservaSeleccionada.IdPago!=null && ReservaSeleccionada.IdPago != -1)
            {
                huboError = Pgc.validarPago(ReservaSeleccionada.Id, txtMonto.Text, cmbMetodo.Text, (int)ReservaSeleccionada.IdPago );
                
                huboError = Rsc.validarReserva(
                    clienteId,
                    habitacionId,
                    empleadoId,
                    ingreso,
                    salida,
                    ReservaSeleccionada.IdPago,
                    ReservaSeleccionada.Id,
                    ReservaSeleccionada.Estado
                );
            }

            if (!huboError)
            {
                MessageBox.Show("Reserva actualizada correctamente.");
                this.Close();
            }
        }

        private void ActualizarReserva_Load_1(object sender, EventArgs e)
        {
            txtCliente.Text = ReservaSeleccionada.ClienteId.ToString();
            txtHabitacion.Text = ReservaSeleccionada.HabitacionId.ToString();
            dtpIngreso.Value = ReservaSeleccionada.FechaIngreso;
            dtpSalida.Value = ReservaSeleccionada.FechaSalida;
            if (ReservaSeleccionada.IdPago != null)
            {
                var pago = Pgc.BuscarPagoPorId((int)ReservaSeleccionada.IdPago);
                txtMonto.Text = pago.MontoTotal.ToString();
                cmbMetodo.FindStringExact(pago.Metodo.ToString());
            }
        }
    }
}