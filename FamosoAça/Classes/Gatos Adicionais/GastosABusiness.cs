using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Gatos_Adicionais
{
    class GastosABusiness
    {
        public int Salvar(GastosADTO dto)
        {
            GastosADataBase db = new GastosADataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Remover(int id)
        {
            GastosADataBase db = new GastosADataBase();
            db.Remover(id);
        }


        public List<GastosADTO> Listar()
        {
            GastosADataBase db = new GastosADataBase();
            List<GastosADTO> list = db.Listar();
            return list;
        }

        public List<GastosADTO> Consultar(string data)
        {
            GastosADataBase db = new GastosADataBase();
            return db.Consultar(data);
        }
    
}
}
