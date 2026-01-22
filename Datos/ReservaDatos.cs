
using Entidades;

namespace Datos
{
    public class ReservasDatos
    {
        List<Reserva> reservas = new List<Reserva>();

        public void Guardar(Reserva reserva)
        {
            reservas.Add(reserva);
        }

        public List<Reserva> Listar()
        {
            return reservas;
        }
        public List<Reserva> ListarActivas()
        {
            return reservas.Where(r => r.Estado.Equals("activa")).ToList();
        }

        public Reserva BuscarPorId(int id)
        {
            return reservas.FirstOrDefault(r => r.Id == id);
        }

        public List<Reserva> Buscar(string coincidencia)
        {
            return reservas.Where(e => e.ToString().Contains(coincidencia, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Reserva> BuscarPorCliente(int clienteId)
        {
            return reservas.Where(r => r.ClienteId == clienteId).ToList();
        }

        public void AsignarPago(Reserva reserva, int idPago)
        {
            var existente = BuscarPorId(reserva.Id);
            if (existente == null)
                throw new InvalidOperationException("La reserva no existe.");
            existente.IdPago = idPago;
        }
    }
}

