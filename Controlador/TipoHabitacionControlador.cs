using Datos;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class TipoHabitacionControlador
    {
        TipoHabitacionDatos tipohabitacionDatos = new TipoHabitacionDatos();
        public bool GuardarTipoHabitacion(TipoHabitacion tipohabitacion)
        {
            return tipohabitacionDatos.InsertarTipoHabitacion(tipohabitacion);
        }

        public bool ActualizarTipoHabitacion(TipoHabitacion tipohabitacion)
        {
            return tipohabitacionDatos.ActualizarT_Habitacion(tipohabitacion);
        }

        public bool EliminarTipoHabitacion(TipoHabitacion tipohabitacion)
        {
            return tipohabitacionDatos.EliminarT_Habitacion(tipohabitacion);
        }


    }
}
