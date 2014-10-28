using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class PedidoEntity
    {
        [DataMember(IsRequired = true)]
        public int Id { get; set; }

        [DataMember(IsRequired = true)]
        public int StatusPedido { get; set; }
        public String DescricaoPedido { get; set; }
        public MesaEntity Mesa { get; set; }
        public PessoaEntity Pessoa { get; set; }
        public List<ItemEntity> lstItem { get; set; }

        public PedidoEntity()
        {
            Mesa = new MesaEntity();
            Pessoa = new PessoaEntity();
            lstItem = new List<ItemEntity>();
        }
    }
}
