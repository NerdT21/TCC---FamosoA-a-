using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Cargo
{
    public class CargoDataBase
    {
        public int Salvar(CargoDTO dto)
        {
            string script = @"INSERT INTO tb_depto(nm_depto, ds_depto) VALUES(@nm_depto, @ds_depto)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_depto", dto.Nome));
            parms.Add(new MySqlParameter("ds_depto", dto.Descricao));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<CargoDTO> Listar()
        {
            string script = @"SELECT * FROM tb_depto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CargoDTO> lista = new List<CargoDTO>();
            while (reader.Read())
            {
                CargoDTO dto = new CargoDTO();
                dto.Id = reader.GetInt32("id_depto");
                dto.Nome = reader.GetString("nm_depto");
                dto.Descricao = reader.GetString("ds_depto");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<CargoDTO> Consultar(string nome)
        {
            string script = @"SELECT * FROM tb_depto WHERE nm_depto LIKE @nm_depto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_depto", nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CargoDTO> lista = new List<CargoDTO>();
            while (reader.Read())
            {
                CargoDTO dto = new CargoDTO();
                dto.Id = reader.GetInt32("id_depto");
                dto.Nome = reader.GetString("nm_depto");
                dto.Descricao = reader.GetString("ds_depto");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }
    }
}
