using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Compra
{
    public class CompraDTO
    {
        public int Id { get; set; }
        
        public int IdItem { get; set; }

        public int QuantidadeComprada { get; set; }

        public string DataCompra { get; set; }
        
        public decimal Preco { get; set; }
    }
}
