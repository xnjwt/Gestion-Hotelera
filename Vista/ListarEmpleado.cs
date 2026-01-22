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
    public partial class ListarEmpleado : Form
    {
        private BindingSource bs = new BindingSource();
        private EmpleadoControlador Empc { get; set; }
        public ListarEmpleado(EmpleadoControlador empc)
        {
            InitializeComponent();
            Empc = empc;
            dgvEmpleados.AutoGenerateColumns = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow is null)
            {
                MessageBox.Show("Seleccione un empleado para poder actualizar su información.");
                return;
            }

            var empleado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
            ActualizarEmpleado frm = new (Empc, empleado);
            frm.ShowDialog();
            frm.Dispose();
            bs.DataSource = null;
            bs.DataSource = Empc.ListarEmpleados();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow is null)
            {
                MessageBox.Show("Seleccione un empleado para despedir.");
                return;
            }
            var respuesta = MessageBox.Show("Está seguro que desea despedir el empleado seleccionado?", "Confirma Eliminación", MessageBoxButtons.OKCancel);
            if (respuesta == DialogResult.Cancel)
            {
                return;
            }

            var empleado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
            int id = empleado.Id;
            Empc.DespedirEmpleado(id);
            MessageBox.Show("Empleado despedido correctamente.");
            bs.DataSource = null;
            bs.DataSource = Empc.ListarEmpleados();





        }

        private void ListarEmpleado_Load(object sender, EventArgs e)
        {
            bs.DataSource = Empc.ListarEmpleados();
            dgvEmpleados.DataSource = bs;
        }
    }
}
