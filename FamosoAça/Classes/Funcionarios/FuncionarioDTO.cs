using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Funcionarios
{
    public class FuncionarioDTO
    {

        public int Id { get; set; }

        public decimal Salario { get; set; }

        public int IdDepto { get; set; }

        public int IdEstado { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string Cep { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cidade { get; set; }

        public string Telefone { get; set; }

        public string Imagem { get; set; }

        public string Nascimento { get; set; }
    }
}
