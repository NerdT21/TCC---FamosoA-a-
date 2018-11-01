using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Funcionarios
{
    public class FuncionarioDataBase
    {
        public int Salvar(FuncionarioDTO dto)
        {
            string script = @"INSERT INTO tb_funcionario(id_depto,
                            nm_nome,
                            ds_email, 
                            ds_cpf,
                            ds_rg,
                            dt_nascimento,        
                            ds_cidade,
                            id_estado,
                            ds_cep,
                            ds_telefone,
                            ds_bairro,
                            ds_rua,
                            img_funcionario,
                            vl_salario) VALUES(
                            @id_depto,
                            @nm_nome,
                            @ds_email, 
                            @ds_cpf,
                            @ds_rg,
                            @dt_nascimento,        
                            @ds_cidade,
                            @id_estado,
                            @ds_cep,
                            @ds_telefone,
                            @ds_bairro,
                            @ds_rua,
                            @img_funcionario,
                            @vl_salario)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_depto", dto.DeptoId));
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("ds_cpf", dto.CPF));
            parms.Add(new MySqlParameter("ds_rg", dto.RG));
            parms.Add(new MySqlParameter("dt_nascimento", dto.Nascimento));
            parms.Add(new MySqlParameter("ds_cidade", dto.Cidade));
            parms.Add(new MySqlParameter("id_estado", dto.Estado));
            parms.Add(new MySqlParameter("ds_cep", dto.CEP));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_rua", dto.Rua));            
            parms.Add(new MySqlParameter("img_funcionario", dto.Imagem));
            parms.Add(new MySqlParameter("vl_salario", dto.Salario));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);

        }

        public List<FuncionarioDTO> Listar()
        {
            string script = @"SELECT * FROM tb_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();

            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id = reader.GetInt32("id_funcionario");
                dto.DeptoId = reader.GetInt32("id_depto");
                dto.Nome = reader.GetString("nm_nome");
                dto.Email = reader.GetString("ds_email");
                dto.CPF = reader.GetString("ds_cpf");
                dto.RG = reader.GetString("ds_rg");
                dto.Nascimento = reader.GetString("dt_nascimento");
                dto.Cidade = reader.GetString("ds_cidade");
                dto.Estado = reader.GetInt32("id_estado");
                dto.CEP = reader.GetString("ds_cep");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Bairro = reader.GetString("ds_bairro");
                dto.Rua = reader.GetString("ds_rua");
                dto.Imagem = reader.GetString("img_funcionario");
                dto.Salario = reader.GetDecimal("vl_salario");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<FuncionarioDTO> Consultar(string nome, string cidade)
        {
            string script = @"SELECT * FROM tb_funcionario WHERE nm_nome LIKE @nm_nome AND ds_cidade LIKE @ ds_cidade";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", nome + "%"));
            parms.Add(new MySqlParameter("ds_cidade", cidade + "%"));

            Database db = new Database();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();

            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id = reader.GetInt32("id_funcionario");
                dto.DeptoId = reader.GetInt32("id_depto");
                dto.Nome = reader.GetString("nm_nome");
                dto.Email = reader.GetString("ds_email");
                dto.CPF = reader.GetString("ds_cpf");
                dto.RG = reader.GetString("ds_rg");
                dto.Nascimento = reader.GetString("dt_nascimento");
                dto.Cidade = reader.GetString("ds_cidade");
                dto.Estado = reader.GetInt32("id_estado");
                dto.CEP = reader.GetString("ds_cep");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Bairro = reader.GetString("ds_bairro");
                dto.Rua = reader.GetString("ds_rua");
                dto.Imagem = reader.GetString("img_funcionario");
                dto.Salario = reader.GetDecimal("vl_salario");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public void Remover(int Id)
        {
            string script = @"DELETE FROM tb_funcionario WHERE id_funcionario = @id_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }
    }
}
