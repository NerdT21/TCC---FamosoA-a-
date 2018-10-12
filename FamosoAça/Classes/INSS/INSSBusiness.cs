using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.INSS
{
    public class INSSBusiness
    {
         public int Salvar(INSSDTO dto)
        {
            INSSDataBase db = new INSSDataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(INSSDTO dto)
        {
            INSSDataBase db = new INSSDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            INSSDataBase db= new INSSDataBase();
            db.Remover(id);
        }

       
        public List<INSSDTO> Listar()
        {
            INSSDataBase db = new INSSDataBase();
            List<INSSDTO> list = db.Listar();
            return list;
        }
        
        public List<INSSDTO> Consultar(string consult)
        {
            INSSDataBase db = new INSSDataBase();
            return db.Consultar(consult);
        }

       
 
    }
}
