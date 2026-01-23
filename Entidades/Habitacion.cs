namespace Modelo
{
    public class Habitacion
    {
        int id_habitacion;
        int num_habitacion;
        string tipo_habitacion;
        string capacidad;
        int precio_noche;
        string caracteristicas;
        string ubicacion;
        bool disponibilidad;

        public Habitacion(int id_habitacion, int num_habitacion, string tipo_habitacion, string capacidad, 
                            int precio_noche, string caracteristicas, string ubicacion, bool disponibilidad)
        {
            Id_habitacion = id_habitacion;
            Num_habitacion = num_habitacion;
            Tipo_habitacion = tipo_habitacion;
            Capacidad = capacidad;
            Precio_noche = precio_noche;
            Caracteristicas = caracteristicas;
            Ubicacion = ubicacion;
            Disponibilidad = disponibilidad;
        }

        public int Id_habitacion { get => id_habitacion; set => id_habitacion = value; }
        public int Num_habitacion { get => num_habitacion; set => num_habitacion = value; }
        public string Tipo_habitacion { get => tipo_habitacion; set => tipo_habitacion = value; }
        public string Capacidad { get => capacidad; set => capacidad = value; }
        public int Precio_noche { get => precio_noche; set => precio_noche = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public bool Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
    }


}
