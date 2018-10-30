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

        public void Altera(EstoqueDTO dto)
        {
            EstoqueDataBase db = new EstoqueDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            EstoqueDataBase db = new EstoqueDataBase();
            db.Remover(id);
        }

       
        public List<EstoqueDTO> Listar()
        {
            EstoqueDataBase db = new EstoqueDataBase();
            List<EstoqueDTO> list = db.Listar();
            return list;
        }
        
        public List<EstoqueDTO> Consultar(string nome, int quantidade)
        {
            EstoqueDataBase db = new EstoqueDataBase();
            return db.Consultar(nome ,quantidade);
        }

       
 
    }
}
