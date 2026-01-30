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
            //Logica - reglas del negocio - controlador
            return tipohabitacionDatos.InsertarTipoHabitacion(tipohabitacion);
        }
    }
}
