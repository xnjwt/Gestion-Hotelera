using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class TipoHabitacion
    {
        int id_tipo_habitacion;
        string nombre;
        string capacidad;
        int precio_noche;
        string caracteisticas;

        public TipoHabitacion(int id_tipo_habitacion, string nombre, string capacidad, int precio_noche, string caracteisticas)
        {
            Id_tipo_habitacion = id_tipo_habitacion;
            Nombre = nombre;
            Capacidad = capacidad;
            Precio_noche = precio_noche;
            Caracteisticas = caracteisticas;
        }

        public int Id_tipo_habitacion { get => id_tipo_habitacion; set => id_tipo_habitacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Capacidad { get => capacidad; set => capacidad = value; }
        public int Precio_noche { get => precio_noche; set => precio_noche = value; }
        public string Caracteisticas { get => caracteisticas; set => caracteisticas = value; }
    }
}
