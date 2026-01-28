using System;

namespace Entidades
{
    public class Pago
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public decimal MontoTotal { get; set; }     
        public string Metodo { get; set; }         
        public DateTime FechaPago { get; set; }

        private static int contadorIds = 1;


        public Pago( int reservaId, decimal montoTotal, string metodo, int id = -1)
        {
            Id = id;
            ReservaId = reservaId;
            MontoTotal = montoTotal;
            Metodo = metodo;
            FechaPago = DateTime.UtcNow;
        }

        private int GenerarId()
        {
            return contadorIds++;
        }

    }
}
