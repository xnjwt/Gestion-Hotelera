using Controlador;
using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ListarTipoHabitacion : Form
    {
        private BindingSource bs = new BindingSource();
        private TipoHabitacionControlador THabc { get; set; }
        public ListarTipoHabitacion(TipoHabitacionControlador tHabc)
        {
            InitializeComponent();
            dgvTiposHabitacion.AutoGenerateColumns = false;
            dgvTiposHabitacion.DataError += (s, e) =>
            {
                e.ThrowException = false;
            };
            THabc = tHabc;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarTipoHabitacion_Load(object sender, EventArgs e)
        {
            bs.DataSource = THabc.ListarTiposHabitacion();
            dgvTiposHabitacion.DataSource = bs;
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvTiposHabitacion.CurrentRow is null)
            {
                MessageBox.Show("Seleccione un tipo de habitación para eliminar.");
                return;
            }

            var respuesta = MessageBox.Show("Está seguro que desea eliminar el tipo de habitación seleccionado?", "Confirma Eliminación", MessageBoxButtons.OKCancel);
            if (respuesta == DialogResult.Cancel)
            {
                return;
            }
            var tipoHabitacion = (TipoHabitacion)dgvTiposHabitacion.CurrentRow.DataBoundItem;
            THabc.EliminarTipoHabitacion(tipoHabitacion.Id_tipohabitacion);
            MessageBox.Show("Tipo de habitación eliminado correctamente.");
            bs.DataSource = null;
            bs.DataSource = THabc.ListarTiposHabitacion();


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvTiposHabitacion.CurrentRow is null)
            {
                MessageBox.Show("Seleccione un tipo de habitación para eliminar.");
                return;
            }
            var tipoHabitacion = (TipoHabitacion)dgvTiposHabitacion.CurrentRow.DataBoundItem;
            ActualizarTipoHabitacion frm = new (THabc, tipoHabitacion);
            frm.ShowDialog();
            frm.Dispose();
            bs.DataSource = null;
            bs.DataSource = THabc.ListarTiposHabitacion();
        }
    }
}
