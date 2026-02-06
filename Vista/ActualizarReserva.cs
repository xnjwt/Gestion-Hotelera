using System;
using System.Windows.Forms;
using Controlador;
using Entidades;

namespace Vista
{
    public partial class ActualizarReserva : Form
    {
        private ReservaControlador Rsc;
        private ClienteControlador Clc;
        private HabitacionControlador Hbc;
        private Reserva ReservaSeleccionada;

        public ActualizarReserva(ReservaControlador rsc, ClienteControlador clc, HabitacionControlador hbc, Reserva reserva)
        {
            InitializeComponent();
            Rsc = rsc;
            Clc = clc;
            Hbc = hbc;
            ReservaSeleccionada = reserva;
        }

        private void ActualizarReserva_Load(object sender, EventArgs e)
        {
            // Llenar los ComboBox
            cmbClientes.DataSource = Clc.ListarClientes();
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "Id";

            cmbHabitaciones.DataSource = Hbc.ListarHabitaciones();
            cmbHabitaciones.DisplayMember = "Numero";
            cmbHabitaciones.ValueMember = "Id";

            // Asignar los valores actuales de la reserva a los controles
            cmbClientes.SelectedValue = ReservaSeleccionada.ClienteId;
            cmbHabitaciones.SelectedValue = ReservaSeleccionada.HabitacionId;
            dtpIngreso.Value = ReservaSeleccionada.FechaIngreso;
            dtpSalida.Value = ReservaSeleccionada.FechaSalida;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Capturar datos modificados
            int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);
            int habitacionId = Convert.ToInt32(cmbHabitaciones.SelectedValue);
            DateTime ingreso = dtpIngreso.Value;
            DateTime salida = dtpSalida.Value;

            // Mantenemos el mismo empleado que la creó (o podrías poner el usuario actual)
            int empleadoId = ReservaSeleccionada.EmpleadoId;

            // Llamamos al controlador pasando el ID de la reserva al final para que actualice
            var huboError = Rsc.validarReserva(
                clienteId,
                habitacionId,
                empleadoId,
                ingreso,
                salida,
                ReservaSeleccionada.IdPago,
                ReservaSeleccionada.Id // ID IMPORTANTE: Indica actualización
            );

            if (!huboError)
            {
                MessageBox.Show("Reserva actualizada correctamente.");
                this.Close();
            }
        }
    }
}