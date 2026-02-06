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
            var dCli = new ClientesDatos();
            var dRes = new ReservasDatos();
            var habDatos = new HabitacionesDatos();
            var tipoHabDatos = new TipoHabitacionesDatos();
            var dPag = new PagosDatos();

            var empModelo = new EmpleadoModelo(empDatos);
            var mCli = new ClienteModelo(dCli);
            var mRes = new ReservaModelo(dRes);
            var habModelo = new HabitacionModelo(habDatos);
            
            var mPag = new PagoModelo(dPag);


            var cEmp = new EmpleadoControlador(empModelo);
            var cCli = new ClienteControlador(mCli);
            var cRes = new ReservaControlador(mRes);
            var cHab = new HabitacionControlador(habModelo);

            var cPag = new PagoControlador(mPag);



            var frm = new Login(cEmp, cCli, cRes, cHab, cPag);

            Application.Run(frm);
        }
    }
}