using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Estado
{
    class EstadoDataBase
    {
        public List<EstadoDTO> Listar()
        {
            string script = @"SELECT * FROM tb_estados";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<EstadoDTO> list = new List<EstadoDTO>();
            while (reader.Read())
            {
                EstadoDTO dto = new EstadoDTO();
                dto.ID = reader.GetInt32("id_estado");
                dto.Nome = reader.GetString("nm_estado");

                list.Add(dto);
            }
            reader.Close();

            return list;

        } 
    }
}
