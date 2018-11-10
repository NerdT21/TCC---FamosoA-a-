using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Estoque
{
     public class EstoqueView
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public string Produto { get; set; }

        public int QtdEstocado { get; set; }    
    }
}
