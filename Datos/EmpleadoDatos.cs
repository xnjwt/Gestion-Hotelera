using System;

using Entidades;

namespace Datos
{
    public class EmpleadosDatos
    {
        private readonly List<Empleado> empleados = new();

        public Boolean ExisteClienteConEmail(string email, int exceptoID = -1)
        {
            return empleados.Any(e => e.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && e.Id != exceptoID);
        }

        public Boolean ExisteClienteConCelular(string celular, int exceptoID = -1)
        {
            return empleados.Any(e => e.Celular.Equals(celular, StringComparison.OrdinalIgnoreCase) && e.Id != exceptoID);
        }
        public void Guardar(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public List<Empleado> Listar()
        {
            return empleados;
        }
        public List<Empleado> ListarActivos()
        {
            return empleados.Where(c => c.Estado.Equals("activo")).ToList();
        }

        public Empleado BuscarPorId(int id)
        {
            return empleados.FirstOrDefault(e => e.Id == id);
        }
        public List<Empleado> Buscar(string coincidencia)
        {
            return empleados.Where(e => e.ToString().Contains(coincidencia, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public void Actualizar(Empleado existente, Empleado empleadoActualizado)
        {
            if (existente == null) throw new ArgumentNullException(nameof(existente));
            
            if (empleadoActualizado == null) throw new ArgumentNullException(nameof(empleadoActualizado));
            
            existente.Nombres = empleadoActualizado.Nombres;
            existente.Email = empleadoActualizado.Email;
            existente.Celular = empleadoActualizado.Celular;
            existente.Rol = empleadoActualizado.Rol;
            existente.Turno = empleadoActualizado.Turno;
            existente.Estado = empleadoActualizado.Estado;
        }
        public void Despedir(int idEmpleado)
        {
            var emp = BuscarPorId(idEmpleado);
            emp.Depedir();
        }
    }
}
