namespace Entidades
{
    public class Habitacion
    {

        public int Id { get; set; }
        public int Id_tipohabitacion { get; set; }
        public int Numhabitación { get; set; }
        public string Ubicación { get; set; }
        public string Descripcíon { get; set; }
        public bool Disponibilidad { get; set; }
        

        private static int contadorIds = 1;

        public Habitacion(int id_tipohabitacion, int numhabitación, string ubicación, string descripcion="", bool disponibilidad=true, int id = -1)
        {
            Id = id;
            Id_tipohabitacion = id_tipohabitacion;
            Numhabitación = numhabitación;
            Ubicación = ubicación;
            Descripcíon = descripcion;
            Disponibilidad = disponibilidad;
        }
        private int GenerarId()
        {
            return contadorIds++;
        }

        public override String ToString()
        {
            return $"Numero Habitacion: {Numhabitación}, Ubicación: {Ubicación}, Disponibilidad: {Disponibilidad}";
        }
    }


    public class TipoHabitacion
    {
        public int Id_tipohabitacion { get; set; }
        public string Nombre { get; set; }
        public string Caracteristicas { get; set; }
        public int Capacidad { get; set; }
        public float Precio_noche { get; set; }

        private static int contadorIds = 1;

        public TipoHabitacion( string nombre, string caracteristicas, int capacidad, float precio_noche, int id = -1)
        {
            Id_tipohabitacion = id;
            Nombre = nombre;
            Caracteristicas = caracteristicas;
            Capacidad = capacidad;
            Precio_noche = precio_noche;
        }

        private int GenerarId()
        {
            return contadorIds++;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Caracteristicas: {Caracteristicas}, Capacidad: {Capacidad}, Precio por noche: {Precio_noche}";
        }
    }
}
