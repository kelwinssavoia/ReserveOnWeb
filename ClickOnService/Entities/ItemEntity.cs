using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ItemEntity
    {
        public int Id { get; set; }
        public String DescricaoItem { get; set; }
        public double ValorItem { get; set; }
        public String UrlImg { get; set; }
        public TipoItemEntity TipoItem { get; set; }

        public ItemEntity()
        {
            TipoItem = new TipoItemEntity();
        }
    }
}
