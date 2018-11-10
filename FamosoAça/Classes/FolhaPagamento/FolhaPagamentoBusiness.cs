using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.FolhaPagamento
{
    public class FolhaPagamentoBusiness
    {
        public int Salvar(FolhaPagamentoDTO folhapag)
        {
            FolhaPagamentoDataBase DB = new FolhaPagamentoDataBase();
            int id = DB.Salvar(folhapag);
            return id;
        }

        public void Remover(int idfolhapag)
        {
            FolhaPagamentoDataBase DB = new FolhaPagamentoDataBase();
            DB.Remover(idfolhapag);
        }

        public List<FolhaPagamentoDTO> Listar()
        {
            FolhaPagamentoDataBase DB = new FolhaPagamentoDataBase();
            List<FolhaPagamentoDTO> folhapag = DB.Listar();
            return folhapag;
        }

        public List<FolhaPagamentoDTO> Consultar(string consult)
        {
            FolhaPagamentoDataBase db = new FolhaPagamentoDataBase();
            return db.Consultar(consult);
        }
    }
}
