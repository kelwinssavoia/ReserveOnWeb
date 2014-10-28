using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MesaBusiness
    {
        public int InserirMesa(MesaEntity Mesa)
        {
            int Retorno = 0;

            try
            {
                Retorno = new MesaData().InserirMesa(Mesa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Retorno;
        }

        public bool AtualizarMesa(MesaEntity Mesa)
        {
            bool Retorno = false;

            try
            {
                Retorno = new MesaData().AtualizarMesa(Mesa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Retorno;
        }

        public bool DeletarMesa(MesaEntity Mesa)
        {
            bool Retorno = false;

            try
            {
                Retorno = new MesaData().DeletarMesa(Mesa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Retorno;
        }
    }
}
