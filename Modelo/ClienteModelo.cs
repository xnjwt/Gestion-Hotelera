using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public class ClienteModelo
    {
        private ClientesDatos Dts { get; set; }

        public ClienteModelo(ClientesDatos dts)
        {
            Dts = dts;
        }

        public void Guardar(Cliente cliente)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));

            // Verificaciones de duplicados usando los métodos de tu clase ClientesDatos
            if (Dts.ExisteClienteConCedula(cliente.Cedula))
                throw new ArgumentException("La cédula ya se encuentra registrada.");

            if (Dts.ExisteClienteConEmail(cliente.Email))
                throw new ArgumentException("El email ya se encuentra registrado.");
            //El cliente debe ser mayor de edad
            if (cliente.FechaNacimiento.HasValue && cliente.FechaNacimiento.Value > DateTime.Now.AddYears(-18))
                throw new ArgumentException("El cliente debe ser mayor de edad.");

            Dts.Guardar(cliente); //
        }

        public List<Cliente> Listar() => Dts.Listar(); //

        public List<Cliente> ListarActivos() => Dts.ListarActivos(); 
        public List<Cliente> ListarInactivos() => Dts.ListarInactivos();

        public Cliente ObtenerPorId(int id) => Dts.ObtenerPorId(id); //

        public List<Cliente> Buscar(string coincidencia) => Dts.Buscar(coincidencia); //

        public void Actualizar(Cliente clienteActualizado)
        {
            if (clienteActualizado == null) throw new ArgumentNullException(nameof(clienteActualizado));

            var existente = Dts.ObtenerPorId(clienteActualizado.Id); //
            if (existente == null)
                throw new InvalidOperationException("El cliente no existe.");

            if(Dts.ExisteClienteConEmail(clienteActualizado.Email, clienteActualizado.Id))
                throw new ArgumentException("El email ya pertenece a otro cliente.");
            if (Dts.ExisteClienteConCedula(clienteActualizado.Cedula, clienteActualizado.Id))
                throw new ArgumentException("La cédula ya pertenece a otro cliente.");

            if (clienteActualizado.FechaNacimiento.HasValue && clienteActualizado.FechaNacimiento.Value > DateTime.Now.AddYears(-18))
                throw new ArgumentException("El cliente debe ser mayor de edad.");
            Dts.Actualizar(existente, clienteActualizado); //
        }

        public void Desactivar(int idCliente)
        {
            var existente = Dts.ObtenerPorId(idCliente); //
            if (existente != null)
            {
                Dts.Desactivar(existente); //
            }
        }
    }
}