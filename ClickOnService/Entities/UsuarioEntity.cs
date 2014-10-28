using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class UsuarioEntity
    {
        [DataMember(IsRequired = true)]
        public int Id { get; set; }

        [DataMember]
        public String Login { get; set; }

        [DataMember]
        public String Senha { get; set; }

        [DataMember]
        public PerfilEntity Perfil { get; set; }

        public UsuarioEntity()
        {
            Perfil = new PerfilEntity();
        }
    }
}
