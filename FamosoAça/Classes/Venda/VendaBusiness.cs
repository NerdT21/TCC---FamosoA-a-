using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Venda
{
    public class VendaBusiness
    {
         public int Salvar(VendaDTO dto)
        {
            VendaDataBase db = new VendaDataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(VendaDTO dto)
        {
            VendaDataBase db = new VendaDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            VendaDataBase db= new VendaDataBase();
            db.Remover(id);
        }

       
        public List<VendaDTO> Listar()
        {
            VendaDataBase db = new VendaDataBase();
            List<VendaDTO> list = db.Listar();
            return list;
        }
        
        public List<VendaDTO> Consultar(string consult)
        {
            VendaDataBase db = new VendaDataBase();
            return db.Consultar(consult);
        }

       
 
    }
}
