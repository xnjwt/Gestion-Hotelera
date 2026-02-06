using System;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class CrearClientes : Form
    {
        private ClienteControlador Clc { get; set; }

        public CrearClientes(ClienteControlador clc)
        {
            Clc = clc;
            InitializeComponent();
        }

        private void CrearClientes_Load(object sender, EventArgs e)
        {
            // Carga inicial si fuera necesaria
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Captura de datos directa
            string nombre = txtNombres.Text.Trim();
            string apellido = txtApellidos.Text.Trim();
            string email = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            DateTime fechaNac = dateTimePicker1.Value;

            // 2. Llamada directa al controlador
            // Se asume que el controlador maneja la lógica y validación interna
            var huboError = Clc.validarCliente(nombre, apellido, email, celular, cedula, direccion, fechaNac);

            // 3. Si no hubo error reportado por el controlador, cerramos
            if (!huboError)
            {
                MessageBox.Show("Cliente creado exitosamente.");
                this.Close();
            }
        }
    }
}