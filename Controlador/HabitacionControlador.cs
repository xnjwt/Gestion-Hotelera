using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Controlador
{
    public class HabitacionControlador
    {
        HabitacionModelo mdl { get; set; }

        public HabitacionControlador(HabitacionModelo modelo)
        {
            mdl = modelo;
        }

        public Boolean validarHabitacion(int idTipoHabitacion, string numHabitacion, string ubicacion, string descripcion = "", bool disponibilidad = true, int idHabitacion = -1)
        {
            var mNumHabitacion = Regex.Match(numHabitacion, @"\d+");
            var mUbicacion = Regex.Match(ubicacion, @".{5,}");


            int numHabitacionCorrecto;
            string ubicacionCorrecto;

            try
            {

                if (!mNumHabitacion.Success)
                    throw new ArgumentException("El número de habitación debe ser un número entero positivo");
                else numHabitacionCorrecto = int.Parse(mNumHabitacion.Value);

                if (!mUbicacion.Success)
                    throw new ArgumentException("La ubicacion debe tener al menos 5 caracteres");
                else ubicacionCorrecto = mUbicacion.Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar la habitación: " + ex.Message);
                return true;
            }

            var Habitacion = new Habitacion(
                idTipoHabitacion,
                numHabitacionCorrecto,
                ubicacionCorrecto,
                descripcion,
                disponibilidad
            );


            try
            {
                if (idHabitacion == -1)
                {
                    mdl.Guardar(Habitacion);
                    return false;
                }
                else
                {
                    Habitacion.Id = idHabitacion;
                    mdl.Actualizar(Habitacion);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return true;
            }


        }

        // Métodos para Tipo de Habitación (necesarios para llenar los ComboBox)
        public bool validarTipoHabitacion(string nombre, string caracteristicas, int capacidad, float precio, int id = -1)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                    throw new ArgumentException("El nombre del tipo es obligatorio.");

                if (capacidad <= 0)
                    throw new ArgumentException("La capacidad debe ser mayor a 0.");

                if (precio <= 0)
                    throw new ArgumentException("El precio debe ser mayor a 0.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            var tipo = new TipoHabitacion(nombre, caracteristicas, capacidad, precio, id);

            try
            {
                // Lógica de guardar/actualizar tipo en modelo (si fuera necesario extender)
                // mdl.GuardarTipo(tipo); 
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }

        public List<Habitacion> ListarHabitaciones()
        {
            return mdl.Listar();
        }

        public List<Habitacion> ListarHabitacionesDisponibles()
        {
            return mdl.ListarDisponibles();
        }

        public List<TipoHabitacion> ListarTiposHabitacion()
        {
            return mdl.ListarTipos();
        }

        public Habitacion BuscarPorId(int id)
        {
            return mdl.BuscarPorId(id);
        }

        public void EliminarHabitacion(int id)
        {
            try
            {
                mdl.Eliminar(id);
                MessageBox.Show("Habitación eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public class TipoHabitacionControlador
    {
        TipoHabitacionModelo mdl { get; set; }
        public TipoHabitacionControlador(TipoHabitacionModelo modelo)
        {
            mdl = modelo;
        }
        public List<Entidades.TipoHabitacion> ListarTiposHabitacion()
        {
            return mdl.Listar();
        }
        public List<String> ListarNombresTiposHabitacion()
        {
            return mdl.ListarNombresTipoHabitacion();
        }

        public Boolean validarTipoHabitacion(string nombre, string caracteristicas, string capacidad, string precioNoche, int idTipoHabitacion = -1)
        {
            var mNombre = Regex.Match(nombre, @".{3,}");
            var mCaracteristicas = Regex.Match(caracteristicas, @".{5,}");
            var mCapacidad = Regex.Match(capacidad, @"\d+");
            var mPrecioNoche = Regex.Match(precioNoche, @"\d*[\.,]?\d*");


            string nombreCorrecto,
                caracteristicasCorrecto;
            int capacidadCorrecto;
            float precioNocheCorrecto;
            try
            {
                if (!mNombre.Success)
                    throw new ArgumentException("El nombre debe tener al menos 3 caracteres");
                else
                    nombreCorrecto = mNombre.Value;
                if (!mCaracteristicas.Success)
                    throw new ArgumentException("Las características deben tener al menos 5 caracteres");
                else caracteristicasCorrecto = mCaracteristicas.Value;

                if (!mCapacidad.Success)
                    throw new ArgumentException("La capacidad debe ser un número entero positivo");
                else capacidadCorrecto = int.Parse(mCapacidad.Value);

                if (!mPrecioNoche.Success)
                    throw new ArgumentException("El precio de la noche debe ser entero o decimal");
                else
                {
                    var precioNocheNormalizado = mPrecioNoche.Value.ToString().Replace(",", ".");
                    precioNocheCorrecto = float.Parse(precioNocheNormalizado, CultureInfo.InvariantCulture);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el el tipo de habitación: " + ex.Message);
                return true;
            }

            var tipoHabitacion = new TipoHabitacion(
                nombreCorrecto,
                caracteristicasCorrecto,
                capacidadCorrecto,
                precioNocheCorrecto
            );

            try
            {
                if (idTipoHabitacion == -1)
                {
                    mdl.Guardar(tipoHabitacion);
                    return false;
                }
                else
                {
                    tipoHabitacion.Id_tipohabitacion = idTipoHabitacion;
                    mdl.Actualizar(tipoHabitacion);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return true;
            }



        }

        public void EliminarTipoHabitacion(int idTipoHabitacion)
        {
            mdl.Eliminar(idTipoHabitacion);
        }
    }
}