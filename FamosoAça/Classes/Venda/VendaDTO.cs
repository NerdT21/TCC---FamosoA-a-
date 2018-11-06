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

        public int IdUsuario { get; set; }

        public string DataVenda { get; set; }

        public string FormaDePagamento { get; set; }

    }
}
