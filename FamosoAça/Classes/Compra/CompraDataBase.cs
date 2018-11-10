using FamosoAça.Classes.Compra.itemCompra;
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
                                            id_usuario,
                                            dt_compra,
                                            ds_formaPagamento)                                                                     
                                     VALUES(@id_usuario,
                                            @dt_compra, 
                                            @ds_formaPagamento)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_usuario", dto.UsuarioId));
            parms.Add(new MySqlParameter("dt_compra", dto.Data));
            parms.Add(new MySqlParameter("ds_formaPagamento", dto.FormaPagto));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<ItemComprasView> Listar()
        {
            string script = @"SELECT * FROM vw_compra_consultar";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ItemComprasView> lista = new List<ItemComprasView>();
            while (reader.Read())
            {
                ItemComprasView dto = new ItemComprasView();
                dto.Id = reader.GetInt32("id_compra");
                dto.FormaPagto = reader.GetString("ds_formaPagamento");
                dto.Data = reader.GetString("dt_compra");
                dto.QtdItem = reader.GetInt32("qtd_item");
                dto.Total = reader.GetDecimal("vl_total");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<ItemComprasView> Consultar(string data)
        {
            string script = @"SELECT * FROM vw_compra_consultar WHERE dt_compra LIKE @dt_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_compra", data + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ItemComprasView> lista = new List<ItemComprasView>();
            while (reader.Read())
            {
                ItemComprasView view = new ItemComprasView();
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

        public List<ItemComprasView> ConsultarPorId(int id)
        {
            string script = @"SELECT * FROM vw_compra_consultar WHERE id_compra LIKE @id_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", id + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ItemComprasView> lista = new List<ItemComprasView>();
            while (reader.Read())
            {
                ItemComprasView view = new ItemComprasView();
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
