using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Fornecedor
{
    public class FornecedorDataBase
    {
        public int Salvar(FornecedorDTO dto)
        {
            string script = @"INSERT INTO tb_fornecedor(
                            nm_fornecedor,
                            ds_cnpj, 
                            ds_telefone,
                            ds_email,
                            ds_cidade,
                            id_estados,                        
                            ds_cep,
                            img_logo
                            ) VALUES(                            
                            @nm_fornecedor,
                            @ds_cnpj,
                            @ds_telefone,
                            @ds_email,
                            @ds_cidade,
                            @id_estados,
                            @img_logo
                            @ds_cep
                           )";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", dto.Id));
            parms.Add(new MySqlParameter("nm_fornecedor", dto.Nome));
            parms.Add(new MySqlParameter("ds_cnpj", dto.CNPJ));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("ds_cidade", dto.Cidade));
            parms.Add(new MySqlParameter("id_estados", dto.IDEstado));           
            parms.Add(new MySqlParameter("ds_cep", dto.Cep));
            parms.Add(new MySqlParameter("img_logo", dto.Logo));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public List<FornecedorDTO> Listar()
        {
            string script = @"SELECT * FROM tb_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> funcionarios = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO dto = new FornecedorDTO();
                dto.Id = reader.GetInt32("id_fornecedor");
                dto.Nome = reader.GetString("nm_fornecedor");
                dto.CNPJ = reader.GetString("ds_cnpj");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Email = reader.GetString("ds_email");
                dto.Cidade = reader.GetString("ds_cidade");
                dto.IDEstado = reader.GetInt32("id_estado");
                dto.Cep = reader.GetString("ds_cep");


                funcionarios.Add(dto);
            }
            reader.Close();

            return funcionarios;
        }

        public List<FornecedorDTO> Consultar(string nome, string cidade)
        {
            string script = @"SELECT * FROM tb_fornecedor WHERE nm_fornecedor LIKE @nm_fornecedor AND ds_cidade LIKE @ds_cidade";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", nome + "%"));
            parms.Add(new MySqlParameter("ds_cidade", cidade + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> lista = new List<FornecedorDTO>();
            while (reader.Read())
            {

                FornecedorDTO dto = new FornecedorDTO();
                dto.Id = reader.GetInt32("id_fornecedor");
                dto.Nome = reader.GetString("nm_fornecedor");
                dto.CNPJ = reader.GetString("ds_cnpj");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Email = reader.GetString("ds_email");
                dto.Cidade = reader.GetString("ds_cidade");
                dto.IDEstado = reader.GetInt32("id_estado");
                dto.Cep = reader.GetString("ds_cep");


                lista.Add(dto);
            }

            reader.Close();
            return lista;
        }

        public void Alterar(FornecedorDTO dto)
        {
            string script = @"UPDATE tb_fornecedor SET
                            nm_fornecedor = @nm_fornecedor,
                            ds_cnpj = @ds_cnpj,
                            ds_telefone = @ds_telefone,
                            ds_email = @ds_email,
                            ds_cidade = @ds_cidade,
                            ds_estado = @ds_estado,                          
                            ds_cep = @ds_cep,
                            img_logo = @img_logo
                            WHERE
                            id_fornecedor = @id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", dto.Id));
            parms.Add(new MySqlParameter("nm_fornecedor", dto.Nome));
            parms.Add(new MySqlParameter("ds_cnpj", dto.CNPJ));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("ds_cidade", dto.Cidade));
            parms.Add(new MySqlParameter("ds_estado", dto.IDEstado));           
            parms.Add(new MySqlParameter("ds_cep", dto.Cep));
            parms.Add(new MySqlParameter("img_logo", dto.Logo));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int Id)
        {
            string script = @"DELETE FROM tb_fornecedor WHERE id_fornecedor = @id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }
    }
}

