using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Entidades;
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

        // CORRECCIÓN: Nombre del evento alineado con el diseño
        private void CrearClientes_Load(object sender, EventArgs e)
        {
            // Aquí ya no necesitas cargar Enums de empleados
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Captura de datos desde los componentes (Asegúrate de usar F4 para poner estos nombres)
            string nombre = txtNombres.Text.Trim();
            string apellido = txtApellidos.Text.Trim();
            string email = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            DateTime fechaNac = dateTimePicker1.Value;

            try
            {
                // VALIDACIONES PEDIDAS:
                // 1. Solo letras en Nombre y Apellido
                if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) ||
                    !apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    throw new ArgumentException("El nombre y apellido no pueden contener números.");
                }

                // 2. Exactamente 10 caracteres en Cédula y Celular
                if (cedula.Length != 10 || celular.Length != 10)
                {
                    throw new ArgumentException("La cédula y el celular deben tener exactamente 10 dígitos.");
                }

                // Llamada al controlador (Retorna false si el registro fue exitoso)
                var huboError = Clc.validarCliente(nombre, apellido, email, celular, cedula, direccion, fechaNac);

                if (!huboError)
                {
                    MessageBox.Show("Cliente creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

