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
namespace Vista
{
    public partial class Principal : Form
    {
        EmpleadoControlador Empc { get; set; }
        //Agregar los demás controladores necesarios

        public Principal(EmpleadoControlador empc) //Agregar los demás controladores necesarios
        {
            Empc = empc;

            InitializeComponent();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contratarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CrearEmpleado(Empc);
            frm.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var lEmpleados = Empc.ListarEmpleados();
            var frm = new ListarEmpleado(Empc);
            frm.Show();

        }

        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
