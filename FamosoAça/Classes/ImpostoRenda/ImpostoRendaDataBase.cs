using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.ImpostoRenda
{
    public class ImpostoRendaDataBase
    {
        public ImpostoRendaDTO Consultar(decimal baseCalculo)
        {

            string script = @"SELECT * FROM tb_impostoDeRenda WHERE ds_baseDeCalculo = @ds_baseDeCalculo";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_baseDeCalculo", baseCalculo));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            ImpostoRendaDTO add = null;
            if (reader.Read())
            {
                add = new ImpostoRendaDTO();
                add.Id = reader.GetInt32("id_impostoRenda");
                add.Base = reader.GetInt32("ds_baseDeCalculo");
                add.Aliquota = reader.GetDecimal("vl_aliquota");
                add.Deducao = reader.GetDecimal("vl_deducao");
            }
            reader.Close();
            return add;
        }
    }
}
