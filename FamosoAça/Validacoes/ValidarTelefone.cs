using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FamosoAça.Validacoes
{
    public class ValidarTelefone
    {
        public bool VerificarTelefone(string telefone)
        {
            Regex tell = new Regex(@"(?<areaCode>[(]?\d{1,3}[)]?\s?)?"
                        + @"(?<numero>\d{3,5}[-]?\d{4})"
                        + @"$");


            if (tell.IsMatch(telefone))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
