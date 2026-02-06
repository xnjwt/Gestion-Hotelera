using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Vista
{
    public partial class ListarHabitacion : Form
    {
        private BindingSource bs = new BindingSource();
        private HabitacionControlador Habc { get; set; }
        private TipoHabitacionControlador THabc { get; set; }
        public ListarHabitacion(HabitacionControlador habc, TipoHabitacionControlador tHabc)
        {
            InitializeComponent();
            Habc = habc;
            THabc = tHabc;
            dgvHabitaciones.AutoGenerateColumns = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarHabitacion_Load(object sender, EventArgs e)
        {
            bs.DataSource = Habc.ListarHabitaciones();
            dgvHabitaciones.DataSource = bs;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow is null)
            {
                MessageBox.Show("Seleccione una habitación para eliminar.");
                return;
            }
            var respuesta = MessageBox.Show("Está seguro que desea eliminar la habitación seleccionada?", "Confirma Eliminación", MessageBoxButtons.OKCancel);
            if (respuesta == DialogResult.Cancel)
            {
                return;
            }

            var habitacion = (Habitacion)dgvHabitaciones.CurrentRow.DataBoundItem;
            int id = habitacion.Id;
            Habc.EliminarHabitacion(id);
            dgvHabitaciones.DataSource = Habc.ListarHabitaciones();

            MessageBox.Show("Habitación eliminada correctamente.");
            bs.DataSource = null;
            bs.DataSource = Habc.ListarHabitaciones();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow is null)
            {
                MessageBox.Show("Seleccione una habitación para actualizar su información.");
                return;
            }
            var habitacion = (Habitacion)dgvHabitaciones.CurrentRow.DataBoundItem;
            ActualizarHabitacion frm = new (Habc,THabc, habitacion);
            frm.ShowDialog();
            frm.Dispose();
            bs.DataSource = null;
            bs.DataSource = Habc.ListarHabitaciones();
        }
    }
}
