using Entidades;
using Datos;
using Modelo;
using Vista;
using Controlador;
namespace Gestion_Hotelera
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var empDatos = new EmpleadosDatos();
            var habDatos = new HabitacionDatos();


            var empModelo = new EmpleadoModelo(empDatos);


            var empController = new EmpleadoControlador(empModelo);


            var frm = new Login(empController);

            Application.Run(frm);
        }
    }
}