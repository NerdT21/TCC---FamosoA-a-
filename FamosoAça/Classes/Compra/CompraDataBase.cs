using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Compra
{
    public class CompraDataBase
    {
        public int Salvar(CompraDTO dto)
        {
            string script = @"INSERT INTO tb_compra(
	                          id_item,
	                          id_fornecedor,
                                qtd_comprado,
                                dt_compra,
                                vl_preco)
                                VALUES(
	                            @id_item,
 	                            @id_fornecedor,
                                @qtd_comprado,
                                @dt_compra,
                                @vl_preco
	                            )";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item", dto.IdItem));
            parms.Add(new MySqlParameter("id_fornecedor", dto.IdFornecedor));
            parms.Add(new MySqlParameter("qtd_comprado", dto.QuantidadeComprada));
            parms.Add(new MySqlParameter("dt_compra", dto.DataCompra));
            parms.Add(new MySqlParameter("vl_preco", dto.Preco));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public void Alterar(CompraDTO dto)
        {
            string script = @"UPDATE tb_compra SET id_item = @id_item,
                            id_fornecedor = @id_fornecedor,
                            qtd_comprado = @qtd_comprado,
                            dt_compra = @dt_compra,
                            vl_preco = @vl_preco
                            WHERE id_compra = @id_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item", dto.IdItem));
            parms.Add(new MySqlParameter("id_fornecedor", dto.IdFornecedor));
            parms.Add(new MySqlParameter("qtd_comprado", dto.QuantidadeComprada));
            parms.Add(new MySqlParameter("dt_compra", dto.DataCompra));
            parms.Add(new MySqlParameter("vl_preco", dto.Preco));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_compra WHERE id_compra = @id_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<CompraDTO> Listar()
        {
            string script = @"SELECT * FROM tb_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CompraDTO> produto = new List<CompraDTO>();
            while (reader.Read())
            {
                CompraDTO dto = new CompraDTO();
                dto.Id = reader.GetInt32("id_compra");
                dto.IdItem = reader.GetInt32("id_item");
                dto.IdFornecedor = reader.GetInt32("id_fornecedor");
                dto.QuantidadeComprada = reader.GetInt32("qtd_comprado");
                dto.DataCompra = reader.GetString("dt_compra");
                dto.Preco = reader.GetDecimal("vl_preco");

                produto.Add(dto);


            }
            reader.Close();
            return produto;
        }
        public List<CompraDTO> Consultar(int idfornecedor, string dt_compra)
        {
            string script = @"SELECT * FROM tb_compra WHERE id_fornecedor LIKE @id_fornecedor AND dt_compra LIKE @dt_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", idfornecedor + "%"));
            parms.Add(new MySqlParameter("dt_compra", dt_compra + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CompraDTO> produto = new List<CompraDTO>();
            while (reader.Read())
            {
                CompraDTO dto = new CompraDTO();
                dto.Id = reader.GetInt32("id_compra");
                dto.IdItem = reader.GetInt32("id_item");
                dto.IdFornecedor = reader.GetInt32("id_fornecedor");
                dto.QuantidadeComprada = reader.GetInt32("qtd_comprado");
                dto.DataCompra = reader.GetString("dt_compra");
                dto.Preco = reader.GetDecimal("vl_preco");

                produto.Add(dto);

            }
            reader.Close();
            return produto;

        }
    }
}
