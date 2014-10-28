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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        bool InsereClienteUsuario(PessoaEntity Cliente);

        [OperationContract]
        PessoaEntity AutenticarUsuario(UsuarioEntity Usuario);

        [OperationContract]
        int InserirMesa(MesaEntity Mesa);

        [OperationContract]
        bool AtualizarMesa(MesaEntity Mesa);

        [OperationContract]
        bool DeletarMesa(MesaEntity Mesa);

        [OperationContract]
        int InserirReserva(ReservaEntity Reserva);

        [OperationContract]
        bool AtualizarReserva(ReservaEntity Reserva);

        [OperationContract]
        bool ExisteUsuario(UsuarioEntity usuario);

        [OperationContract]
        bool TesteConexao();

        [OperationContract]
        bool TesteConexaoParam(int i);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
