using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Estoque
{
    public class EstoqueDataBase
    {
        public int Salvar(EstoqueDTO dto)
        {
            string script = @"INSERT INTO tb_estoque(id_itemProduto, nm_produto, qtd_estocado)
                                              VALUES(@id_itemProduto, @nm_produto, @qtd_estocado)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_itemProduto", dto.ItemProdutoId));
            parms.Add(new MySqlParameter("nm_produto", dto.Produto));
            parms.Add(new MySqlParameter("qtd_estocado", dto.QtdEstocado));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public EstoqueDTO ListarCompraVenda()
        {
            string script = @"SELECT * FROM tb_estoque";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            EstoqueDTO dto = null;
            while (reader.Read())
            {
                dto = new EstoqueDTO();
                dto.Id = reader.GetInt32("id_estoque");
                dto.ItemProdutoId = reader.GetInt32("id_itemProduto");
                dto.Produto = reader.GetString("nm_produto");
                dto.QtdEstocado = reader.GetInt32("qtd_estocado");
            }
            reader.Close();
            return dto;
        }

        public List<EstoqueDTO> Listar()
        {
            string script = @"SELECT * FROM tb_estoque";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<EstoqueDTO> lista = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.Id = reader.GetInt32("id_estoque");
                dto.ItemProdutoId = reader.GetInt32("id_itemProduto");
                dto.Produto = reader.GetString("nm_produto");
                dto.QtdEstocado = reader.GetInt32("qtd_estocado");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<EstoqueView> Consultar(string produto)
        {
            string script = @"SELECT * FROM vw_estoque WHERE nm_produto LIKE @nm_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", produto + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EstoqueView> lista = new List<EstoqueView>();
            while (reader.Read())
            {
                EstoqueView dto = new EstoqueView();
                dto.Id = reader.GetInt32("id_estoque");
                dto.ItemId = reader.GetInt32("id_item");
                dto.Produto = reader.GetString("nm_produto");
                dto.QtdEstocado = reader.GetInt32("qtd_estocado");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }
        public void Adicionar(int qtd, int idProduto)
        {
            string script = @"UPDATE tb_estoque SET qtd_estocado = qtd_estocado + @qtd_estocado
                                              WHERE id_itemProduto = @id_itemProduto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_itemProduto", idProduto));
            parms.Add(new MySqlParameter("qtd_estocado", qtd));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int qtd, int idProduto)
        {
            string script = @"UPDATE tb_estoque SET qtd_estocado = qtd_estocado - @qtd_estocado
                                              WHERE id_itemProduto = @id_itemProduto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_itemProduto", idProduto));
            parms.Add(new MySqlParameter("qtd_estocado", qtd));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


    }
          
}