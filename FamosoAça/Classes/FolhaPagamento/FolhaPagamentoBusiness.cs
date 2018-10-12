using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.FolhaPagamento
{
    public class FolhaPagamentoBusiness
    {
         public int Salvar(FolhaPagamentoDTO dto)
        {
            FolhaPagamentoDataBase db = new FolhaPagamentoDataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(FolhaPagamentoDTO dto)
        {
            FolhaPagamentoDataBase db = new FolhaPagamentoDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            FolhaPagamentoDataBase db= new FolhaPagamentoDataBase();
            db.Remover(id);
        }

       
        public List<FolhaPagamentoDTO> Listar()
        {
            FolhaPagamentoDataBase db = new FolhaPagamentoDataBase();
            List<FolhaPagamentoDTO> list = db.Listar();
            return list;
        }
        
        public List<FolhaPagamentoDTO> Consultar(string consult)
        {
            FolhaPagamentoDataBase db = new FolhaPagamentoDataBase();
            return db.Consultar(consult);
        }

       
 
    }
}
