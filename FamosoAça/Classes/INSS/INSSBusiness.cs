using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.INSS
{
    public class INSSBusiness
    {
        public INSSDTO Consultar(decimal salario)
        {
            INSSDataBase db = new INSSDataBase();
            return db.Consultar(salario);
        }
    }
}
