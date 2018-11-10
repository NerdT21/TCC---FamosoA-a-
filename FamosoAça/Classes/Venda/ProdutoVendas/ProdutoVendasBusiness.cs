using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Venda.ProdutoVendas
{
    public class ProdutoVendasBusiness
    {
        public int Salvar(ProdutoVendasDTO dto)
        {
            ProdutoVendasDatabase db = new ProdutoVendasDatabase();
            return db.Salvar(dto);
        }
    }
}
