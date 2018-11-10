using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.SalarioFamilia
{
    public class SalarioFamilhaBusiness
    {
        public SalarioFamilhaDTO Consultar(decimal salario)
        {
            SalarioFamilhaDataBase DB = new SalarioFamilhaDataBase();
            return DB.Consultar(salario);
        }
    }
}
