using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class ReservaEntity
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime DataReservaInicio { get; set; }

        [DataMember]
        public DateTime DataReservaFim { get; set; }

        [DataMember]
        public String CodigoReserva { get; set; }

        [DataMember]
        public String CodigoCheckin { get; set; }

        [DataMember]
        public bool FlagCheckin { get; set; }

        [DataMember]
        public MesaEntity Mesa { get; set; }

        [DataMember]
        public bool FlagAtiva { get; set; }

        public ReservaEntity()
        {
            Mesa = new MesaEntity();
        }
    }
}
