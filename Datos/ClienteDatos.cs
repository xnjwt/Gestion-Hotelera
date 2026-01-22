using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ClientesDatos
    {
        private readonly List<Cliente> clientes = new List<Cliente>();

        public Boolean ExisteClienteConEmail(string email, int exceptoID = -1)
        {
            return clientes.Any(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && c.Id !=exceptoID);
        }

        public Boolean ExisteClienteConCedula(string numeroCedula, int exceptoID = -1)
        {
            return clientes.Any(c => c.Cedula.Equals(numeroCedula, StringComparison.OrdinalIgnoreCase) && c.Id != exceptoID);
        }

        public Boolean ExisteClienteConCelular(string celular, int exceptoID = -1)
        {
            return clientes.Any(c => c.Celular.Equals(celular, StringComparison.OrdinalIgnoreCase) && c.Id != exceptoID);
        }

        public void Guardar(Cliente cliente)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));

            clientes.Add(cliente);
        }

        public List<Cliente> Listar()
        {
            return clientes.ToList();
        }

        public List<Cliente> ListarActivos()
        {
            return clientes.Where(c => c.Estado).ToList();
        }

        public Cliente ObtenerPorId(int id)
        {
            return clientes.FirstOrDefault(c => c.Id == id);
        }

        public List<Cliente> Buscar(string coincidencia)
        {
            return clientes.Where(e => e.ToString().Contains(coincidencia, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Cliente> BuscarPorNombre(string nombre)
        {

            return clientes
                .Where(c => (c.Nombre ?? string.Empty).IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            (c.Apellido ?? string.Empty).IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public void Actualizar(Cliente existente,Cliente clienteActualizado)
        {
            if (clienteActualizado == null) throw new ArgumentNullException(nameof(clienteActualizado));

            existente.Nombre = clienteActualizado.Nombre;
            existente.Apellido = clienteActualizado.Apellido;
            existente.Email = clienteActualizado.Email;
            existente.Celular = clienteActualizado.Celular;
            existente.Direccion = clienteActualizado.Direccion;
            existente.Cedula = clienteActualizado.Cedula;
            existente.FechaNacimiento = clienteActualizado.FechaNacimiento;
            existente.UpdatedAt = DateTime.Now;
        }

        public void Desactivar(Cliente existente)
        {
            existente.Desactivar();
        }
    }
}