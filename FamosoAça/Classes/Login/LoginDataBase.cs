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
	                         nm_funcionario,
                             nm_usuario,
	                         ds_senha,
                             ds_email,
	                         pr_permissaoAdm,
	                         pr_permissaoCaixa,
	                         pr_permissaoFinanceiro,
	                         pr_permissaoEstoque,
	                         pr_permissaoCadastros)
                      VALUES(@nm_funcionario,
                             @nm_usuario,
	                         @ds_senha,
                             @ds_email,
	                         @pr_permissaoAdm,
	                         @pr_permissaoCaixa,
	                         @pr_permissaoFinanceiro,
	                         @pr_permissaoEstoque,
	                         @pr_permissaoCadastros)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_funcionario", dto.Usuario));
            parms.Add(new MySqlParameter("nm_usuario", dto.Usuario));
            parms.Add(new MySqlParameter("ds_senha", dto.Senha));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("pr_permissaoAdm", dto.PermissaoAdm));
            parms.Add(new MySqlParameter("pr_permissaoCaixa", dto.PermissaoCaixa));
            parms.Add(new MySqlParameter("pr_permissaoFinanceiro", dto.PermissaoFinanceiro));
            parms.Add(new MySqlParameter("pr_permissaoEstoque", dto.PermissaoEstoque));
            parms.Add(new MySqlParameter("pr_permissaoCadastros", dto.PermissaoCadastros));

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
                dto.Funcionario = reader.GetString("nm_funcionario");
                dto.Usuario = reader.GetString("nm_usuario");
                dto.Senha = reader.GetString("ds_senha");
                dto.Email = reader.GetString("ds_email");
                dto.PermissaoAdm = reader.GetBoolean("pr_permissaoAdm");
                dto.PermissaoCaixa = reader.GetBoolean("pr_permissaoCaixa");
                dto.PermissaoEstoque = reader.GetBoolean("pr_permissaoFinanceiro");
                dto.PermissaoFinanceiro = reader.GetBoolean("pr_permissaoEstoque");
                dto.PermissaoCadastros = reader.GetBoolean("pr_permissaoCadastros");        
            }

            reader.Close();
            return dto;
        }      
    }
}
