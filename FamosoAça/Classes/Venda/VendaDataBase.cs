using FamosoAça.Classes.Venda.ProdutoVendas;
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
        public int Salvar(VendaDTO dto)
        {
            string script = @"INSERT INTO tb_venda(
                                           id_usuario,
                                           dt_venda,
                                           ds_formaPagto)                                                                     
                                    VALUES(@id_usuario,
                                           @dt_venda, 
                                           @ds_formaPagto)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_usuario", dto.IdUsuario));
            parms.Add(new MySqlParameter("dt_venda", dto.Data));
            parms.Add(new MySqlParameter("ds_formaPagto", dto.FormaPagto));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<ProdutoVendasView> Listar()
        {
            string script = @"SELECT * FROM vw_venda_consultar";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ProdutoVendasView> lista = new List<ProdutoVendasView>();
            while (reader.Read())
            {
                ProdutoVendasView dto = new ProdutoVendasView();
                dto.Id = reader.GetInt32("id_venda");
                dto.FormaPagto = reader.GetString("ds_formaPagto");
                dto.Data = reader.GetString("dt_venda");
                dto.QtdItem = reader.GetInt32("qtd_item");
                dto.Total = reader.GetDecimal("vl_total");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<ProdutoVendasView> Consultar(string data)
        {
            string script = @"SELECT * FROM vw_venda_consultar WHERE dt_compra LIKE @dt_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_compra", data + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoVendasView> lista = new List<ProdutoVendasView>();
            while (reader.Read())
            {
                ProdutoVendasView view = new ProdutoVendasView();
                view.Id = reader.GetInt32("id_compra");
                view.FormaPagto = reader.GetString("ds_formaPagamento");
                view.Data = reader.GetString("dt_compra");
                view.QtdItem = reader.GetInt32("qtd_item");
                view.Total = reader.GetDecimal("vl_total");

                lista.Add(view);
            }
            reader.Close();
            return lista;
        }
    }
}
