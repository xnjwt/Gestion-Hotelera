using System;
using System.Windows.Forms;
using Controlador;
using Entidades;

namespace Vista
{
    public partial class CrearPago : Form
    {
        private PagoControlador Pgc;
        private ReservaControlador Rsc;

        public CrearPago(PagoControlador pgc, ReservaControlador rsc)
        {
            InitializeComponent();
            Pgc = pgc;
            Rsc = rsc;
        }

        private void CrearPago_Load(object sender, EventArgs e)
        {
            // Cargar lista de reservas para seleccionar a cuál se le paga
            cmbReservas.DataSource = Rsc.ListarReservas();
            cmbReservas.DisplayMember = "Id";
            cmbReservas.ValueMember = "Id";

            // Cargar métodos de pago manuales
            cmbMetodo.Items.Add("Efectivo");
            cmbMetodo.Items.Add("Tarjeta");
            cmbMetodo.Items.Add("Transferencia");
            cmbMetodo.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Captura de datos directa
            int reservaId = Convert.ToInt32(cmbReservas.SelectedValue);

            string metodo = cmbMetodo.Text;

            // 2. Llamada al controlador (él se encarga de validar reglas de negocio y guardar)
            var huboError = Pgc.validarPago(reservaId, txtMonto.Text, metodo);

            // 3. Si no hubo error, cerramos
            if (!huboError)
            {
                MessageBox.Show("Pago registrado correctamente.");
                this.Close();
            }
        }
    }
}