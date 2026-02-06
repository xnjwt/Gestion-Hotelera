using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public class HabitacionModelo
    {
        HabitacionesDatos Dts { get; set; }

        public HabitacionModelo(HabitacionesDatos dts)
        {
            Dts = dts;
        }

        public void Guardar(Habitacion habitacion)
        {
            if (habitacion == null) throw new ArgumentNullException(nameof(habitacion));
            Dts.Guardar(habitacion);
        }

        public void Actualizar(Habitacion habitacion)
        {
            if (habitacion == null) throw new ArgumentNullException(nameof(habitacion));
            Dts.Actualizar(habitacion);
        }

        public void Eliminar(int id)
        {
            Dts.Eliminar(id);
        }

        public List<Habitacion> Listar()
        {
            return Dts.Listar();
        }

        public List<Habitacion> ListarDisponibles()
        {
            return Dts.ListarDisponibles();
        }

        public Habitacion BuscarPorId(int id)
        {
            return Dts.BuscarPorId(id);
        }

        public bool ExisteNumeroHabitacion(int numero, int exceptoId = -1)
        {
            return Dts.ExisteNumero(numero, exceptoId);
        }

        public List<TipoHabitacion> ListarTipos()
        {
            return Dts.ListarTipos();
        }
    }
}