using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Compra.itemCompra
{
    public class ItemComprasView
    {
        public int Id { get; set; }

        public string FormaPagto { get; set; }

        public string Data { get; set; }

        public int QtdItem { get; set; }

        public decimal Total { get; set; }
    }
}
