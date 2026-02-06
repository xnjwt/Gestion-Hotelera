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
using Modelo; // Agregado para poder crear los modelos
using Datos;  // Agregado para poder crear los datos

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

        // --- BOTÓN CLIENTES ---
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creamos las dependencias al vuelo
            var dCli = new ClientesDatos();
            var mCli = new ClienteModelo(dCli);
            var cCli = new ClienteControlador(mCli);

            // Abrimos la ventana
            var frm = new ListarClientes(cCli);
            frm.ShowDialog();
        }

        // --- BOTÓN PAGOS ---
        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Controlador Pagos
            var dPag = new PagosDatos();
            var mPag = new PagoModelo(dPag);
            var cPag = new PagoControlador(mPag);

            // Controlador Reservas (Necesario para pagos)
            var dRes = new ReservasDatos();
            var mRes = new ReservaModelo(dRes);
            var cRes = new ReservaControlador(mRes);

            // Abrimos la ventana
            var frm = new ListarPagos(cPag, cRes);
            frm.ShowDialog();
        }

        // --- BOTÓN RESERVAS (LISTAR) ---
        // Asumiendo que este es el evento para listar reservas (verificar nombre en tu diseño)
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Controlador Reserva
            var dRes = new ReservasDatos();
            var mRes = new ReservaModelo(dRes);
            var cRes = new ReservaControlador(mRes);

            // Controlador Cliente
            var dCli = new ClientesDatos();
            var mCli = new ClienteModelo(dCli);
            var cCli = new ClienteControlador(mCli);

            // Controlador Habitación
            var dHab = new HabitacionesDatos();
            var mHab = new HabitacionModelo(dHab);
            var cHab = new HabitacionControlador(mHab);

            // Abrimos la ventana
            var frm = new ListarReserva(cRes, cCli, cHab);
            frm.ShowDialog();
        }

        // --- EVENTOS VACÍOS (No los toco, como pediste) ---

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void contratarToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void registrarNuevaToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e) { }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e) { }

        private void Principal_Load(object sender, EventArgs e) { }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}