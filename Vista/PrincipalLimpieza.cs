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
    public partial class PrincipalLimpieza : Form
    {
        private HabitacionControlador Habc { get; set; }
        private TipoHabitacionControlador THabc { get; set; }
        public PrincipalLimpieza(HabitacionControlador habc, TipoHabitacionControlador thabc) 
        {
            Habc = habc;
            THabc = thabc;

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
            var frm = new ListarHabitacion(Habc, THabc);
            frm.ShowDialog();
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
