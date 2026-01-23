using Modelo;
using System.Collections.Generic;
using Datos;

namespace Controlador
{
    public class HabitacionControlador
    {
        private HabitacionDatos datos = new HabitacionDatos();

        public List<Habitacion> ObtenerHabitaciones()
        {
            return datos.Listar();
        }

        public Habitacion BuscarHabitacion(int id)
        {
            return datos.BuscarPorId(id);
        }

        public List<string> ObtenerTiposHabitacion()
        {
            return datos.ObtenerTiposHabitacion();
        }

        public List<Habitacion> ObtenerHabitacionesPorTipo(string tipo)
        {
            return datos.ObtenerHabitacionesPorTipo(tipo);
        }
    }
}
