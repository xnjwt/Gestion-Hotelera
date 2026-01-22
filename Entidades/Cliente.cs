

namespace Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public bool Estado { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


        private static int contadorIds = 1;
        public Cliente()
        {
            Id = GenerarId();
            Nombre = string.Empty;
            Apellido = string.Empty;
            Email = string.Empty;
            Celular = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = null;
            Estado = true;
            CreatedAt = DateTime.Now;
            UpdatedAt = null;
        }

        public Cliente(
            string nombre,
            string apellido,
            string email,
            string celular,
            string Cedula,
            string direccion,
            DateTime? fechaNacimiento = null,
            bool estado = true)
        {
            this.Id = GenerarId();
            this.Nombre = nombre ?? string.Empty;
            this.Apellido = apellido ?? string.Empty;
            this.Email = email ?? string.Empty;
            this.Celular = celular ?? string.Empty;
            this.Cedula = Cedula ?? string.Empty;
            this.Direccion = direccion ?? string.Empty;
            this.FechaNacimiento = fechaNacimiento;
            this.Estado = estado;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = null;
        }
        private int GenerarId()
        {
            return contadorIds++;
        }


        public void Desactivar()
        {
            Estado = false;
            UpdatedAt = DateTime.Now;
        }

        public void Activar()
        {
            Estado = true;
            UpdatedAt = DateTime.Now;
        }


        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre} {Apellido}, Email: {Email}, Celular: {Celular}, Cédula: {Cedula}, Dirección: {Direccion}, Estado: {(Estado ? "Activo" : "Inactivo")}";
        }
    }

}