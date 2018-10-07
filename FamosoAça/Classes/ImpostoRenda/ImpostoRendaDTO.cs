using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.ImpostoRenda
{
    public class ImpostoRendaDTO
    {
        public int Id { get; set; }

        public int IdFolhaPag { get; set; }

        public decimal Aliquota { get; set; }

        public decimal Deducao { get; set; }


    }
}
