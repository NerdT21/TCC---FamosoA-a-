using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.SalarioFamilia
{
    public class SalarioFamiliaDTO
    {
        public int ID { get; set; }

        public decimal SalarioBruto { get; set; }

        public decimal SalarioFamilia { get; set; }

        public int Dependentes { get; set; }
    }
}
