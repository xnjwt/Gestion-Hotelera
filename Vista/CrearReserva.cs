using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador; // Asegúrate de tener esto
using Entidades;   // Y esto

namespace Vista
{
    public partial class CrearReserva : Form
    {
        // Variables para los controladores
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

        
        private void btnRegistrarReserva_Load(object sender, EventArgs e)
        {
            // Llenar lista de Clientes
            cmbClientes.DataSource = Clc.ListarClientes();
            cmbClientes.DisplayMember = "Nombre"; 
            cmbClientes.ValueMember = "Id";       

            // Llenar lista de Habitaciones
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

          
            var huboError = Rsc.validarReserva(clienteId, habitacionId, empleadoId, fechaIngreso, fechaSalida);

            if (!huboError)
            {
                MessageBox.Show("Reserva guardada correctamente.");
                this.Close();
            }
        }
    }
}