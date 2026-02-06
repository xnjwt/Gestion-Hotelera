using System;
using System.Windows.Forms;
using Controlador;
using Datos;
using Modelo;

namespace Vista
{
    public partial class PrincipalAdministracion : Form
    {
        // Propiedad para el controlador de empleados recibido en el constructor
        EmpleadoControlador Empc { get; set; }
        ClienteControlador Clic { get; set; }
        HabitacionControlador Habc { get; set; }
        ReservaControlador Resc { get; set; }
        PagoControlador Pagc { get; set; }
        public PrincipalAdministracion(EmpleadoControlador empc,ClienteControlador clic, HabitacionControlador habc, ReservaControlador resc,PagoControlador pagc)
        {
            InitializeComponent();
            Empc = empc;
            Clic = clic;
            Habc = habc;
            Resc = resc;
            Pagc = pagc;
        }


        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var frm = new CrearClientes(Clic);
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            var frm = new ListarClientes(Clic);
            frm.ShowDialog();
        }


        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            
        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }


        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var frm = new CrearPago(Pagc, Resc);
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem5_Click(object sender, EventArgs e)
        {

            var frm = new ListarPagos(Pagc, Resc);
            frm.ShowDialog();
        }


        private void contratarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CrearEmpleado(Empc);
            frm.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ListarEmpleado(Empc);
            frm.Show();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void registrarNuevaToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void listarToolStripMenuItem1_Click(object sender, EventArgs e) { }
        private void crearToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void listarToolStripMenuItem2_Click(object sender, EventArgs e) { }
        private void Principal_Load(object sender, EventArgs e) { }
    }
}