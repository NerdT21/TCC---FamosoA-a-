using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Produto.Produto_Venda
{
    public class ProdutoVendaBusiness
    {
        public int Salvar(ProdutoVendaDTO dto)
        {

            ProdutoVendaDataBase db = new ProdutoVendaDataBase();
            return db.Salvar(dto);

        }
        
    }
}
