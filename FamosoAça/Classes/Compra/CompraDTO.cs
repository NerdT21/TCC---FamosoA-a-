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

        public int UsuarioId { get; set; }

        public string Data { get; set; }

        public string FormaPagto { get; set; }
    }
}
