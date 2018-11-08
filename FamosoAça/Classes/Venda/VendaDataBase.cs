using FamosoAça.Classes.Produto.Produto_Venda;
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
                            id_usuario,
	                        dt_venda,
	                        ds_formaPagamento) 
                            VALUES(
                            @id_usuario,
                            @dt_venda,
	                        @ds_formaPagamento)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_usuario", venda.Id));
            parms.Add(new MySqlParameter("dt_venda", venda.DataVenda));
            parms.Add(new MySqlParameter("ds_formaPagamento", venda.FormaDePagamento));
           

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
       
        public List<ProdutoVendaView> Listar()
        {
            string script = @"SELECT * FROM tb_venda";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ProdutoVendaView> venda = new List<ProdutoVendaView>();
            while (reader.Read())
            {
                ProdutoVendaView dto = new ProdutoVendaView();
                dto.ID = reader.GetInt32("id_venda");
                dto.FormaPagamento = reader.GetString("ds_formaPagto");
                dto.Data = reader.GetString("dt_venda");
                dto.QTDItme = reader.GetInt32("qtd_item");
                dto.Total = reader.GetDecimal("vl_total");


                venda.Add(dto);
            }
            reader.Close();
            return venda;
        }
        public List<ProdutoVendaView> Consultar(string data)
        {
            string script = @"SELECT * FROM vw_consultar_venda WHERE dt_venda LIKE @dt_venda";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_venda", data + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoVendaView> venda = new List<ProdutoVendaView>();
            while (reader.Read()) 
            {
                ProdutoVendaView dto = new ProdutoVendaView();
                dto.ID = reader.GetInt32("id_venda");
                dto.FormaPagamento = reader.GetString("ds_formaPagto");
                dto.Data = reader.GetString("dt_venda");
                dto.QTDItme = reader.GetInt32("qtd_item");
                dto.Total = reader.GetDecimal("vl_total");

                venda.Add(dto);
            }
            reader.Close();
            return venda;
        }
    }
}
