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
                                qtd_comprado,
                                dt_compra,
                                vl_preco)
                                VALUES(
	                            @id_item,
                                @qtd_comprado,
                                @dt_compra,
                                @vl_preco)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item", dto.IdItem));
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
                            qtd_comprado = @qtd_comprado,
                            dt_compra = @dt_compra,
                            vl_preco = @vl_preco
                            WHERE id_compra = @id_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item", dto.IdItem));
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
        public List<ViewCompra> Listar()
        {
            string script = @"SELECT * FROM tb_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ViewCompra> view = new List<ViewCompra>();
            while (reader.Read())
            {
                ViewCompra vw = new ViewCompra();
                vw.IdCompra = reader.GetInt32("id_compra");
                vw.QTDItem = reader.GetInt32("qtd_item");
                vw.FormaPag = reader.GetString("ds_formaPagamento");
                vw.Data = reader.GetString("dt_compra");
                vw.Total = reader.GetDecimal("vl_total");

                view.Add(vw);
            }
            reader.Close();
            return view;
        }
        public List<ViewCompra> Consultar(string dt_compra)
        {
            string script = @"SELECT * FROM tb_compra WHERE dt_compra LIKE @dt_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_compra", dt_compra + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ViewCompra> view = new List<ViewCompra>();
            while (reader.Read())
            {
                ViewCompra vw = new ViewCompra();
                vw.IdCompra = reader.GetInt32("id_compra");
                vw.QTDItem = reader.GetInt32("qtd_item");
                vw.FormaPag = reader.GetString("ds_formaPagamento");
                vw.Data = reader.GetString("dt_compra");
                vw.Total = reader.GetDecimal("vl_total");

                view.Add(vw);

            }
            reader.Close();
            return view;

        }
    }
}
