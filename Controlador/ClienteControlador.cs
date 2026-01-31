using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Controlador
{
    public class ClienteControlador
    {
        private ClienteModelo mdl { get; set; }

        public ClienteControlador(ClienteModelo modelo)
        {
            mdl = modelo;
        }

        public Boolean validarCliente(string nombre, string apellido, string email, string celular, string cedula, string direccion, DateTime? fechaNacimiento, bool estado = true, int idCliente = -1)
        {
            // Validaciones Regex (Formato de texto)
            var mNombre = Regex.Match(nombre, @".{3,}");
            var mEmail = Regex.Match(email, @".+@.+\..+");
            var mCelular = Regex.Match(celular, @"^\d{10}$");
            var mCedula = Regex.Match(cedula, @"^\d{10}$");

            try
            {
                if (!mNombre.Success) throw new ArgumentException("El nombre debe tener al menos 3 caracteres.");
                if (!mEmail.Success) throw new ArgumentException("Ingrese un email válido.");
                if (!mCelular.Success) throw new ArgumentException("El celular debe contener 10 dígitos.");
                if (!mCedula.Success) throw new ArgumentException("La cédula debe contener 10 dígitos.");
                if (string.IsNullOrWhiteSpace(direccion)) throw new ArgumentException("La dirección es obligatoria.");

                // Crear objeto entidad con el orden exacto de tu constructor
                var cliente = new Cliente(
                    nombre.Trim(),
                    apellido.Trim(),
                    email.Trim(),
                    celular.Trim(),
                    cedula.Trim(), // Cedula con C mayúscula según tu entidad
                    direccion.Trim(),
                    fechaNacimiento,
                    estado,
                    idCliente
                );

                if (idCliente == -1)
                {
                    mdl.Guardar(cliente);
                }
                else
                {
                    mdl.Actualizar(cliente);
                }

                return false; // Éxito
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; // Hubo error
            }
        }

        public List<Cliente> ListarClientes() => mdl.Listar();
        public List<Cliente> ListarClientesActivos() => mdl.ListarActivos();
        public List<Cliente> BuscarClientes(string coincidencia) => mdl.Buscar(coincidencia);
        public void DesactivarCliente(int idCliente) => mdl.Desactivar(idCliente);
    }
}