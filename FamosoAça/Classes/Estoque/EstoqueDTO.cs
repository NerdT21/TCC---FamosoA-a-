using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Estoque
{
    public class EstoqueDTO
    {
        public int Id { get; set; }

        public int IdCompra { get; set; }

        public int QTDestocada { get; set; }

        public int QTDMinima { get; set; }



        public string NomeProduto { get; set; }
    }
}
