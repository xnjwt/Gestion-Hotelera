using Entidades;
using Gestion_Hotelera;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class HabitacionesDatos
    {
        public void Guardar(Habitacion habitacion)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Habitacion (Id_tipohabitacion, Numhabitacion, Ubicacion, Descripcion, Disponibilidad) " +
                               "VALUES (@idTipo, @num, @ubi, @desc, @disp)";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idTipo", habitacion.Id_tipohabitacion);
                    cmd.Parameters.AddWithValue("@num", habitacion.Numhabitación);
                    cmd.Parameters.AddWithValue("@ubi", (object)habitacion.Ubicación ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@desc", (object)habitacion.Descripcíon ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@disp", habitacion.Disponibilidad);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Habitacion> Listar()
        {
            var lista = new List<Habitacion>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Habitacion";

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

        public List<Habitacion> ListarDisponibles()
        {
            var lista = new List<Habitacion>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Habitacion WHERE Disponibilidad = 1";

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

        public Habitacion ObtenerPorId(int id)
        {
            Habitacion habitacion = null;

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Habitacion WHERE Id = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            habitacion = Mapear(reader);
                        }
                    }
                }
            }
            return habitacion;
        }

        public void Actualizar(Habitacion habitacionActualizada)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Habitacion SET Id_tipohabitacion=@idTipo, Numhabitacion=@num, Ubicacion=@ubi, " +
                               "Descripcion=@desc, Disponibilidad=@disp WHERE Id=@id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", habitacionActualizada.Id);
                    cmd.Parameters.AddWithValue("@idTipo", habitacionActualizada.Id_tipohabitacion);
                    cmd.Parameters.AddWithValue("@num", habitacionActualizada.Numhabitación);
                    cmd.Parameters.AddWithValue("@ubi", (object)habitacionActualizada.Ubicación ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@desc", (object)habitacionActualizada.Descripcíon ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@disp", habitacionActualizada.Disponibilidad);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idHabitacion)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "DELETE FROM Habitacion WHERE Id = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idHabitacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Habitacion Mapear(SqlDataReader reader)
        {
            return new Habitacion(
                Convert.ToInt32(reader["Id_tipohabitacion"]),
                Convert.ToInt32(reader["Numhabitacion"]),
                reader["Ubicacion"] == DBNull.Value ? "" : reader["Ubicacion"].ToString(),
                reader["Descripcion"] == DBNull.Value ? "" : reader["Descripcion"].ToString(),
                Convert.ToBoolean(reader["Disponibilidad"]),
                Convert.ToInt32(reader["Id"])
            );
        }
    }

    public class TipoHabitacionesDatos
    {
        public void Guardar(TipoHabitacion tipohabitacion)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO TipoHabitacion (Nombre, Caracteristicas, Capacidad, Precio_noche) " +
                               "VALUES (@nombre, @carac, @cap, @precio)";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", tipohabitacion.Nombre);
                    cmd.Parameters.AddWithValue("@carac", (object)tipohabitacion.Caracteristicas ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cap", tipohabitacion.Capacidad);
                    cmd.Parameters.AddWithValue("@precio", tipohabitacion.Precio_noche);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<TipoHabitacion> Listar()
        {
            var lista = new List<TipoHabitacion>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM TipoHabitacion";

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

        public List<String> ListarNombresTipoHabitacion()
        {
            var lista = new List<String>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT Nombre FROM TipoHabitacion";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(reader["Nombre"].ToString());
                        }
                    }
                }
            }
            return lista;
        }

        public List<TipoHabitacion> Buscar(string coincidencia)
        {
            var lista = new List<TipoHabitacion>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM TipoHabitacion WHERE Nombre LIKE @c OR Caracteristicas LIKE @c";

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

        public TipoHabitacion ObtenerPorId(int id)
        {
            TipoHabitacion tipo = null;

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM TipoHabitacion WHERE Id_tipohabitacion = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tipo = Mapear(reader);
                        }
                    }
                }
            }
            return tipo;
        }

        public void Actualizar(TipoHabitacion tipohabitacionActualizada)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "UPDATE TipoHabitacion SET Nombre=@nombre, Caracteristicas=@carac, Capacidad=@cap, Precio_noche=@precio " +
                               "WHERE Id_tipohabitacion=@id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", tipohabitacionActualizada.Id_tipohabitacion);
                    cmd.Parameters.AddWithValue("@nombre", tipohabitacionActualizada.Nombre);
                    cmd.Parameters.AddWithValue("@carac", (object)tipohabitacionActualizada.Caracteristicas ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cap", tipohabitacionActualizada.Capacidad);
                    cmd.Parameters.AddWithValue("@precio", tipohabitacionActualizada.Precio_noche);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idTipoHabitacion)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "DELETE FROM TipoHabitacion WHERE Id_tipohabitacion = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idTipoHabitacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private TipoHabitacion Mapear(SqlDataReader reader)
        {
            return new TipoHabitacion(
                reader["Nombre"].ToString(),
                reader["Caracteristicas"] == DBNull.Value ? "" : reader["Caracteristicas"].ToString(),
                Convert.ToInt32(reader["Capacidad"]),
                Convert.ToSingle(reader["Precio_noche"]),
                Convert.ToInt32(reader["Id_tipohabitacion"])
            );
        }
    }
}