using Modelo;
using System.Collections.Generic;
using Datos;

namespace Controlador
{
    public class HabitacionControlador
    {
        HabitacionDatos habitacionDatos = new HabitacionDatos();
        public bool GuardarHabitacion(Habitacion habitacion)
        {
            //Logica - reglas del negocio - controlador
            return habitacionDatos.InsertarHabitacion(habitacion);
        }

    }
}
