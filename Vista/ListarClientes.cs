using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{
    public partial class ListarClientes : Form
    {
        private BindingSource bs = new BindingSource();
        private ClienteControlador Clc { get; set; }

        public ListarClientes(ClienteControlador clc)
        {
            InitializeComponent();
            Clc = clc;

            // Evita que se creen columnas automáticas de otros modelos
            dgvClientes.AutoGenerateColumns = false;
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow is null)
            {
                MessageBox.Show("Seleccione un cliente para poder actualizar su información.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            // Se añade la visualización de la Fecha de Nacimiento en el mensaje
            string fecha = cliente.FechaNacimiento?.ToShortDateString() ?? "No registrada";
            MessageBox.Show($"Abriendo edición para: {cliente.Nombre}\nFecha Nacimiento: {fecha}");

            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow is null)
            {
                MessageBox.Show("Seleccione un cliente para desactivar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var respuesta = MessageBox.Show("¿Está seguro que desea desactivar el cliente seleccionado?", "Confirmar Acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Cancel) return;

            var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            Clc.DesactivarCliente(cliente.Id);

            MessageBox.Show("Cliente desactivado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
        }

        private void CargarDatos()
        {
            bs.DataSource = null;
            // Obtiene la lista actualizada desde el controlador
            bs.DataSource = Clc.ListarClientes();
            dgvClientes.DataSource = bs;
        }
    }
}