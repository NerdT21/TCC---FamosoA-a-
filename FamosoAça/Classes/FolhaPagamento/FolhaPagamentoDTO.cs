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

        public int IdFuncinario { get; set; }

        public int IdINSS { get; set; }

        public int IdImpostoRenda { get; set; }

        public int IdSalarioFamilia { get; set; }

        public int Faltas { get; set; }

        public string Atraso { get; set; }

        public decimal ImpostoRenda { get; set; }

        public  decimal FGTS { get; set; }

        public decimal ValeTransporte { get; set; }

        public decimal SalarioLiq { get; set; }

        public string HoraExtra { get; set; }
    }
}
