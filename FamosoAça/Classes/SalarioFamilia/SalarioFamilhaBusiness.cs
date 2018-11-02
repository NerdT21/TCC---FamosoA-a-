using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.SalarioFamilia
{
    public class SalarioFamilhaBusiness
    {
         public int Salvar(SalarioFamilhaDTO dto)
        {
            SalarioFamilhaDataBase db = new SalarioFamilhaDataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(SalarioFamilhaDTO dto)
        {
            SalarioFamilhaDataBase db = new SalarioFamilhaDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            SalarioFamilhaDataBase db= new SalarioFamilhaDataBase();
            db.Remover(id);
        }

       
        public List<SalarioFamilhaDTO> Listar()
        {
            SalarioFamilhaDataBase db = new SalarioFamilhaDataBase();
            List<SalarioFamilhaDTO> list = db.Listar();
            return list;
        }
        
        public List<SalarioFamilhaDTO> Consultar(string consult)
        {
            SalarioFamilhaDataBase db = new SalarioFamilhaDataBase();
            return db.Consultar(consult);
        }

       
 
    }
}
