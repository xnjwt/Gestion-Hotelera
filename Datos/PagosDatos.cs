using Entidades;
using Gestion_Hotelera;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class PagosDatos
    {
        public void Guardar(Pago pago)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Pago (ReservaId, MontoTotal, Metodo, FechaPago) VALUES (@reservaId, @monto, @metodo, @fecha)";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@reservaId", pago.ReservaId);
                    cmd.Parameters.AddWithValue("@monto", pago.MontoTotal);
                    cmd.Parameters.AddWithValue("@metodo", pago.Metodo);
                    cmd.Parameters.AddWithValue("@fecha", pago.FechaPago == default ? DateTime.Now : pago.FechaPago);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Pago> Listar()
        {
            var lista = new List<Pago>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Pago";

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

        public Pago BuscarPorId(int id)
        {
            Pago pago = null;

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Pago WHERE Id = @id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pago = Mapear(reader);
                        }
                    }
                }
            }
            return pago;
        }

        public List<Pago> Buscar(string coincidencia)
        {
            var lista = new List<Pago>();

            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Pago WHERE Metodo LIKE @c";

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

        public void Actualizar(Pago pagoActualizado)
        {
            using (var conexion = ConexionDB.GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Pago SET ReservaId=@reservaId, MontoTotal=@monto, Metodo=@metodo, FechaPago=@fecha WHERE Id=@id";

                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", pagoActualizado.Id);
                    cmd.Parameters.AddWithValue("@reservaId", pagoActualizado.ReservaId);
                    cmd.Parameters.AddWithValue("@monto", pagoActualizado.MontoTotal);
                    cmd.Parameters.AddWithValue("@metodo", pagoActualizado.Metodo);
                    cmd.Parameters.AddWithValue("@fecha", pagoActualizado.FechaPago);

                    int filas = cmd.ExecuteNonQuery();
                    if (filas == 0)
                    {
                        throw new ArgumentException("Pago no encontrado para actualizar.");
                    }
                }
            }
        }

        private Pago Mapear(SqlDataReader reader)
        {
            var pago = new Pago(
                reader["ReservaId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ReservaId"]),
                Convert.ToDecimal(reader["MontoTotal"]),
                reader["Metodo"].ToString(),
                Convert.ToInt32(reader["Id"])
            );

            if (reader["FechaPago"] != DBNull.Value)
            {
                pago.FechaPago = Convert.ToDateTime(reader["FechaPago"]);
            }

            return pago;
        }
    }
}