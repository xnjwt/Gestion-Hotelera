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
    public partial class CrearHabitacion : Form
    {

        private HabitacionControlador Habc { get; set; }
        private TipoHabitacionControlador THabc { get; set; }
        public CrearHabitacion(HabitacionControlador habc, TipoHabitacionControlador tHabc)
        {
            Habc = habc;
            THabc = tHabc;
            InitializeComponent();
        }

        private void CrearEmpleado_Load(object sender, EventArgs e)
        {

            
            cmbTipoHabitacion.DataSource = THabc.ListarTiposHabitacion();
            if (cmbTipoHabitacion.Items.Count == 0)
            {
                MessageBox.Show("Para crear habitaciones debe primero crear tipos de habitacion. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            cmbTipoHabitacion.DisplayMember = "Nombre";
            cmbTipoHabitacion.ValueMember = "Id_tipohabitacion";
            cmbTipoHabitacion.SelectedIndex = 0;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var error =  Habc.validarHabitacion(
                (int)cmbTipoHabitacion.SelectedValue,
                txtNumeroHabitacion.Text,
                txtUbicacion.Text
                );

            if (!error)
            {
                MessageBox.Show("Habitación creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void cmbTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
