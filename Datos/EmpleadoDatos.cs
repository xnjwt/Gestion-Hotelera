using Entidades;
using Gestion_Hotelera;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public class EmpleadosDatos
    {
        public Boolean ExisteClienteConEmail(string email, int exceptoID = -1)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                // Corrección: Nombre de tabla en singular 'Empleado'
                string query = "SELECT COUNT(1) FROM Empleado WHERE Email = @email AND Id != @exceptoID";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@email", email);
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
                string query = "SELECT COUNT(1) FROM Empleado WHERE Celular = @celular AND Id != @exceptoID";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@celular", celular);
                    cmd.Parameters.AddWithValue("@exceptoID", exceptoID);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void Guardar(Empleado empleado)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                // Corrección: Se agregó el campo Contrasena que faltaba y se corrigieron los nombres de parámetros
                string query = "INSERT INTO Empleado (Nombres, Email, Contrasena, Celular, Rol, Turno, Estado) " +
                               "VALUES (@nombres, @email, @contrasena, @celular, @rol, @turno, @estado)";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombres", empleado.Nombres);
                    cmd.Parameters.AddWithValue("@email", empleado.Email);
                    cmd.Parameters.AddWithValue("@contrasena", empleado.Contrasena);
                    cmd.Parameters.AddWithValue("@celular", empleado.Celular);

                    // Corrección: Convertir Enum a String antes de enviar a la BD
                    cmd.Parameters.AddWithValue("@rol", empleado.Rol.ToString());
                    cmd.Parameters.AddWithValue("@turno", empleado.Turno.ToString());

                    cmd.Parameters.AddWithValue("@estado", empleado.Estado);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Empleado> Listar()
        {
            var lista = new List<Empleado>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Empleado";

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

        public List<Empleado> ListarActivos()
        {
            var lista = new List<Empleado>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Empleado WHERE Estado = 'Activo'";

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

        public Empleado BuscarPorId(int id)
        {
            Empleado emp = null;

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Empleado WHERE Id = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emp = Mapear(reader);
                        }
                    }
                }
            }
            return emp;
        }

        public List<Empleado> Buscar(string coincidencia)
        {
            var lista = new List<Empleado>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Empleado WHERE Nombres LIKE @c OR Email LIKE @c OR Celular LIKE @c";

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

        public void Actualizar(Empleado existente, Empleado empleadoActualizado)
        {
            if (existente == null) throw new ArgumentNullException(nameof(existente));
            if (empleadoActualizado == null) throw new ArgumentNullException(nameof(empleadoActualizado));

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Empleado SET Nombres=@n, Email=@e, Contrasena=@p, Celular=@c, Rol=@r, Turno=@t, Estado=@est " +
                               "WHERE Id = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", existente.Id);
                    cmd.Parameters.AddWithValue("@n", empleadoActualizado.Nombres);
                    cmd.Parameters.AddWithValue("@e", empleadoActualizado.Email);
                    cmd.Parameters.AddWithValue("@p", empleadoActualizado.Contrasena); // Faltaba actualizar contraseña
                    cmd.Parameters.AddWithValue("@c", empleadoActualizado.Celular);

                    cmd.Parameters.AddWithValue("@r", empleadoActualizado.Rol.ToString());
                    cmd.Parameters.AddWithValue("@t", empleadoActualizado.Turno.ToString());

                    cmd.Parameters.AddWithValue("@est", empleadoActualizado.Estado);

                    cmd.ExecuteNonQuery();
                }
            }

            // Actualizar objeto en memoria
            existente.Nombres = empleadoActualizado.Nombres;
            existente.Email = empleadoActualizado.Email;
            existente.Contrasena = empleadoActualizado.Contrasena;
            existente.Celular = empleadoActualizado.Celular;
            existente.Rol = empleadoActualizado.Rol;
            existente.Turno = empleadoActualizado.Turno;
            existente.Estado = empleadoActualizado.Estado;
        }

        public void Despedir(int idEmpleado)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Empleado SET Estado = 'Inactivo' WHERE Id = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Empleado Mapear(SqlDataReader reader)
        {
            // Corrección: Parsear el String de la BD a Enum
            RolEmpleado rol = (RolEmpleado)Enum.Parse(typeof(RolEmpleado), reader["Rol"].ToString());
            TurnoEmpleado turno = (TurnoEmpleado)Enum.Parse(typeof(TurnoEmpleado), reader["Turno"].ToString());

            return new Empleado
            (
                
                reader["Nombres"].ToString(),
                reader["Email"].ToString(),
                reader["Contrasena"].ToString(),
                reader["Celular"].ToString(),
                rol,
                turno,
                reader["Estado"].ToString(),
                Convert.ToInt32(reader["Id"])
            );
        }
        public Empleado IniciarSesion(string email, string contrasena)
        {
            Empleado emp = null;
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Empleado WHERE Email = @e AND Contrasena = @p AND Estado = 'Activo'";
                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@p", contrasena);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emp = Mapear(reader);
                        }
                    }
                }
            }
            return emp;
        }
    }
}