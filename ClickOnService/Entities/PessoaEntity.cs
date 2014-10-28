using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class PessoaEntity
    {
        [DataMember(IsRequired=true)]
        public int Id { get; set; }

        [DataMember]
        public String EnderecoEmail { get; set; }

        [DataMember]
        public String NumeroTelefone { get; set; }

        [DataMember]
        public String Nome { get; set; }

        [DataMember]
        public String NumeroCpf { get; set; }

        [DataMember]
        public String NumeroRg { get; set; }

        [DataMember]
        public UsuarioEntity Usuario { get; set; }

        public PessoaEntity()
        {
            Usuario = new UsuarioEntity();
        }
    }
}
