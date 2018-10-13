using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Produto
{
    public class ProdutoDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Marca { get; set; }

        public decimal Preco{ get; set; }

        public string Descricao { get; set; }
    }
}
