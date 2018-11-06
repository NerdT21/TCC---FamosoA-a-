using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Login
{
    public class LoginDTO
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public  string  Email { get; set; }

        public bool Adm { get; set; }

        public bool Cadastro { get; set; }

        public bool Consulta { get; set; }

        public bool Contabilidade { get; set; }

    }
}
