using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Estoque
{
    public class EstoqueBusiness
    {
        public int Salvar(EstoqueDTO dto)
        {
            EstoqueDataBase db = new EstoqueDataBase();
            return db.Salvar(dto);
        }

        public List<EstoqueDTO> Listar()
        {
            EstoqueDataBase db = new EstoqueDataBase();
            return db.Listar();
        }

        public EstoqueDTO ListarCompraVenda()
        {
            EstoqueDataBase db = new EstoqueDataBase();
            return db.ListarCompraVenda();
        }
        public List<EstoqueView> Consultar(string nome)
        {
            EstoqueDataBase db = new EstoqueDataBase();
            return db.Consultar(nome);
        }
        public void Adicionar(int qtd, int idProduto)
        {
            EstoqueDataBase db = new EstoqueDataBase();
            db.Adicionar(qtd, idProduto);
        }

        public void Remover(int qtd, int idProduto)
        {
            EstoqueDataBase db = new EstoqueDataBase();
            db.Remover(qtd, idProduto);
        }
    }
}
