using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FamosoAça.Validacoes
{
    public class ValidarEmail
    {
        public bool VerificarEmail(string email)
        {
            Regex Email = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

            if (Email.IsMatch(email))
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
