using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ReservaBusiness
    {
        public int InserirReserva(ReservaEntity Reserva)
        {
            int Retorno = 0;

            try
            {
                Retorno = new ReservaData().InserirReserva(Reserva);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Retorno;
        }

        public bool AtualizarReserva(ReservaEntity Reserva)
        {
            bool Retorno = false;

            try
            {
                Retorno = new ReservaData().AtualizarReserva(Reserva);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Retorno;
        }
    }
}
