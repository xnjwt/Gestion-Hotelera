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
    public partial class CrearTipoHabitacion : Form
    {
        TipoHabitacionControlador Thabc { get; set; }
        public CrearTipoHabitacion(TipoHabitacionControlador thabc)
        {
            Thabc = thabc;
            InitializeComponent();
        }

        private void CrearEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var error = Thabc.validarTipoHabitacion(
                txtNombre.Text,
                txtDescripcion.Text,
                txtCapacidad.Text,
                txtPrecioHora.Text
                );

            if (!error)
            {
                MessageBox.Show("Tipo de habitación creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }
    }
}
