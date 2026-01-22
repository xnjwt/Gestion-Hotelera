using Entidades;

namespace Datos
{
    public class HabitacionesDatos
    {
        List<Habitacion> habitaciones = new List<Habitacion>();

        public void Guardar(Habitacion habitacion)
        {
            habitaciones.Add(habitacion);
        }

        public List<Habitacion> Listar()
        {
            return habitaciones;
        }

        public List<Habitacion> ListarDisponibles()
        {
            return habitaciones.Where(h => h.Disponibilidad).ToList();
        }

        public Habitacion ObtenerPorId(int id)
        {
            return habitaciones.FirstOrDefault(h => h.Id == id);
        }

        public void Actualizar (Habitacion habitacionActualizada)
        {
            var existente = ObtenerPorId(habitacionActualizada.Id);
            if (existente != null)
            {
                existente.Numhabitación = habitacionActualizada.Numhabitación;
                existente.Id_tipohabitacion = habitacionActualizada.Id_tipohabitacion;
                existente.Ubicación = habitacionActualizada.Ubicación;
                existente.Disponibilidad = habitacionActualizada.Disponibilidad;
                existente.Descripcíon = habitacionActualizada.Descripcíon;
            }
        }
        public void Eliminar(int idHabitacion)
        {
            var habitacion = ObtenerPorId(idHabitacion);
            if (habitacion != null)
            {
                habitaciones.Remove(habitacion);
            }
        }
    }

    public class TipoHabitacionesDatos
    {
        List<TipoHabitacion> tipohabitaciones = new List<TipoHabitacion>();

        public void Guardar(TipoHabitacion tipohabitacion)
        {
            tipohabitaciones.Add(tipohabitacion);
        }

        public List<TipoHabitacion> Listar()
        {
            return tipohabitaciones;
        }
        public List<String> ListarNombresTipoHabitacion()
        {
            return tipohabitaciones.Select(t => t.Nombre).ToList();

        }
        public List<TipoHabitacion> Buscar(string coincidencia)
        {
            return tipohabitaciones.Where(e => e.ToString().Contains(coincidencia, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public TipoHabitacion ObtenerPorId(int id)
        {
            return tipohabitaciones.FirstOrDefault(t => t.Id_tipohabitacion == id);
        }

        public void Actualizar(TipoHabitacion tipohabitacionActualizada)
        {
            var existente = ObtenerPorId(tipohabitacionActualizada.Id_tipohabitacion);
            if (existente != null)
            {
                existente.Nombre = tipohabitacionActualizada.Nombre;
                existente.Caracteristicas = tipohabitacionActualizada.Caracteristicas;
                existente.Capacidad = tipohabitacionActualizada.Capacidad;
                existente.Precio_noche = tipohabitacionActualizada.Precio_noche;

            }
        }

        public void Eliminar(int idTipoHabitacion)
        {
            var tipohabitacion = ObtenerPorId(idTipoHabitacion);
            if (tipohabitacion != null)
            {
                tipohabitaciones.Remove(tipohabitacion);
            }
        }

    }
}
