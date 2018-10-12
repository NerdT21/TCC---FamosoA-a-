using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.ItemVenda
{
    public class ItemVendaBusiness
    {
         public int Salvar(ItemVendaDTO dto)
        {
            ItemVendaDataBase db = new ItemVendaDataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(ItemVendaDTO dto)
        {
            ItemVendaDataBase db = new ItemVendaDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            ItemVendaDataBase db= new ItemVendaDataBase();
            db.Remover(id);
        }

       
        public List<ItemVendaDTO> Listar()
        {
            ItemVendaDataBase db = new ItemVendaDataBase();
            List<ItemVendaDTO> list = db.Listar();
            return list;
        }
        
        public List<ItemVendaDTO> Consultar(string consult)
        {
            ItemVendaDataBase db = new ItemVendaDataBase();
            return db.Consultar(consult);
        }

       
 
    }
}
