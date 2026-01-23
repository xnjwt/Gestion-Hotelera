using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Entidades;
using Modelo;

namespace Datos
{
    public class HabitacionDatos
    {
        private readonly string cadenaConexion =
            "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Habitaciones; Integrated Security=True; TrustServerCertificate=True";

        // LISTAR TODAS LAS HABITACIONES
        public List<Habitacion> Listar()
        {
            List<Habitacion> lista = new List<Habitacion>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SELECT * FROM Habitacion", conexion);
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Habitacion(
                        Convert.ToInt32(dr["id_habitacion"]),
                        Convert.ToInt32(dr["num_habitacion"]),
                        dr["tipo_habitacion"].ToString(),
                        dr["capacidad"].ToString(),
                        Convert.ToInt32(dr["precio_noche"]),
                        dr["caracteristicas"].ToString(),
                        dr["ubicacion"].ToString(),
                        Convert.ToBoolean(dr["disponibilidad"])
                    ));
                }
            }

            return lista;
        }

        // BUSCAR POR ID
        public Habitacion BuscarPorId(int id)
        {
            Habitacion hab = null;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand(
                    "SELECT * FROM Habitacion WHERE id_habitacion = @id", conexion);

                comando.Parameters.AddWithValue("@id", id);

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    hab = new Habitacion(
                        Convert.ToInt32(dr["id_habitacion"]),
                        Convert.ToInt32(dr["num_habitacion"]),
                        dr["tipo_habitacion"].ToString(),
                        dr["capacidad"].ToString(),
                        Convert.ToInt32(dr["precio_noche"]),
                        dr["caracteristicas"].ToString(),
                        dr["ubicacion"].ToString(),
                        Convert.ToBoolean(dr["disponibilidad"])
                    );
                }
            }

            return hab;
        }

        // LISTAR TIPOS DE HABITACIÓN
        public List<string> ObtenerTiposHabitacion()
        {
            List<string> tipos = new List<string>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT DISTINCT tipo_habitacion FROM Habitacion";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tipos.Add(dr.GetString(0));
                    }
                }
            }

            return tipos;
        }

        // FILTRAR HABITACIONES POR TIPO
        public List<Habitacion> ObtenerHabitacionesPorTipo(string tipo)
        {
            List<Habitacion> lista = new List<Habitacion>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = "SELECT * FROM Habitacion WHERE tipo_habitacion = @tipo";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tipo", tipo);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Habitacion(
                        Convert.ToInt32(dr["id_habitacion"]),
                        Convert.ToInt32(dr["num_habitacion"]),
                        dr["tipo_habitacion"].ToString(),
                        dr["capacidad"].ToString(),
                        Convert.ToInt32(dr["precio_noche"]),
                        dr["caracteristicas"].ToString(),
                        dr["ubicacion"].ToString(),
                        Convert.ToBoolean(dr["disponibilidad"])
                    ));
                }
            }

            return lista;
        }
    }
}