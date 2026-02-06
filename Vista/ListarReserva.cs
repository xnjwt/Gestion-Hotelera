using System;
using System.Windows.Forms;
using Controlador;
using Entidades;

namespace Vista
{
    public partial class ListarReserva : Form
    {
        private BindingSource bs = new BindingSource();
        private ReservaControlador Rsc;
        private ClienteControlador Clc;
        private HabitacionControlador Hbc;

        public ListarReserva(ReservaControlador rsc, ClienteControlador clc, HabitacionControlador hbc)
        {
            InitializeComponent();
            Rsc = rsc;
            Clc = clc;
            Hbc = hbc;
        }

        private void ListarReserva_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            // Usamos dgvReserva (singular) como está en tu diseño
            bs.DataSource = null;
            bs.DataSource = Rsc.ListarReservas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                var reserva = (Reserva)dgvReserva.SelectedRows[0].DataBoundItem;

                // Abrimos el formulario de actualizar
                var formActualizar = new ActualizarReserva(Rsc, Clc, Hbc, reserva);
                formActualizar.FormClosed += (s, args) => CargarGrid();
                formActualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una reserva.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                var reserva = (Reserva)dgvReserva.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show("¿Está seguro de eliminar esta reserva?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Rsc.EliminarReserva(reserva.Id);
                    CargarGrid();
                    MessageBox.Show("Reserva eliminada.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una reserva para eliminar.");
            }
        }

        private void ListarReserva_Load_1(object sender, EventArgs e)
        {
            bs.DataSource = Rsc.ListarReservas();
            dgvReserva.DataSource = bs;
        }
    }
}