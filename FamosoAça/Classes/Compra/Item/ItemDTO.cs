using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Compra.Item
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int FornecedorId { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
    }
}
