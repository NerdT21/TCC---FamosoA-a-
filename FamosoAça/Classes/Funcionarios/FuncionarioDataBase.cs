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
        public int Salvar(FuncionarioDTO funcio)
        {
            string script = @"INSERT INTO tb_funcionario   (ds_salario,
                                                              id_depto,
                                                              id_estado,
                                                              nm_nome,
                                                              ds_email,
                                                              ds_cpf,
                                                              ds_rg,
                                                              ds_cep,
                                                              ds_rua,
                                                              ds_numero,
                                                              ds_complemento,
                                                              ds_cidade,
                                                              ds_telefone,
                                                              img_funcionario)
                                                      VALUES (@ds_salario,
                                                              @id_depto,
                                                              @id_estado,
                                                              @nm_nome,
                                                              @ds_email,
                                                              @ds_cpf,
                                                              @ds_rg,
                                                              @ds_cep,
                                                              @ds_rua,
                                                              @ds_numero,
                                                              @ds_complemento,
                                                              @ds_cidade,
                                                              @ds_telefone,
                                                              @img_funcionario)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_salario", funcio.Salario));
            parms.Add(new MySqlParameter("id_depto", funcio.IdDepto));
            parms.Add(new MySqlParameter("id_estado", funcio.IdEstado));
            parms.Add(new MySqlParameter("nm_nome", funcio.Nome));
            parms.Add(new MySqlParameter("ds_email", funcio.Email));
            parms.Add(new MySqlParameter("ds_cpf", funcio.Cpf));
            parms.Add(new MySqlParameter("ds_rg", funcio.Rg));
            parms.Add(new MySqlParameter("ds_cep", funcio.Cep));
            parms.Add(new MySqlParameter("ds_rua", funcio.Rua));
            parms.Add(new MySqlParameter("ds_numero", funcio.Numero));
            parms.Add(new MySqlParameter("ds_complemento", funcio.Complemento));
            parms.Add(new MySqlParameter("ds_cidade", funcio.Cidade));
            parms.Add(new MySqlParameter("ds_telefone", funcio.Telefone));
            parms.Add(new MySqlParameter("img_funcionario", funcio.Imagem));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(FuncionarioDTO funcio)
        {
            string script = @"UPDATE tb_funcionario SET ds_salario = @ds_salario,
                                                        id_depto = @id_depto, 
                                                        nm_nome = @nm_nome,
                                                        ds_email = @ds_email,
                                                        ds_cpf = @ds_cpf,
                                                        ds_rg = @ds_rg,
                                                        id_estado = @id_estado,                
                                                        ds_cidade = @ds_cidade,
                                                        ds_cep = @ds_cep,
                                                        ds_rua = @ds_rua,
                                                        ds_numero = @ds_numero,    
                                                        ds_complemento = @ds_complemento,
                                                        ds_telefone = @ds_telefone,
                                                        img_funcionario = @img_funcionario
                                                        WHERE id_funcionario = @id_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", funcio.Id));
            parms.Add(new MySqlParameter("ds_salario", funcio.Salario));
            parms.Add(new MySqlParameter("id_depto", funcio.IdDepto));
            parms.Add(new MySqlParameter("nm_nome", funcio.Nome));
            parms.Add(new MySqlParameter("ds_email", funcio.Email));
            parms.Add(new MySqlParameter("ds_cpf", funcio.Cpf));
            parms.Add(new MySqlParameter("ds_rg", funcio.Rg));
            parms.Add(new MySqlParameter("id_estado", funcio.IdEstado));
            parms.Add(new MySqlParameter("ds_cidade", funcio.Cidade));
            parms.Add(new MySqlParameter("ds_cep", funcio.Cep));
            parms.Add(new MySqlParameter("ds_rua", funcio.Rua));
            parms.Add(new MySqlParameter("ds_numero", funcio.Numero));
            parms.Add(new MySqlParameter("ds_complemento", funcio.Complemento));
            parms.Add(new MySqlParameter("ds_telefone", funcio.Telefone));
            parms.Add(new MySqlParameter("img_funcionario", funcio.Imagem));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int Id)
        {
            string script = "DELETE FROM tb_funcionario WHERE id_funcionario = @id_funcionario ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ViewFuncionario> Listar()
        {
            string script = @"SELECT * FROM vw_consultarFuncionario ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ViewFuncionario> lista = new List<ViewFuncionario>();
            while (reader.Read())
            {
                ViewFuncionario add = new ViewFuncionario();
                add.Id = reader.GetInt32("id_funcionario");
                add.Salario = reader.GetInt32("ds_salario");
                add.Depto = reader.GetString("nm_depto");
                add.Nome = reader.GetString("nm_nome");
                add.Email = reader.GetString("ds_email");
                add.Cpf = reader.GetString("ds_cpf");
                add.Rg = reader.GetString("ds_rg");
                add.Estado = reader.GetString("nm_estado");
                add.Cidade = reader.GetString("ds_cidade");
                add.Cep = reader.GetString("ds_cep");
                add.Rua = reader.GetString("ds_rua");
                add.Numero = reader.GetString("ds_numero");
                add.Complemento = reader.GetString("ds_complemento");
                add.Telefone = reader.GetString("ds_telefone");
                add.Imagem = reader.GetString("img_funcionario");

                lista.Add(add);
            }
            reader.Close();
            return lista;
        }

        public List<ViewFuncionario> Consultar(string nome, string cpf)
        {
            string script = @"SELECT * FROM vw_consultarFuncionario WHERE nm_nome LIKE @nm_nome AND ds_cpf LIKE @ds_cpf";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", nome + "%"));
            parms.Add(new MySqlParameter("ds_cpf", cpf + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ViewFuncionario> lista = new List<ViewFuncionario>();
            while (reader.Read())
            {
                ViewFuncionario add = new ViewFuncionario();
                add.Id = reader.GetInt32("id_funcionario");
                add.Salario = reader.GetInt32("ds_salario");
                add.Depto = reader.GetString("nm_depto");
                add.Nome = reader.GetString("nm_nome");
                add.Email = reader.GetString("ds_email");
                add.Cpf = reader.GetString("ds_cpf");
                add.Rg = reader.GetString("ds_rg");
                add.Estado = reader.GetString("nm_estado");
                add.Cidade = reader.GetString("ds_cidade");
                add.Cep = reader.GetString("ds_cep");
                add.Rua = reader.GetString("ds_rua");
                add.Numero = reader.GetString("ds_numero");
                add.Complemento = reader.GetString("ds_complemento");
                add.Telefone = reader.GetString("ds_telefone");
                add.Imagem = reader.GetString("img_funcionario");

                lista.Add(add);
            }
            reader.Close();
            return lista;
        }
    }
}
