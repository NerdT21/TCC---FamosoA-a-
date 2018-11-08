using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Produto.Produto_Venda
{
     public class ProdutoVendaView
    {
        public int ID { get; set; }

        public string FormaPagamento{ get; set; }

        public string Data { get; set; }

        public int QTDItme { get; set; }

        public decimal Total { get; set; }

    }
}
