// 1. CAMBIO AQUÍ: Usamos el nuevo namespace
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Gestion_Hotelera
{
    public static class ConexionDB
    {
        public static SqlConnection GetConnection()
        {
            string servidor = ConfigurationManager.AppSettings["Server"];
            string baseDatos = ConfigurationManager.AppSettings["Database"];
            string usuario = ConfigurationManager.AppSettings["User"];
            string password = ConfigurationManager.AppSettings["Password"];

            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = servidor;
            builder.InitialCatalog = baseDatos;
            builder.UserID = usuario;
            builder.Password = password;
            builder.TrustServerCertificate = true;

            return new SqlConnection(builder.ConnectionString);
        }
    }
}