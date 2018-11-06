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
            int id = db.Salvar(dto);
            return id;
        }

        public EstoqueDTO ListarCompraeVenda()
        {
            EstoqueDataBase db = new EstoqueDataBase();
            return db.ListarCompraVenda();
        }
   

        public void Remover(int qtd, int idProduto)
        {
            EstoqueDataBase db = new EstoqueDataBase();
            db.Remover(qtd, idProduto);
        }

       
        public List<EstoqueDTO> Listar()
        {
            EstoqueDataBase db = new EstoqueDataBase();
            List<EstoqueDTO> list = db.Listar();
            return list;
        }
        
        public List<EstoqueView> Consultar(string nome)
        {
            EstoqueDataBase db = new EstoqueDataBase();
            return db.Consultar(nome);
        }

        public void Adicionar (int qtd , int idProduto)
        {
            EstoqueDataBase db = new EstoqueDataBase();
            db.Adicionar(qtd, idProduto);
        }
       
 
    }
}
