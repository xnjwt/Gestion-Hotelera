using System;

using Entidades;

namespace Datos
{
    public class PagosDatos
    {
        List<Pago> pagos = new List<Pago>();

        public void Guardar(Pago pago)
        {
            pagos.Add(pago);
        }

        public List<Pago> Listar()
        {
            return pagos;
        }

        public Pago BuscarPorId(int id)
        {
            return pagos.FirstOrDefault(p => p.Id == id);
        }
        public List<Pago> Buscar(string coincidencia)
        {
            return pagos.Where(e => e.ToString().Contains(coincidencia, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void Actualizar(Pago pagoActualizado)
        {
            var indice = pagos.FindIndex(p => p.Id == pagoActualizado.Id);
            if (indice != -1)
            {
                pagos[indice] = pagoActualizado;
            }
            else
            {
                throw new ArgumentException("Pago no encontrado para actualizar.");
            }
        }

    }
}

