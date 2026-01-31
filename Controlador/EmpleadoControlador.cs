using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controlador
{
    public class EmpleadoControlador
    {
        EmpleadoModelo mdl { get; set; }
        public EmpleadoControlador(EmpleadoModelo modelo)
        {
            mdl = modelo;
        }
        public Boolean validarEmpleado(string nombres, string email, string contrasena, string celular, RolEmpleado rol, TurnoEmpleado turno, string estado = "activo", int idEmpleado = -1)
        {
            var mNombres = Regex.Match(nombres, @".{3,}");
            var mEmail = Regex.Match(email, @".+@.+\..+");
            var mContrasena = Regex.Match(contrasena, @".{8,}");
            var mCelular = Regex.Match(celular, @"\d{10}");
            var mEstado = Regex.Match(estado, @".{3,}");

            string nombresCorrecto,
                emailCorrecto,
                contrasenaCorrecto,
                celularCorrecto,
                rolCorrecto,
                turnoCorrecto,
                estadoCorrecto;

            try
            {
                if (!mNombres.Success)
                    throw new ArgumentException("El nombre debe tener al menos 3 caracteres.");
                else nombresCorrecto = mNombres.Value.ToString();

                if (!mEmail.Success)
                    throw new ArgumentException("Ingrese un email válido");
                else emailCorrecto = mEmail.Value.ToString();

                if (!mContrasena.Success)
                    throw new ArgumentException("La contraseña debe tener al menos 8 caracteres.");
                else contrasenaCorrecto = mContrasena.Value.ToString();

                if (!mCelular.Success)
                    throw new ArgumentException("Ingrese un número válido. Debe contener 10 dígitos.");
                else celularCorrecto = mCelular.Value.ToString();

                if (!mEstado.Success)
                    throw new ArgumentException("Ingrese un estado válido. Debe contener al menos 3 dígitos.");
                else estadoCorrecto = mEstado.Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el empleado: " + ex.Message);
                return true;
            }

            var empleado = new Empleado(
                nombresCorrecto,
                emailCorrecto.ToLower(),
                contrasenaCorrecto,
                celularCorrecto,
                rol,
                turno,
                estado
            );

            try
            {
                if (idEmpleado == -1)
                {
                    mdl.Guardar(empleado);
                    return false;
                }
                else
                {
                    empleado.Id = idEmpleado;
                    mdl.Actualizar(empleado);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return true;
            }
            

        }
        public Empleado IniciarSesion(string email, string contrasena)
        {
            var empleado = mdl.IniciarSesion(email, contrasena);

            return empleado;
        }

        public List<Entidades.Empleado> ListarEmpleados()
        {
            return mdl.Listar();
        }
        
        public List<Entidades.Empleado> ListarEmpleadosActivos()
        {
            return mdl.ListarActivos();
        }

        public void DespedirEmpleado(int idEmpleado)
        {
            mdl.Despedir(idEmpleado);
        }
    }
}
