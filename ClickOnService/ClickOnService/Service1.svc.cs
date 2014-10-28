using Business;
using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ClickOnService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        
        public bool InsereClienteUsuario(PessoaEntity Cliente)
        {
            return new PessoaBusiness().InsereClienteUsuario(Cliente);
        }

        public PessoaEntity AutenticarUsuario(UsuarioEntity Usuario)
        {
            return new UsuarioBusiness().AutenticarUsuario(Usuario);
        }

        public int InserirMesa(MesaEntity Mesa)
        {
            return new MesaBusiness().InserirMesa(Mesa);
        }

        public bool AtualizarMesa(MesaEntity Mesa)
        {
            return new MesaBusiness().AtualizarMesa(Mesa);
        }

        public bool DeletarMesa(MesaEntity Mesa)
        {
            return new MesaBusiness().DeletarMesa(Mesa);
        }

        public int InserirReserva(ReservaEntity Reserva)
        {
            return new ReservaBusiness().InserirReserva(Reserva);
        }

        public bool AtualizarReserva(ReservaEntity Reserva)
        {
            return new ReservaBusiness().AtualizarReserva(Reserva);
        }

        public bool ExisteUsuario(UsuarioEntity usuario)
        {
            return new UsuarioBusiness().ExisteUsuario(usuario);
        }

        //Métodos de teste de Conexão
        public bool TesteConexao()
        {
            return true;
        }

        public bool TesteConexaoParam(int i)
        {
            return true;
        }
    }
}
