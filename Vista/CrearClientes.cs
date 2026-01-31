using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Entidades;
namespace Vista
{
    public partial class CrearClientes : Form
    {
        private ClienteControlador Clc { get; set; }
        public CrearClientes(ClienteControlador clc)
        {
            Clc = clc;
            InitializeComponent();
        }

        private void CrearEmpleado_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = Enum.GetValues(typeof(RolEmpleado));
            cmbTurno.DataSource = Enum.GetValues(typeof(TurnoEmpleado));

            cmbTurno.SelectedIndex = 0;
            cmbRol.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var error = Clc.validarCliente();


            {
                MessageBox.Show("Cliente  creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }
    }
}
