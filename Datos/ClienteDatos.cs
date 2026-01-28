using Entidades;
using Gestion_Hotelera;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class ClientesDatos
    {
        public Boolean ExisteClienteConEmail(string email, int exceptoID = -1)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT COUNT(1) FROM Cliente WHERE Email = @email AND Id != @exceptoID";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@exceptoID", exceptoID);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public Boolean ExisteClienteConCedula(string numeroCedula, int exceptoID = -1)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT COUNT(1) FROM Cliente WHERE Cedula = @cedula AND Id != @exceptoID";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@cedula", numeroCedula);
                    cmd.Parameters.AddWithValue("@exceptoID", exceptoID);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public Boolean ExisteClienteConCelular(string celular, int exceptoID = -1)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT COUNT(1) FROM Cliente WHERE Celular = @celular AND Id != @exceptoID";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@celular", celular);
                    cmd.Parameters.AddWithValue("@exceptoID", exceptoID);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void Guardar(Cliente cliente)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Cliente (Nombre, Apellido, Email, Celular, Cedula, Direccion, FechaNacimiento, Estado, CreatedAt) " +
                               "VALUES (@nombre, @apellido, @email, @celular, @cedula, @direccion, @fechaNacimiento, @estado, @createdAt)";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    cmd.Parameters.AddWithValue("@email", (object)cliente.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@celular", (object)cliente.Celular ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cedula", (object)cliente.Cedula ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@direccion", (object)cliente.Direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", (object)cliente.FechaNacimiento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@estado", cliente.Estado);
                    cmd.Parameters.AddWithValue("@createdAt", cliente.CreatedAt);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Cliente> Listar()
        {
            var lista = new List<Cliente>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Cliente";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }
            return lista;
        }

        public List<Cliente> ListarActivos()
        {
            var lista = new List<Cliente>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Cliente WHERE Estado = 1";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }
            return lista;
        }

        public Cliente ObtenerPorId(int id)
        {
            Cliente cliente = null;

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Cliente WHERE Id = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = Mapear(reader);
                        }
                    }
                }
            }
            return cliente;
        }

        public List<Cliente> Buscar(string coincidencia)
        {
            var lista = new List<Cliente>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Cliente WHERE Nombre LIKE @c OR Apellido LIKE @c OR Cedula LIKE @c OR Email LIKE @c";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@c", "%" + coincidencia + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }
            return lista;
        }

        public List<Cliente> BuscarPorNombre(string nombre)
        {
            var lista = new List<Cliente>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Cliente WHERE Nombre LIKE @n OR Apellido LIKE @n";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@n", "%" + nombre + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }
            return lista;
        }

        public void Actualizar(Cliente existente, Cliente clienteActualizado)
        {
            if (clienteActualizado == null) throw new ArgumentNullException(nameof(clienteActualizado));

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Cliente SET Nombre=@nombre, Apellido=@apellido, Email=@email, Celular=@celular, " +
                               "Cedula=@cedula, Direccion=@direccion, FechaNacimiento=@fechaNacimiento, UpdatedAt=@updatedAt " +
                               "WHERE Id = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", existente.Id);
                    cmd.Parameters.AddWithValue("@nombre", clienteActualizado.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", clienteActualizado.Apellido);
                    cmd.Parameters.AddWithValue("@email", (object)clienteActualizado.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@celular", (object)clienteActualizado.Celular ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cedula", (object)clienteActualizado.Cedula ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@direccion", (object)clienteActualizado.Direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", (object)clienteActualizado.FechaNacimiento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }

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
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Cliente SET Estado = 0 WHERE Id = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", existente.Id);
                    cmd.ExecuteNonQuery();
                }
            }

            existente.Estado = false;
        }

        private Cliente Mapear(SqlDataReader reader)
        {

            Cliente cliente = new Cliente(
                reader["Nombre"].ToString(),
                reader["Apellido"].ToString(),
                reader["Email"] == DBNull.Value ? null : reader["Email"].ToString(),
                reader["Celular"] == DBNull.Value ? null : reader["Celular"].ToString(),
                reader["Cedula"] == DBNull.Value ? null : reader["Cedula"].ToString(),
                reader["Direccion"] == DBNull.Value ? null : reader["Direccion"].ToString(),
                reader["FechaNacimiento"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaNacimiento"]),
                Convert.ToBoolean(reader["Estado"]),
                Convert.ToInt32(reader["Id"]) 
            );

            if (reader["CreatedAt"] != DBNull.Value)
            {
                cliente.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);
            }
            if (reader["UpdatedAt"] != DBNull.Value)
            {
                cliente.UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"]);
            }

            return cliente;
        }
    }
}