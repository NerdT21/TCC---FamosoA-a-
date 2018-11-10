using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.FluxoDeCaixa
{
    public class FluxoDatabase
    {
        public List<FluxoDTO> Listar()
        {
            string script = @"SELECT * FROM vw_consultar_fluxodecaixa";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FluxoDTO> lista = new List<FluxoDTO>();
            while (reader.Read())
            {
                FluxoDTO dto = new FluxoDTO();
                dto.DataReferencia = reader.GetString("dt_referencia");
                dto.Ganhos = reader.GetDecimal("vl_total_ganhos");
                dto.Despesas = reader.GetDecimal("vl_total_despesas");
                dto.Saldo = reader.GetDecimal("vl_saldo");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }
    }
}
