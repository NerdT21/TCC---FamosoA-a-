using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.ImpostoRenda
{
    public class ImpostoRendaBusiness
    {
        public ImpostoRendaDTO Consultar(decimal baseCalculo)
        {
            ImpostoRendaDatabase db = new ImpostoRendaDatabase();
            return db.Consultar(baseCalculo);
        }
    }
}
