using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.SalarioFamilia
{
    public class SalarioFamiliaBusiness
    {
         public int Salvar(SalarioFamiliaDTO dto)
        {
            SalarioFamiliaDataBase db = new SalarioFamiliaDataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(SalarioFamiliaDTO dto)
        {
            SalarioFamiliaDataBase db = new SalarioFamiliaDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            SalarioFamiliaDataBase db= new SalarioFamiliaDataBase();
            db.Remover(id);
        }

       
        public List<SalarioFamiliaDTO> Listar()
        {
            SalarioFamiliaDataBase db = new SalarioFamiliaDataBase();
            List<SalarioFamiliaDTO> list = db.Listar();
            return list;
        }
        
        public List<SalarioFamiliaDTO> Consultar(string consult)
        {
            SalarioFamiliaDataBase db = new SalarioFamiliaDataBase();
            return db.Consultar(consult);
        }

       
 
    }
}
