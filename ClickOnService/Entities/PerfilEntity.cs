using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class PerfilEntity
    {
        [DataMember(IsRequired = true)]
        public int Id { get; set; }

        [DataMember]
        public String Descricao { get; set; }

        public PerfilEntity()
        {

        }
    }
}
