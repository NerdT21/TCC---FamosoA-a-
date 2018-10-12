using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Estoque
{
    public class EstoqueBusiness
    {
         public int Salvar(ExemploDTO dto)
        {
            ExemploDatabase db = new ExemploDatabase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(ExemploDTO dto)
        {
            ExemploDatabase db = new ExemploDatabase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            ExemploDatabase db= new ExemploDatabase();
            db.Remover(id);
        }

       
        public List<> Listar()
        {
            ExemploDatabase db = new ExemploDatabase();
            List<> list = db.Listar();
            return list;
        }
        
        public List<> Consultar(string consult)
        {
            ExemploDatabase db = new ExemploDatabase();
            return db.Consultar(consult);
        }

       
 
    }
}
