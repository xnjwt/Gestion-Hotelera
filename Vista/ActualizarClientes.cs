using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Controlador;
using Entidades;

namespace Vista
{
    public partial class ActualizarCliente : Form
    {
        private ClienteControlador Clc { get; set; }
        private Cliente Clie { get; set; } // Objeto cliente que recibimos para editar

        // El constructor recibe el controlador y el cliente seleccionado de la grilla
        public ActualizarCliente(ClienteControlador clc, Cliente clienteSeleccionado)
        {
            Clc = clc;
            Clie = clienteSeleccionado;
            InitializeComponent();
        }

        private void ActualizarCliente_Load(object sender, EventArgs e)
        {
            // Cargamos los datos actuales del cliente en los cuadros de texto  a
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
            // 1. Captura de datos desde la interfaz
            string nombre = txtNombres.Text.Trim();
            string apellido = txtApellidos.Text.Trim();
            string email = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            DateTime fechaNac = dateTimePicker1.Value;

            try
            {
                // 2. VALIDACIONES: Solo letras en Nombre y Apellido
                if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) ||
                    !apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    throw new ArgumentException("El nombre y apellido no pueden contener números.");
                }

                // 3. VALIDACIONES: Exactamente 10 caracteres en Cédula y Celular
                if (cedula.Length != 10 || celular.Length != 10)
                {
                    throw new ArgumentException("La cédula y el celular deben tener exactamente 10 dígitos.");
                }

                // 4. Llamada al controlador pasando el ID del cliente para actualizar
                // Se envía el ID actual (Clie.Id) para que el modelo sepa qué registro modificar
                var huboError = Clc.validarCliente(
                    nombre,
                    apellido,
                    email,
                    celular,
                    cedula,
                    direccion,
                    fechaNac,
                    Clie.Estado,
                    Clie.Id
                );

                if (!huboError)
                {
                    MessageBox.Show("Información del cliente actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow is null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            // 1. Obtenemos el cliente de la fila seleccionada
            var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            // 2. Abrimos el formulario de Actualizar pasando el Controlador y el Cliente
            ActualizarCliente frm = new ActualizarCliente(Clc, cliente);
            frm.ShowDialog();

            // 3. Refrescamos la tabla al cerrar el formulario
            CargarDatos();
        }

        private void CargarDatos()
        {
            throw new NotImplementedException();
        }
    }
}