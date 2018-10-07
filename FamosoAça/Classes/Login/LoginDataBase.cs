using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Login
{
    public class LoginDataBase
    {
        public int Salvar(LoginDTO dto)
        {
            string script = @"INSERT INTO tb_login(
	                         nm_usuario,
	                         ds_senha,
	                         pr_permissaoAdm,
	                         pr_permissaoCadastro,
	                         pr_permissaoConsulta,
	                         pr_permissaoContabilidade)
                             VALUES(
                             @nm_usuario,
	                         @ds_senha,
	                         @pr_permissaoAdm,
	                         @pr_permissaoCadastro,
	                         @pr_permissaoConsulta,
	                         @pr_permissaoContabilidade)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_usuario", dto.Usuario));
            parms.Add(new MySqlParameter("ds_senha", dto.Senha));
            parms.Add(new MySqlParameter("pr_permissaoAdm", dto.Adm));
            parms.Add(new MySqlParameter("pr_permissaoCadastro", dto.Cadastro));
            parms.Add(new MySqlParameter("pr_permissaoConsulta", dto.Consulta));
            parms.Add(new MySqlParameter("pr_permissaoContabilidade", dto.Contabilidade));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

      
        public LoginDTO Logar(string usuario, string senha)
        {
            string script = @"SELECT * FROM tb_login WHERE nm_usuario = @nm_usuario AND ds_senha = @ds_senha";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_usuario", usuario));
            parms.Add(new MySqlParameter("ds_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            LoginDTO dto = null;
            if (reader.Read())
            {
                dto = new LoginDTO();
                dto.Id = reader.GetInt32("id_usuario");
                dto.Usuario = reader.GetString("nm_usuario");
                dto.Senha = reader.GetString("ds_senha");
                dto.Adm = reader.GetBoolean("pr_permissaoAdm");
                dto.Cadastro = reader.GetBoolean("pr_permissaoCadastro");
                dto.Consulta = reader.GetBoolean("pr_permissaoConsulta");
                dto.Contabilidade = reader.GetBoolean("pr_permissaoContabilidade");
            }

            reader.Close();
            return dto;
        }      
    }
}
