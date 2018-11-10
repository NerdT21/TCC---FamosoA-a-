using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Venda.Produto
{
    public class ProdutoDatabase
    {
        public int Salvar(ProdutoDTO dto)
        {
            string script = @"INSERT INTO tb_produto(nm_produto, ds_marca, ds_produto, vl_preco)
                                               VALUES(@nm_produto, @ds_marca, @ds_produto, @vl_preco)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", dto.Nome));
            parms.Add(new MySqlParameter("ds_marca", dto.Marca));
            parms.Add(new MySqlParameter("ds_produto", dto.Descricao));
            parms.Add(new MySqlParameter("vl_preco", dto.Preco));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Alterar(ProdutoDTO dto)
        {
            string script = @"UPDATE tb_produto SET nm_produto = @nm_produto,
                                                    ds_marca = @ds_marca,
                                                    ds_produto = @ds_produto,
                                                    vl_preco = @vl_preco
                                              WHERE id_produto = @ id_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", dto.Id));
            parms.Add(new MySqlParameter("nm_produto", dto.Nome));
            parms.Add(new MySqlParameter("ds_marca", dto.Marca));
            parms.Add(new MySqlParameter("ds_produto", dto.Descricao));
            parms.Add(new MySqlParameter("vl_preco", dto.Preco));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ProdutoDTO> Listar()
        {
            string script = @"SELECT * FROM tb_produto";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id = reader.GetInt32("id_produto");
                dto.Nome = reader.GetString("nm_produto");
                dto.Marca = reader.GetString("ds_marca");
                dto.Descricao = reader.GetString("ds_produto");
                dto.Preco = reader.GetDecimal("vl_preco");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<ProdutoDTO> Consultar(string nome, string marca)
        {
            string script = @"SELECT * FROM tb_produto WHERE nm_produto LIKE @nm_produto ANd ds_marca LIKE @ds_marca";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", nome + "%"));
            parms.Add(new MySqlParameter("ds_marca", marca + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id = reader.GetInt32("id_produto");
                dto.Nome = reader.GetString("nm_produto");
                dto.Marca = reader.GetString("ds_marca");
                dto.Descricao = reader.GetString("ds_produto");
                dto.Preco = reader.GetDecimal("vl_preco");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }
    }
}
