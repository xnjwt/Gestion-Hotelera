using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Controlador;
namespace Vista
{
    public partial class PrincipalRecepcion : Form
    {

        Empleado EmpleadoLogueado { get; set; }
        //Agregar los demás controladores necesarios

        public PrincipalRecepcion(Empleado empLogueado) //Agregar los demás controladores necesarios
        {
            EmpleadoLogueado = empLogueado;

            InitializeComponent();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contratarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {


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
