using Microsoft.Data.SqlClient;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class TipoHabitacionDatos
    {
        string cadenaConexionBD = "data source=(localdb)\\MSSQLLocalDB; initial catalog=Habitaciones; " +
                                  "integrated security=true; TrustServerCertificate=true";
        public List<TipoHabitacion> ListarT_Habitacion()
        {
            List<TipoHabitacion> tipohabitacion = new List<TipoHabitacion>();

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexionBD))
            {
                try
                {
                    sqlConnection.Open();
                    string query = "ConsultarTipoHabitacion";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        TipoHabitacion tipohabitacion1 = new TipoHabitacion(
                            Convert.ToInt32(sqlDataReader["Tipo_Habitacion_id"]),
                            sqlDataReader["Nombre"].ToString(),
                            sqlDataReader["Capacidad"].ToString(),
                            Convert.ToInt32(sqlDataReader["Precio_Noche"]),
                            sqlDataReader["Caracteristicas"].ToString()
                        );

                        tipohabitacion.Add(tipohabitacion1);
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            return tipohabitacion;
        }
    }
}
