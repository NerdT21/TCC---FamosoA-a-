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

        public string Funcionario { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string  Email { get; set; }

        public bool PermissaoAdm { get; set; }

        public bool PermissaoCaixa { get; set; }

        public bool PermissaoFinanceiro { get; set; }

        public bool PermissaoEstoque { get; set; }

        public bool PermissaoCadastros { get; set; }
    }
}
