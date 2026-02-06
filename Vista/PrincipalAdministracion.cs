using System;
using System.Windows.Forms;
using Controlador;
using Datos;
using Modelo;

namespace Vista
{
    public partial class PrincipalAdministracion : Form
    {
        EmpleadoControlador Empc { get; set; }

        public PrincipalAdministracion(EmpleadoControlador empc)
        {
            Empc = empc;
            InitializeComponent();
        }

        // --- SECCIÓN: CLIENTES ---

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dCli = new ClientesDatos();
            var mCli = new ClienteModelo(dCli);
            var cCli = new ClienteControlador(mCli);

            var frm = new CrearClientes(cCli);
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var dCli = new ClientesDatos();
            var mCli = new ClienteModelo(dCli);
            var cCli = new ClienteControlador(mCli);

            var frm = new ListarClientes(cCli);
            frm.ShowDialog();
        }

        // --- SECCIÓN: RESERVAS ---

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dRes = new ReservasDatos();
            var mRes = new ReservaModelo(dRes);
            var cRes = new ReservaControlador(mRes);

            var dCli = new ClientesDatos();
            var mCli = new ClienteModelo(dCli);
            var cCli = new ClienteControlador(mCli);

            var dHab = new HabitacionesDatos();
            var mHab = new HabitacionModelo(dHab);
            var cHab = new HabitacionControlador(mHab);

            var frm = new CrearReserva(cRes, cCli, cHab);
            frm.ShowDialog();
        }

        // CORRECCIÓN PARA ERROR CS7036 (Imagen 6570a9)
        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var dRes = new ReservasDatos();
            var mRes = new ReservaModelo(dRes);
            var cRes = new ReservaControlador(mRes);

            var dCli = new ClientesDatos();
            var mCli = new ClienteModelo(dCli);
            var cCli = new ClienteControlador(mCli);

            var dHab = new HabitacionesDatos();
            var mHab = new HabitacionModelo(dHab);
            var cHab = new HabitacionControlador(mHab);

            // Se deben pasar los 3 controladores para que el Listar funcione (Imagen 6570a9)
            var frm = new ListarReserva(cRes, cCli, cHab);
            frm.ShowDialog();
        }

        // --- SECCIÓN: PAGOS ---

        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dPag = new PagosDatos();
            var mPag = new PagoModelo(dPag);
            var cPag = new PagoControlador(mPag);

            var dRes = new ReservasDatos();
            var mRes = new ReservaModelo(dRes);
            var cRes = new ReservaControlador(mRes);

            var frm = new CrearPago(cPag, cRes);
            frm.ShowDialog();
        }

        // --- SECCIÓN: EMPLEADOS ---

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

        // Métodos vacíos (Borradas las excepciones "NotImplemented")
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void registrarNuevaToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void listarToolStripMenuItem1_Click(object sender, EventArgs e) { }
        private void crearToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void listarToolStripMenuItem2_Click(object sender, EventArgs e) { }
        private void Principal_Load(object sender, EventArgs e) { }
    }
}