

namespace Entidades
{
    public enum RolEmpleado
    {
        Recepcion,
        Limpieza,
        Administrador
    }
    public enum TurnoEmpleado
    {
        Manana,
        Tarde,
        Noche
    }
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public string Celular { get; set; }
        public RolEmpleado Rol { get; set; }
        public TurnoEmpleado Turno { get; set; }
        public string Estado { get; set; }

        private static int contadorIds = 1;


        public Empleado(string nombres, string email, string contraseña, string celular, RolEmpleado rol, TurnoEmpleado turno, string estado = "activo")
        {
            Id = GenerarId();
            Nombres = nombres;
            Email = email;
            Contrasena = contraseña;
            Celular = celular;
            Rol = rol;
            Turno = turno;
            Estado = estado;
        }

        private int GenerarId()
        {
            return contadorIds++;
        }
        public void Depedir()
        {
            Estado = "despedido";
        }
        public override String ToString()
        {
            return $"ID: {Id}, Nombres: {Nombres}, Email: {Email}, Celular: {Celular}, Rol: {Rol}, Turno: {Turno}, Estado: {Estado}";
        }
    }
}
