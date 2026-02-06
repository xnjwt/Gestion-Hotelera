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
    public partial class ActualizarTipoHabitacion : Form
    {
        TipoHabitacionControlador Thabc { get; set; }
        private TipoHabitacion THabitacion {  get; set; }
        public ActualizarTipoHabitacion(TipoHabitacionControlador thabc, TipoHabitacion tipoHabitacion)
        {
            Thabc = thabc;
            InitializeComponent();
            THabitacion = tipoHabitacion;
        }

        private void CrearEmpleado_Load(object sender, EventArgs e)
        {
            txtNombre.Text = THabitacion.Nombre;
            txtDescripcion.Text = THabitacion.Caracteristicas;
            txtCapacidad.Text = $"{THabitacion.Capacidad}";
            txtPrecioHora.Text = $"{THabitacion.Precio_noche}";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var error = Thabc.validarTipoHabitacion(
                txtNombre.Text,
                txtDescripcion.Text,
                txtCapacidad.Text,
                txtPrecioHora.Text,
                THabitacion.Id_tipohabitacion
                );

            if (!error)
            {
                MessageBox.Show("Tipo de habitación actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }
    }
}
