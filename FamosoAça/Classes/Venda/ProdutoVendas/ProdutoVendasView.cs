using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Venda.ProdutoVendas
{
    public class ProdutoVendasView
    {
        public int Id { get; set; }

        public string FormaPagto { get; set; }

        public string Data { get; set; }

        public int QtdItem { get; set; }

        public decimal Total { get; set; }
    }
}
