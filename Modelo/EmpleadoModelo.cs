using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Modelo
{
    public class EmpleadoModelo
    {
        EmpleadosDatos Dts { get; set; }
        public EmpleadoModelo(EmpleadosDatos dts)
        {
            Dts = dts;
            CrearAdmin();
        }

        public void CrearAdmin()
        {
            
            if (Dts.Listar().Count >0) return;

            var empleado = new Empleado(
                nombres: "Admin",
                email: "admin@lajoya.com",
                contraseña: "admin123",
                celular: "0000000000",
                rol: RolEmpleado.Administrador,
                turno: TurnoEmpleado.Manana,
                estado: "activo"
                );

            Dts.Guardar(empleado);
            
                
        }

        public void Guardar(Empleado empleado)
        {
            if (empleado == null) throw new ArgumentNullException(nameof(empleado));
            Val.EsEmail(empleado.Email);
            Val.EsContrasenaValida(empleado.Contrasena);
            Val.EsNumero(empleado.Celular, 10, "Celular");

            Dts.Guardar(empleado);
        }
        public List<Empleado> Listar()
        {
            return Dts.Listar();
        }
        public List<Empleado> ListarActivos()
        {
            return Dts.ListarActivos();
        }

        public Empleado BuscarPorId(int id)
        {
            return Dts.BuscarPorId(id);
        }

        public List<Empleado> Buscar(string coincidencia)
        {
            
            return Dts.Buscar(coincidencia);
        }
        public void Actualizar(Empleado empleadoActualizado)
        {
            if (empleadoActualizado == null) throw new ArgumentNullException(nameof(empleadoActualizado));
            var existente = Dts.BuscarPorId(empleadoActualizado.Id);
            if (existente == null)
                throw new InvalidOperationException("El empleado no existe.");
            Val.EsEmail(empleadoActualizado.Email);
            Val.EsContrasenaValida(empleadoActualizado.Contrasena);
            Val.EsNumero(empleadoActualizado.Celular, 10, "Celular");

            Dts.Actualizar(existente, empleadoActualizado);
        }
        public void Despedir(int idEmpleado)
        {
            Dts.Despedir(idEmpleado);
        }
        public Empleado IniciarSesion(string email, string contrasena)
        {
            return Dts.IniciarSesion(email, contrasena);
        }
    }
}
