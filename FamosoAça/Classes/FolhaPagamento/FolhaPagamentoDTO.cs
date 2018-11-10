using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.FolhaPagamento
{
    public class FolhaPagamentoDTO
    {
        public int Id { get; set; }

        public int IdFuncio { get; set; }

        public string HorasExtras { get; set; }

        public int Faltas { get; set; }

        public decimal SalBruto { get; set; }

        public decimal ImpostoRenda { get; set; }

        public decimal Fgts { get; set; }

        public decimal VLTars { get; set; }

        public decimal SalLiq { get; set; }

        public decimal Inss { get; set; }

        public decimal SalFamilia { get; set; }

        public string Data { get; set; }

    }
}
