using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Entidades;
using Modelo;

namespace Datos
{
    public class HabitacionDatos
    {
        string cadenaConexionBD = "data source=(localdb)\\MSSQLLocalDB; initial catalog=Habitaciones; " +
                                  "integrated security=true; TrustServerCertificate=true";
        public List<Habitacion> ListarHabitacion()
        {
            List<Habitacion> habitacion = new List<Habitacion>();

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexionBD))
            {
                try
                {
                    sqlConnection.Open();
                    string query = "ConsultarHabitacion";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Habitacion habitacion1 = new Habitacion(
                            Convert.ToInt32(sqlDataReader["Id"]),
                            Convert.ToInt32(sqlDataReader["Habitacion_id"]),
                            Convert.ToInt32(sqlDataReader["Numero_Habitacion"]),
                            sqlDataReader["Ubicacion"].ToString()
                        );

                        habitacion.Add(habitacion1);
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            return habitacion;
        }
    }
}