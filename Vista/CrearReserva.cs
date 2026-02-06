using System;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class CrearReserva : Form
    {
        private ReservaControlador Rsc;
        private ClienteControlador Clc;
        private HabitacionControlador Hbc;

        public CrearReserva(ReservaControlador rsc, ClienteControlador clc, HabitacionControlador hbc)
        {
            InitializeComponent();
            Rsc = rsc;
            Clc = clc;
            Hbc = hbc;
        }

        private void CrearReserva_Load(object sender, EventArgs e)
        {
            cmbClientes.DataSource = Clc.ListarClientes();
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "Id";

            cmbHabitaciones.DataSource = Hbc.ListarHabitaciones();
            cmbHabitaciones.DisplayMember = "Numero";
            cmbHabitaciones.ValueMember = "Id";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);
            int habitacionId = Convert.ToInt32(cmbHabitaciones.SelectedValue);
            DateTime fechaIngreso = dtpIngreso.Value;
            DateTime fechaSalida = dtpSalida.Value;
            int empleadoId = 1;

            bool huboError = Rsc.validarReserva(clienteId, habitacionId, empleadoId, fechaIngreso, fechaSalida);

            if (!huboError)
            {
                MessageBox.Show("Reserva guardada correctamente.");
                this.Close();
            }
        }
    }
}