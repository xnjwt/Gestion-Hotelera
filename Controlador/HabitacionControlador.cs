using Datos;
using Entidades;
using Modelo;
using System.Collections.Generic;

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

        public bool ActualizarHabitacion(Habitacion habitacion)
        {
            return habitacionDatos.ActualizarHabitacion(habitacion);
        }

        public bool EliminarHabitacion(Habitacion habitacion)
        {
            return habitacionDatos.EliminarHabitacion(habitacion);
        }

    }
}
