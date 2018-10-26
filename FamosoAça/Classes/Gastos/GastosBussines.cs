using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Gastos
{
   public class GastosBussines
    {
        public int Salvar(GastosDTO dto)
        {
            GastosDatabase db = new GastosDatabase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(GastosDTO dto)
        {
            GastosDatabase db = new GastosDatabase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            GastosDatabase db = new GastosDatabase();
            db.Remover(id);
        }


        public List<GastosDTO> Listar()
        {
            GastosDatabase db = new GastosDatabase();
            List<GastosDTO> list = db.Listar();
            return list;
        }

        public List<GastosDTO> Consultar(string nome)
        {
            GastosDatabase db = new GastosDatabase();
            return db.Consultar(nome);
        }
    }
}
