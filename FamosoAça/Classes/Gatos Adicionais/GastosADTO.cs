using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Gatos_Adicionais
{
    public class GastosADTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public string Descricao { get; set; }

        public string Data { get; set; }
    }
}