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
       public void Alterar(VendaDTO venda)
        {
            string script = @"UPDATE tb_venda SET 
                          id_usuario = @id_usuario,
                          dt_venda = @dt_venda,
                          ds_formaPagamento = @ds_formaPagamento,
                          WHERE id_venda = @id_venda";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_venda", venda.Id));
            parms.Add(new MySqlParameter("id_usuario", venda.IdUsuario));
            parms.Add(new MySqlParameter("dt_venda", venda.DataVenda));
            parms.Add(new MySqlParameter("ds_formaPagamento", venda.FormaDePagamento));
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
                dto.IdUsuario = reader.GetInt32("id_usuario");
                dto.DataVenda = reader.GetString("dt_venda");
                dto.FormaDePagamento = reader.GetString("ds_formaPagamento");
                

                venda.Add(dto);
            }
            reader.Close();
            return venda;
        }
        public List<VendaDTO> Consultar(string data)
        {
            string script = @"SELECT * FROM tb_venda WHERE dt_venda LIKE @dt_venda";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_venda", data + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VendaDTO> venda = new List<VendaDTO>();
            while (reader.Read()) 
            {
                VendaDTO dto = new VendaDTO();
                dto.Id = reader.GetInt32("id_venda");
                dto.IdUsuario = reader.GetInt32("id_usuario");
                dto.DataVenda = reader.GetString("dt_venda");
                dto.FormaDePagamento = reader.GetString("ds_formaPagamento");

                venda.Add(dto);
            }
            reader.Close();
            return venda;
        }
    }
}
