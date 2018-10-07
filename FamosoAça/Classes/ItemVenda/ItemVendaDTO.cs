using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.ItemVenda
{
    public class ItemVendaDTO
    {
        public int Id { get; set; }

        public int IdVenda { get; set; }

        public string Produto { get; set; }

        public string Quantidade { get; set; }

        public string Total { get; set; }
    }
}
