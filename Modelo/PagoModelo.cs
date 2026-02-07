using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public class PagoModelo
    {
        PagosDatos Dts { get; set; }

        public PagoModelo(PagosDatos dts)
        {
            Dts = dts;
        }

        public void Guardar(Pago pago)
        {
            if (pago == null) throw new ArgumentNullException(nameof(pago));

            // El monto no puede ser negativo ni cero
            if (pago.MontoTotal <= 0)
                throw new ArgumentException("El monto del pago debe ser mayor a 0.");
            //El pago no puede tener una fecha futura
            if (pago.FechaPago > DateTime.Now)
                throw new ArgumentException("La fecha del pago no puede ser futura.");

            Dts.Guardar(pago);
        }

        public void Actualizar(Pago pago)
        {
            if (pago == null) throw new ArgumentNullException(nameof(pago));
            Dts.Actualizar(pago);
        }

        public List<Pago> Listar()
        {
            return Dts.Listar();
        }

        public Pago BuscarPorId(int id)
        {
            return Dts.BuscarPorId(id);
        }
        public void Eliminar(int id)
        {
            Dts.Eliminar(id);
        }

        public List<Pago> Buscar(string coincidencia)
        {
            return Dts.Buscar(coincidencia);
        }
    }
}