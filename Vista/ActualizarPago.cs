using System;
using System.Windows.Forms;
using Controlador;
using Entidades;

namespace Vista
{
    public partial class ActualizarPago : Form
    {
        private PagoControlador Pgc;
        private ReservaControlador Rsc;
        private Pago PagoSeleccionado;

        // Constructor modificado para recibir dependencias y el pago a editar
        public ActualizarPago(PagoControlador pgc, ReservaControlador rsc, Pago pago)
        {
            InitializeComponent();
            Pgc = pgc;
            Rsc = rsc;
            PagoSeleccionado = pago;
        }

        private void ActualizarPago_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarDatosExistentes();
        }

        private void CargarCombos()
        {
            // Llenar Reservas
            cmbReservas.DataSource = Rsc.ListarReservas();
            cmbReservas.DisplayMember = "Id";
            cmbReservas.ValueMember = "Id";

            // Llenar Métodos
            cmbMetodo.Items.Add("Efectivo");
            cmbMetodo.Items.Add("Tarjeta");
            cmbMetodo.Items.Add("Transferencia");
        }

        private void CargarDatosExistentes()
        {
            // Seteamos los valores actuales para que el usuario los vea
            cmbReservas.SelectedValue = PagoSeleccionado.ReservaId;
            cmbMetodo.SelectedItem = PagoSeleccionado.Metodo;
            txtMonto.Text = PagoSeleccionado.MontoTotal.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // 1. Capturar datos modificados
            int reservaId = Convert.ToInt32(cmbReservas.SelectedValue);
            string metodo = cmbMetodo.Text;

            // Conversión básica del monto
            

            // 2. Llamar al controlador enviando el ID del pago existente
            // El ID es la clave para que el controlador sepa que es UPDATE y no INSERT
            var huboError = Pgc.validarPago(
                reservaId,
                txtMonto.Text,
                metodo,
                PagoSeleccionado.Id // ID IMPORTANTE
            );

            // 3. Cerrar si éxito
            if (!huboError)
            {
                MessageBox.Show("Pago actualizado correctamente.");
                this.Close();
            }
        }
    }
}