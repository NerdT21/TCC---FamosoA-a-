using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FamosoAça.Validacoes
{
    public class ValidarCPF_CNPJ
    {

        public bool VerificaCpfCnpj(String cpf)

        {
            if (Regex.IsMatch(cpf, @"^(((\d{3}).(\d{3}).(\d{3})-(\d{2}))?((\d{2}).(\d{3}).(\d{3})/(\d{4})-(\d{2}))?)*$"))
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
