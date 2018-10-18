using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Produto
{
    public class ProdutoDataBase
    {
        public int Salvar(ProdutoDTO produto)
        {
            string script = @"INSERT INTO tb_produto(
	                                         nm_nome,
                                             ds_marca,
 	                                         vl_preco,
	                                         ds_descricao)                               
	                                  VALUES(@nm_nome,
                                             @ds_marca,
 	                                         @vl_preco,
	                                         @ds_descricao)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", produto.Nome));
            parms.Add(new MySqlParameter("ds_marca", produto.Marca));
            parms.Add(new MySqlParameter("vl_preco", produto.Preco));
            parms.Add(new MySqlParameter("ds_descricao", produto.Descricao));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public void Alterar(ProdutoDTO produto)
        {
            string script = @"UPDATE tb_produto SET 
                             nm_produto = @nm_produto,
                             ds_marca = @ds_marca,
                             vl_preco = @vl_preco,                             
                             ds_descricao = @ds_descricao 
                             WHERE id_produto = @id_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", produto.Nome));
            parms.Add(new MySqlParameter("ds_marca", produto.Marca));
            parms.Add(new MySqlParameter("vl_preco", produto.Preco));
            parms.Add(new MySqlParameter("ds_descricao", produto.Descricao));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public void Remover(int idproduto)
        {
            string script = @"DELETE FROM tb_produto WHERE id_produto = @id_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", idproduto));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<ProdutoDTO> Listar()
        {
            string script = @"SELECT * FROM tb_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoDTO> produto = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id = reader.GetInt32("id_produto");
                dto.Nome = reader.GetString("nm_nome");
                dto.Preco = reader.GetDecimal("vl_preco");
                dto.Marca = reader.GetString("ds_marca");
                dto.Descricao = reader.GetString("ds_descricao");

                produto.Add(dto);


            }
            reader.Close();
            return produto;
        }
        public List<ProdutoDTO> Consultar(string nome, string marca)
        {
            string script = @"SELECT * FROM tb_produto WHERE nm_nome LIKE @nm_nome AND ds_marca LIKE @ds_marca";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", nome + "%"));
            parms.Add(new MySqlParameter("ds_marca", marca + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoDTO> produto = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id = reader.GetInt32("id_produto");
                dto.Nome = reader.GetString("nm_nome");
                dto.Preco = reader.GetDecimal("vl_preco");
                dto.Marca = reader.GetString("ds_marca");
                dto.Descricao = reader.GetString("ds_descricao");

                produto.Add(dto);


                produto.Add(dto);
            }
            reader.Close();
            return produto;
        }
    }
}
