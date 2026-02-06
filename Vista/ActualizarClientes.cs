using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Controlador;
using Entidades;

namespace Vista
{
    public partial class ActualizarClientes : Form
    {
        private ClienteControlador Clc { get; set; }
        private Cliente Clie { get; set; }

        public ActualizarClientes(ClienteControlador clc, Cliente clienteSeleccionado)
        {
            Clc = clc;
            Clie = clienteSeleccionado;
            InitializeComponent();
        }

        private void ActualizarCliente_Load(object sender, EventArgs e)
        {
            txtNombres.Text = Clie.Nombre;
            txtApellidos.Text = Clie.Apellido;
            txtCorreo.Text = Clie.Email;
            txtCelular.Text = Clie.Celular;
            txtCedula.Text = Clie.Cedula;
            txtDireccion.Text = Clie.Direccion;

            if (Clie.FechaNacimiento.HasValue)
            {
                dateTimePicker1.Value = Clie.FechaNacimiento.Value;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Captura directa de datos
            string nombre = txtNombres.Text.Trim();
            string apellido = txtApellidos.Text.Trim();
            string email = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            DateTime fechaNac = dateTimePicker1.Value;

            // Llamada directa al controlador
            var huboError = Clc.validarCliente(
                nombre,
                apellido,
                email,
                celular,
                cedula,
                direccion,
                fechaNac,
                cbActivo.Checked,
                Clie.Id
            );

            // Si el controlador dice que no hubo error, cerramos la ventana
            if (!huboError)
            {
                MessageBox.Show("Cliente actualizado correctamente.");
                this.Close();
            }
        }
    }
}