using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Gastos
{
  public class GastosDatabase
    {
        public int Salvar(GastosDTO dto)
        {
            string script = @"INSERT INTO tb_gastosAdicionais(
                                          nm_gasto,
	                                      ds_gasto,
	                                      vl_gasto)
                                    VALUES(@nm_gasto,
	                                       @ds_gasto,
	                                       @vl_gasto)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_gasto", dto.Nome));
            parms.Add(new MySqlParameter("ds_gasto", dto.Descrição));
            parms.Add(new MySqlParameter("vl_gasto", dto.Valor));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }
        public void Alterar(GastosDTO dto)
        {
            string script = @"UPDATE tb_gastosAdicionais SET nm_gasto = @nm_gasto,
                                                             ds_gasto = @ds_gasto,
                                                             vl_gasto = @vl_gasto WHERE
                                                             id_gasto = @id_gasto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_gasto", dto.Id));
            parms.Add(new MySqlParameter("nm_gasto", dto.Nome));
            parms.Add(new MySqlParameter("ds_gasto", dto.Descrição));
            parms.Add(new MySqlParameter("vl_gasto", dto.Valor));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }
        public void Remover(int idgasto)
        {
            string script = @"DELETE FROM tb_gastosAdicionais WHERE id_gasto = @id_gasot";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<GastosDTO> Listar()
        {
            string script = @"SELECT *FROM tb_gastosAdicionais";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<GastosDTO> Gastos = new List<GastosDTO>();
            while (reader.Read())
            {
                GastosDTO dto = new GastosDTO();
                dto.Id = reader.GetInt32("id_gasto");
                dto.Nome = reader.GetString("nm_gasto");
                dto.Descrição = reader.GetString("ds_gasto");
                dto.Valor = reader.GetDecimal("vl_valor");

                Gastos.Add(dto);
            }
            reader.Close();
            return Gastos;
        }
        public List<GastosDTO> Consultar(string nome)
        {
            string script = @"SELECT * FROM tb_gastosAdicionais WHERE nm_gasto LIKE @nm_gasto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_gasto", nome + "%"));

            Database db = new Database();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<GastosDTO> Gastos = new List<GastosDTO>();
            while (reader.Read())
            {
                GastosDTO dto = new GastosDTO();
                dto.Id = reader.GetInt32("id_gasto");
                dto.Nome = reader.GetString("nm_gasto");
                dto.Descrição = reader.GetString("ds_gasto");
                dto.Valor = reader.GetDecimal("vl_valor");

                Gastos.Add(dto);
            }
            reader.Close();
            return Gastos;
        }
    }
}
