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
        private PagoControlador Pgc;
        private ClienteControlador Clc;
        private HabitacionControlador Hbc;

        public ListarReserva(ReservaControlador rsc,PagoControlador pgc, ClienteControlador clc, HabitacionControlador hbc)
        {
            InitializeComponent();
            Rsc = rsc;
            Pgc = pgc;
            Clc = clc;
            Hbc = hbc;
        }

        private void ListarReserva_Load(object sender, EventArgs e)
        {
            
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }


        private void ListarReserva_Load_1(object sender, EventArgs e)
        {
            bs.DataSource = Rsc.ListarReservas();
            dgvReserva.DataSource = bs;
            cmbEstado.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                var reserva = (Reserva)dgvReserva.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show("¿Está seguro de cancelar esta reserva?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Rsc.CancelarReserva(reserva.Id);
                    MessageBox.Show("Reserva cancelada.");
                    ActualizarEstado();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una reserva para cancelar.");
            }
        }
        private void ActualizarEstado()
        {
            bs.DataSource = null;
            switch (cmbEstado.SelectedIndex)
            {
                case 0:
                    bs.DataSource = Rsc.ListarReservas();
                    break;
                case 1:
                    bs.DataSource = Rsc.ListarReservasActivas();
                    break;
                case 2:
                    bs.DataSource = Rsc.ListarReservasConfirmadas();
                    break;
                case 3:
                    bs.DataSource = Rsc.ListarReservasCanceladas();
                    break;
            }
        }
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstado();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count > 0)
            {
                var reserva = (Reserva) dgvReserva.SelectedRows[0].DataBoundItem;
                var reservaCompleta = Rsc.BuscarReservaPorId(reserva.Id);
                
                var formActualizar = new ActualizarReserva(Rsc, Pgc, Clc, Hbc, reservaCompleta);

                formActualizar.ShowDialog();
                ActualizarEstado();
            }
            else
            {
                MessageBox.Show("Seleccione una reserva.");
            }
        }
    }
}