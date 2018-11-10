using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Compra.itemCompra
{
    public class ItemCompraBusiness
    {
        public int Salvar(ItemCompraDTO dto)
        {
            ItemCompraDatabase db = new ItemCompraDatabase();
            return db.Salvar(dto);
        }
    }
}
