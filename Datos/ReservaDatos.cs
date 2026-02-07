using Entidades;
using Gestion_Hotelera;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public class ReservasDatos
    {
        public void Guardar(Reserva reserva)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Reserva (ClienteId, HabitacionId, EmpleadoId, IdPago, FechaIngreso, FechaSalida, Estado) " +
                               "VALUES (@cId, @hId, @eId, @pId, @fIn, @fOut, @est)";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@cId", reserva.ClienteId);
                    cmd.Parameters.AddWithValue("@hId", reserva.HabitacionId);
                    cmd.Parameters.AddWithValue("@eId", reserva.EmpleadoId);
                    cmd.Parameters.AddWithValue("@pId", (object)reserva.IdPago ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fIn", reserva.FechaIngreso);
                    cmd.Parameters.AddWithValue("@fOut", reserva.FechaSalida);
                    cmd.Parameters.AddWithValue("@est", reserva.Estado.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Reserva reserva)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Reserva SET ClienteId=@cId, HabitacionId=@hId, FechaIngreso=@fIn, FechaSalida=@fOut, Estado=@est WHERE Id=@id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@cId", reserva.ClienteId);
                    cmd.Parameters.AddWithValue("@hId", reserva.HabitacionId);
                    cmd.Parameters.AddWithValue("@fIn", reserva.FechaIngreso);
                    cmd.Parameters.AddWithValue("@fOut", reserva.FechaSalida);
                    cmd.Parameters.AddWithValue("@est", reserva.Estado.ToString());
                    cmd.Parameters.AddWithValue("@id", reserva.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Cancelar(int idReserva)
        {
            //Cambia el estado de reserva a cancelada
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Reserva SET Estado='Cancelada' WHERE Id=@id";
                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idReserva);
                    cmd.ExecuteNonQuery();
                }
            }



        }

        public List<Reserva> Listar()
        {
            var lista = new List<Reserva>();
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Reserva";
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

        public List<Reserva> ListarActivas()
        {
            var lista = new List<Reserva>();
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();

                string query = "SELECT * FROM Reserva WHERE Estado = 'Pendiente'";

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
        public List<Reserva> ListarConfirmadas()
        {
            var lista = new List<Reserva>();
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Reserva WHERE Estado = 'Confirmada'";
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
        public List<Reserva> ListarCanceladas()
        {
            var lista = new List<Reserva>();
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Reserva WHERE Estado = 'Cancelada'";
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
        public Reserva BuscarPorId(int id)
        {
            Reserva reserva = null;
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Reserva WHERE Id = @id";
                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reserva = Mapear(reader);
                        }
                    }
                }
            }
            return reserva;
        }

        public List<Reserva> Buscar(string coincidencia)
        {
            var lista = new List<Reserva>();
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Reserva WHERE Estado LIKE @c";
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

        public List<Reserva> BuscarPorCliente(int clienteId)
        {
            var lista = new List<Reserva>();
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Reserva WHERE ClienteId = @id";
                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", clienteId);
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

        public void AsignarPago(Reserva reserva, int idPago)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Reserva SET IdPago = @pId WHERE Id = @rId";
                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@pId", idPago);
                    cmd.Parameters.AddWithValue("@rId", reserva.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Reserva Mapear(SqlDataReader reader)
        {
            var reserva = new Reserva(
                Convert.ToInt32(reader["ClienteId"]),
                Convert.ToInt32(reader["HabitacionId"]),
                Convert.ToInt32(reader["EmpleadoId"]),
                Convert.ToDateTime(reader["FechaIngreso"]),
                Convert.ToDateTime(reader["FechaSalida"]),
                Convert.ToInt32(reader["Id"])
            );

            if (reader["IdPago"] != DBNull.Value)
                reserva.IdPago = Convert.ToInt32(reader["IdPago"]);

            if (Enum.TryParse(typeof(EstadoReserva), reader["Estado"].ToString(), out object estadoParsed))
                reserva.Estado = (EstadoReserva)estadoParsed;
            else
                reserva.Estado = EstadoReserva.Pendiente;

            return reserva;
        }
    }
}