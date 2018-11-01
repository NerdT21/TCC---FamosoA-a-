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

        public string Nome { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public decimal Salario { get; set; }

        public string Nascimento { get; set; }

        public string Cidade { get; set; }

        public int Estado { get; set; }

        public string CEP { get; set; }

        public string Telefone { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public int DeptoId { get; set; }

        public string Imagem { get; set; }


    }
}
