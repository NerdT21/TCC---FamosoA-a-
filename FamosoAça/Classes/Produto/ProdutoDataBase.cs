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
 	                          vl_preco,
	                          ds_descricao)
                                VALUES(

	                            @nm_nome,
 	                            @vl_preco,
	                            @ds_descricao)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", produto));
            parms.Add(new MySqlParameter("vl_preco", produto.Preco));
            parms.Add(new MySqlParameter("ds_descricap", produto.Descricao));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public void Alterar(ProdutoDTO produto)
        {
            string script = @"UPDATE tb_salario_familia SET 
                             nm_produto = @nm_produto,
                             vl_preco = @vl_preco,
                             ds_descricao = @ds_descricao";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", produto));
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
                dto.Descricao = reader.GetString("ds_descricao");

                produto.Add(dto);


            }
            reader.Close();
            return produto;
        }
        public List<ProdutoDTO> Consultar(string nome)
        {
            string script = @"SELECT * FROM tb_salario_familia WHERE vl_sal_bruto LIKE @vl_sal_bruto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("vl_sal_bruto", nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoDTO> produto = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id = reader.GetInt32("id_produto");
                dto.Nome = reader.GetString("nm_nome");
                dto.Preco = reader.GetDecimal("vl_preco");
                dto.Descricao = reader.GetString("ds_descricao");

                produto.Add(dto);


                produto.Add(dto);
            }
            reader.Close();
            return produto;
        }
    }
}
