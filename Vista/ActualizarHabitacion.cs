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
    public partial class ActualizarHabitacion : Form
    {

        private HabitacionControlador Habc { get; set; }
        private TipoHabitacionControlador THabc { get; set; }
        private Habitacion Hab {  get; set; }
        public ActualizarHabitacion(HabitacionControlador habc, TipoHabitacionControlador tHabc, Habitacion hab)
        {
            Habc = habc;
            THabc = tHabc;
            InitializeComponent();
            Hab = hab;
        }

        private void CrearEmpleado_Load(object sender, EventArgs e)
        {

            
            cmbTipoHabitacion.DataSource = THabc.ListarTiposHabitacion();
            cmbTipoHabitacion.DisplayMember = "Nombre";
            cmbTipoHabitacion.ValueMember = "Id_tipohabitacion";
            cmbTipoHabitacion.SelectedItem = Hab.Id_tipohabitacion;
            txtNumeroHabitacion.Text = $"{Hab.Numhabitación}";
            txtUbicacion.Text = Hab.Ubicación;
            txtUbicacion.Text = Hab.Descripcíon;
            chbDisponibilidad.Checked = Hab.Disponibilidad;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var error =  Habc.validarHabitacion(
                (int)cmbTipoHabitacion.SelectedValue,
                txtNumeroHabitacion.Text,
                txtUbicacion.Text,
                txtDescripcion.Text,
                chbDisponibilidad.Checked,
                Hab.Id
                );

            if (!error)
            {
                MessageBox.Show("Habitación actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void cmbTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
