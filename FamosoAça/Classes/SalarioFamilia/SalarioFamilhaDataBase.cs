using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.SalarioFamilia
{
    public class SalarioFamilhaDataBase
    {
        public SalarioFamilhaDTO Consultar(decimal salario)
        {

            string script = @"SELECT * FROM tb_salarioFamilia WHERE ds_salFamilia = @ds_salFamilia";

            Database db = new Database();
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_salFamilia", salario));

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            SalarioFamilhaDTO add = null;
            if (reader.Read())
            {
                add = new SalarioFamilhaDTO();
                add.Id = reader.GetInt32("id_salFamilia");
                add.SalFamilia = reader.GetDecimal("ds_salFamilia");
                add.Valor = reader.GetInt32("vl_salFamilia");
            }

            reader.Close();

            return add;

        }
    }
}
