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
    public partial class ActualizarEmpleado : Form
    {
        private EmpleadoControlador Empc { get; set; }
        private Empleado Empl { get; set; }
        public ActualizarEmpleado(EmpleadoControlador empc, Empleado empl)
        {
            Empc = empc;
            Empl = empl;
            InitializeComponent();
        }

        private void ActualizarEmpleado_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = Enum.GetValues(typeof(RolEmpleado));
            cmbTurno.DataSource = Enum.GetValues(typeof(TurnoEmpleado));
            txtNombres.Text = Empl.Nombres;
            txtCorreo.Text = Empl.Email;
            txtContrasena.Text = Empl.Contrasena;
            txtCelular.Text = Empl.Celular;
            cmbTurno.SelectedItem = Empl.Turno;
            cmbRol.SelectedItem = Empl.Rol;
            cbActivo.Checked = Empl.Estado.Equals("activo") ? true : false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var error = Empc.validarEmpleado(
                txtNombres.Text,
                txtCorreo.Text,
                txtContrasena.Text,
                txtCelular.Text,
                (RolEmpleado)cmbRol.SelectedValue,
                (TurnoEmpleado)cmbTurno.SelectedValue,
                cbActivo.Checked==true ? "activo": "Inactivo",
                Empl.Id
                );
            if (!error)
            {
                MessageBox.Show("Empleado actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void cbActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
