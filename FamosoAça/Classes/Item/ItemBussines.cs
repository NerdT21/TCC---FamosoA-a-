using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Item
{
    public class ItemBussines
    {
        public int Salvar(ItemDTO dto)
        {
            ItemDataBase db = new ItemDataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(ItemDTO dto)
        {
            ItemDataBase db = new ItemDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            ItemDataBase db = new ItemDataBase();
            db.Remover(id);
        }


        public List<ItemDTO> Listar()
        {
            ItemDataBase db = new ItemDataBase();
            List<ItemDTO> list = db.Listar();
            return list;
        }

        public List<ItemDTO> Consultar(string nome)
        {
            ItemDataBase db = new ItemDataBase();
            return db.Consultar(nome);
        }
    }
}
