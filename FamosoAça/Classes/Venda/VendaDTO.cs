using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Venda
{
    public class VendaDTO
    {
        public int Id { get; set; }

        public string Data { get; set; }

        public int IdUsuario { get; set; }

        public string FormaPagto { get; set; }
    }
}
