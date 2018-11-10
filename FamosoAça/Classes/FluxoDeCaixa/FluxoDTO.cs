using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.FluxoDeCaixa
{
    public class FluxoDTO
    {
        public string DataReferencia { get; set; }

        public decimal Ganhos { get; set; }

        public decimal Despesas { get; set; }

        public decimal Saldo { get; set; }
    }
}
