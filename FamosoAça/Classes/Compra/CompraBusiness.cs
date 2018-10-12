using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Compra
{
    public class CompraBusiness
    {
        public int Salvar(CompraDTO dto)
        {
            CompraDataBase db = new CompraDataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(CompraDTO dto)
        {
            CompraDataBase db = new CompraDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            CompraDataBase db = new CompraDataBase();
            db.Remover(id);
        }


        public List<CompraDTO> Listar()
        {
            CompraDataBase db = new CompraDataBase();
            List<CompraDTO> list = db.Listar();
            return list;
        }

        public List<CompraDTO> Consultar(int idfor, string dtcompra)
        {
            CompraDataBase db = new CompraDataBase();
            return db.Consultar(idfor, dtcompra);
        }
    }
}
