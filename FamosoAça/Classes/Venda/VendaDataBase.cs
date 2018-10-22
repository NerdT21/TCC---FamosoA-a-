using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Venda
{
    public class VendaDataBase
    {
        public int Salvar(VendaDTO venda)
        {
            string script = @"INSERT INTO tb_venda(
                            id_produto,
	                        dt_data_venda,
	                        vl_total_venda) 
                            VALUES(
                            @id_produto,
                            @dt_data_venda,
	                        @vl_total_venda)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", venda.IdProduto));
            parms.Add(new MySqlParameter("dt_data_venda", venda.DataVenda));
            parms.Add(new MySqlParameter("vl_total_venda", venda.ValorVenda));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
       public void Alterar(VendaDTO venda)
        {
            string script = @"UPDATE tb_venda SET 
                          id_produto = @id_produto,
                          dt_data_venda = @dt_data_venda,
                          vl_total_venda = @vl_total_venda WHERE
                          id_venda = @id_venda";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_venda", venda.Id));
            parms.Add(new MySqlParameter("id_produto", venda.IdProduto));
            parms.Add(new MySqlParameter("dt_data_venda", venda.DataVenda));
            parms.Add(new MySqlParameter("vl_total_venda", venda.ValorVenda));
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public void Remover(int idvenda)
        {
            string script = @"DELETE FROM tb_venda WHERE id_venda = @id_venda";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_venda", idvenda));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<VendaDTO> Listar()
        {
            string script = @"SELECT * FROM tb_venda";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VendaDTO> venda = new List<VendaDTO>();
            while (reader.Read())
            {
                VendaDTO dto = new VendaDTO();
                dto.Id = reader.GetInt32("id_venda");
                dto.IdProduto = reader.GetInt32("id_produto");
                dto.DataVenda = reader.GetString("dt_data_venda");
                dto.ValorVenda = reader.GetDecimal("vl_total_venda");

                venda.Add(dto);
            }
            reader.Close();
            return venda;
        }
        public List<VendaDTO> Consultar(string produto)
        {
            string script = @"SELECT * FROM tb_venda WHERE id_produto LIKE @id_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", produto + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VendaDTO> venda = new List<VendaDTO>();
            while (reader.Read()) 
            {
                VendaDTO dto = new VendaDTO();
                dto.Id = reader.GetInt32("id_venda");
                dto.IdProduto = reader.GetInt32("id_produto");
                dto.DataVenda = reader.GetString("dt_data_venda");
                dto.ValorVenda = reader.GetDecimal("vl_total_venda");

                venda.Add(dto);
            }
            reader.Close();
            return venda;
        }
    }
}
