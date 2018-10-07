using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.SalarioFamilia
{
    public class SalarioFamiliaDataBase
    {
        public int Salvar(SalarioFamiliaDTO salariof)
        {
            string script = @"INSERT INTO tb_salario_familia(
	                            vl_salario_bruto,
	                            vl_sal_familia,
	                            int_qtd_dependentes)
                                VALUES(

	                            @vl_salario_bruto,
	                            @vl_sal_familia,
	                            @int_qtd_dependentes)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("vl_salario_bruto", salariof.SalarioBruto));
            parms.Add(new MySqlParameter("vl_sal_familia", salariof.SalarioFamilia));
            parms.Add(new MySqlParameter("int_qtd_dependentes", salariof.Dependentes));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public void Alterar(SalarioFamiliaDTO salariof)
        {
            string script = @"UPDATE tb_salario_familia SET 
                             vl_sal_bruto = @vl_sal_bruto,
                             vl_sal_familia = @vl_sal_familia
                             int_qtd_dependentes = @int_qtd_dependentes WHERE
                             id_sal_familia = @id_sal_familia";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("vl_sal_bruto", salariof.SalarioBruto));
            parms.Add(new MySqlParameter("vl_sal_familia", salariof.SalarioFamilia));
            parms.Add(new MySqlParameter("int_qtd_dependentes", salariof.Dependentes));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public void Remover(int id_sal_familia)
        {
            string script = @"DELETE FROM tb_salario_familia WHERE id_sal_familia = @id_sal_familia";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_sal_familia", id_sal_familia));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<SalarioFamiliaDTO> Listar()
        {
            string script = @"SELECT * FROM tb_salario_familia";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<SalarioFamiliaDTO> salariof = new List<SalarioFamiliaDTO>();
            while (reader.Read())
            {
                SalarioFamiliaDTO dto = new SalarioFamiliaDTO();
                dto.ID = reader.GetInt32("id_sal_familia");
                dto.SalarioBruto = reader.GetDecimal("vl_sal_bruto");
                dto.SalarioFamilia = reader.GetDecimal("vl_sal_familia");
                dto.Dependentes = reader.GetInt32("int_qtd_dependentes");

                salariof.Add(dto);
            }
            reader.Close();
            return salariof;
        }
        public List<SalarioFamiliaDTO> Consultar(string nome)
        {
            string script = @"SELECT * FROM tb_salario_familia WHERE vl_sal_bruto LIKE @vl_sal_bruto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("vl_sal_bruto", nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<SalarioFamiliaDTO> salariof = new List<SalarioFamiliaDTO>();
            while (reader.Read())
            {
                SalarioFamiliaDTO DTO = new SalarioFamiliaDTO();
                DTO.ID = reader.GetInt32("id_sal_familia");
                DTO.SalarioBruto = reader.GetDecimal("vl_sal_bruto");
                DTO.SalarioFamilia = reader.GetDecimal("vl_sal_familia");
                DTO.Dependentes = reader.GetInt32("int_qtd_depedentes");


                salariof.Add(DTO);
            }
            reader.Close();
            return salariof;
        }
    }
}
