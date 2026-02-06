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
using Modelo; 
using Datos; 

namespace Vista
{
    public partial class PrincipalRecepcion : Form
    {

        Empleado EmpleadoLogueado { get; set; }
        private ClienteControlador Clic { get; set; }
        private HabitacionControlador Habc { get; set; }
        private ReservaControlador Resc { get; set; }
        private PagoControlador Pagc { get; set; }

        public PrincipalRecepcion(Empleado empLogueado, ClienteControlador clic ,HabitacionControlador habc,ReservaControlador resc, PagoControlador pagc) 
        {
            EmpleadoLogueado = empLogueado;

            InitializeComponent();
            Clic = clic;
            Habc = habc;
            Resc = resc;
            Pagc = pagc;
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ListarReserva(Resc, Clic, Habc);
            frm.ShowDialog();
        }
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void contratarToolStripMenuItem_Click(object sender, EventArgs e) {

            var frm = new CrearReserva(Resc, Clic, Habc);
            frm.ShowDialog();
        }

        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void registrarNuevaToolStripMenuItem_Click(object sender, EventArgs e) { 
            var frm = new CrearClientes(Clic);
            frm.ShowDialog();   
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e) {
            var frm = new ListarClientes(Clic);
            frm.ShowDialog();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new CrearPago(Pagc, Resc);
            frm.ShowDialog();

        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e) {
            var frm = new ListarPagos(Pagc, Resc);
            frm.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e) { }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}