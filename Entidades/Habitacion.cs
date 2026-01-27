namespace Modelo
{
    public class Habitacion
    {
        int id_habitacion;
        int id_tipo_habitacion;
        int numero_habitacion;
        string ubicacion;

        public Habitacion(int id_habitacion, int id_tipo_habitacion, int numero_habitacion, string ubicacion)
        {
            Id_habitacion = id_habitacion;
            Id_tipo_habitacion = id_tipo_habitacion;
            Numero_habitacion = numero_habitacion;
            Ubicacion = ubicacion;
        }

        public int Id_habitacion { get => id_habitacion; set => id_habitacion = value; }
        public int Id_tipo_habitacion { get => id_tipo_habitacion; set => id_tipo_habitacion = value; }
        public int Numero_habitacion { get => numero_habitacion; set => numero_habitacion = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
    }


}
