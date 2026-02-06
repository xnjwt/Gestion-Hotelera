using System;
using System.Windows.Forms;
using Controlador;
using Entidades;

namespace Vista
{
    public partial class ListarPagos : Form
    {
        private PagoControlador Pgc;
        private ReservaControlador Rsc;

        // Constructor modificado para inyectar dependencias
        public ListarPagos(PagoControlador pgc, ReservaControlador rsc)
        {
            InitializeComponent();
            Pgc = pgc;
            Rsc = rsc;
        }

        // Carga inicial (Vincular al evento Load del Formulario)
        private void ListarPagos_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            // Vinculación directa de la lista al DataGridView
            dgvReserva.DataSource = null; // Limpiar para refrescar
            dgvReserva.DataSource = Pgc.ListarPagos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvReserva.SelectedRows.Count > 0)
            {
                // Obtener el objeto Pago de la fila seleccionada
                var pagoSeleccionado = (Pago)dgvReserva.SelectedRows[0].DataBoundItem;

                // Abrir formulario de edición pasando los controladores y el pago
                var formActualizar = new ActualizarPago(Pgc, Rsc, pagoSeleccionado);

                // Recargar la grilla cuando se cierre la ventana de edición
                formActualizar.FormClosed += (s, args) => CargarGrid();
                formActualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un pago para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                var pagoSeleccionado = (Pago)dgvReserva.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show("¿Está seguro de eliminar este pago?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Llamada al controlador para eliminar (asumiendo que existe el método, ver abajo)
                    // Si Pgc no tiene Eliminar, lo agregamos en el siguiente bloque
                    Pgc.EliminarPago(pagoSeleccionado.Id);

                    MessageBox.Show("Pago eliminado.");
                    CargarGrid();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pago para eliminar.");
            }
        }
    }
}