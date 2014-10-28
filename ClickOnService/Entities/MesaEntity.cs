using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class MesaEntity
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int QuantidadeLugares { get; set; }

        [DataMember]
        public String DescricaoLocalizacao { get; set; }

        [DataMember]
        public int QrCode { get; set; }

        private String DescricaoLocalizacao1;

        public void setDescricaoLocalizacao(String desc)
        {
            DescricaoLocalizacao1 = desc;
        }

        public String getDescricaoLocalizacao()
        {
            return DescricaoLocalizacao1;
        }

    }
}
