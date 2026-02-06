using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
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

        public bool validarHabitacion(int idTipo, int numero, string ubicacion, string descripcion, bool disponibilidad, int idHabitacion = -1)
        {
            try
            {
                if (idTipo <= 0)
                    throw new ArgumentException("Debe seleccionar un tipo de habitación válido.");

                if (numero <= 0)
                    throw new ArgumentException("El número de habitación debe ser mayor a 0.");

                if (string.IsNullOrWhiteSpace(ubicacion))
                    throw new ArgumentException("La ubicación es obligatoria.");

                // Validar que el número no se repita (regla de negocio)
                if (mdl.ExisteNumeroHabitacion(numero, idHabitacion))
                    throw new ArgumentException("Ya existe una habitación con ese número.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            var habitacion = new Habitacion(
                idTipo,
                numero,
                ubicacion,
                descripcion,
                disponibilidad,
                idHabitacion
            );

            try
            {
                if (idHabitacion == -1)
                {
                    mdl.Guardar(habitacion);
                }
                else
                {
                    mdl.Actualizar(habitacion);
                }
                return false;
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
}