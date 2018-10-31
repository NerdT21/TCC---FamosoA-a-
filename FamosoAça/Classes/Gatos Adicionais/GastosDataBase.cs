using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Gatos_Adicionais
{
    public class GastosDataBase
    {
       public int Salvar(GastosDTO dto)
        {
            string script = @"INSERT INTO tb_gastos(nm_gasto, 
                                                    vl_gasto,
                                                    ds_gasto, 
                                                    dt_gasto,
                                                    tp_gasto)
                                             VALUES(@nm_gasto, 
                                                    @vl_gasto,
                                                    @ds_gasto, 
                                                    @dt_gasto,
                                                    @tp_gasto )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_gasto",dto));
            parms.Add(new MySqlParameter("vl_gasto", dto));
            parms.Add(new MySqlParameter("ds_gasto", dto));
            parms.Add(new MySqlParameter("dt_gasto", dto));
            parms.Add(new MySqlParameter("tp_gasto", dto));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script,parms);
        }

        public List<GastosDTO> Listar()
        {
            string script = @"SELECT * FROM tb_gastos";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<GastosDTO> lista = new List<GastosDTO>();

            while (reader.Read())
            {
                GastosDTO dto = new GastosDTO();
                dto.Id = reader.GetInt32("id_gastos");
                dto.Nome = reader.GetString("nm_gasto");
                dto.Valor = reader.GetDecimal("vl_gasto");
                dto.Decricao = reader.GetString("ds_gasto");
                dto.Data = reader.GetDateTime("dt_gasto");
                dto.Tipo = reader.GetBoolean("tp_gasto");

                lista.Add(dto);
            }
            reader.Close();
            return lista;

        }

        public List<GastosDTO> Consultar(string nome , bool tipo)
        {
            string script = @"SELECT * FROM tb_gastos WHERE nm_gasto LIKE @ nm_gasto AND tp_gasto LIKE tp_gasto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_gasto",nome + "%"));
            parms.Add(new MySqlParameter("tp_gasto", tipo + "%"));


            Database db = new Database();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<GastosDTO> lista = new List<GastosDTO>();

            while (reader.Read())
            {
                GastosDTO dto = new GastosDTO();
                dto.Id = reader.GetInt32("id_gastos");
                dto.Nome = reader.GetString("nm_gasto");
                dto.Valor = reader.GetDecimal("vl_gasto");
                dto.Decricao = reader.GetString("ds_gasto");
                dto.Data = reader.GetDateTime("dt_gasto");
                dto.Tipo = reader.GetBoolean("tp_gasto");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_gasto WHERE id_gasto = @id_gasto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_gasto", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }



    }
}
