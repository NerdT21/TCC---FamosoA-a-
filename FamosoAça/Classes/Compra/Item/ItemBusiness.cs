using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Compra.Item
{
    public class ItemBusiness
    {
        public int Salvar(ItemDTO dto)
        {
            ItemDatabase db = new ItemDatabase();
            return db.Salvar(dto);
        }

        public List<ItemDTO> Listar()
        {
            ItemDatabase db = new ItemDatabase();
            return db.Listar();
        }

        public List<ItemDTO> Consultar(string nome, int fornecedor)
        {
            ItemDatabase db = new ItemDatabase();
            return db.Consultar(nome, fornecedor);
        }

        internal List<ItemDTO> Consultar(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
