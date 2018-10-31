using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Fornecedor
{
    public class FornecedorDTO
    {
        public int Id { get; set; }

        public string CNPJ { get; set; }

        public string Nome { get; set; }      

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public int IDEstado { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Logo { get; set; }
    }
}
