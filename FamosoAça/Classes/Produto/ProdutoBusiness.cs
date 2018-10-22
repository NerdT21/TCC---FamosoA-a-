using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Produto
{
    public class ProdutoBusiness
    {
        public int Salvar(ProdutoDTO dto)
        {
            ProdutoDataBase db = new ProdutoDataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(ProdutoDTO dto)
        {
            ProdutoDataBase db = new ProdutoDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            ProdutoDataBase db = new ProdutoDataBase();
            db.Remover(id);
        }


        public List<ProdutoDTO> Listar()
        {
            ProdutoDataBase db = new ProdutoDataBase();
            List<ProdutoDTO> list = db.Listar();
            return list;
        }

        public List<ProdutoDTO> Consultar(string nome, string marca)
        {
            ProdutoDataBase db = new ProdutoDataBase();
            return db.Consultar(nome, marca);
        }

    }
}
