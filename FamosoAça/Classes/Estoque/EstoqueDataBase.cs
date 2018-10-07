using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Estoque
{
    public class EstoqueDataBase
    {
        public int Salvar(EstoqueDTO dto)
        {
            string script = @"INSERT INTO tb_estoque(
	                          id_compra,
	                          nm_produto,
                              qtd_estocado,
                              qtd_minima)
                                VALUES(
	                            @id_compra,
 	                            @nm_produto,
                                @qtd_estocado,
                                @qtd_minima
	                            )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", dto.IdCompra));
            parms.Add(new MySqlParameter("nm_produto", dto.NomeProduto));
            parms.Add(new MySqlParameter("qtd_estocado", dto.QTDestocada));
            parms.Add(new MySqlParameter("qtd_minima", dto.QTDMinima));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public void Alterar(EstoqueDTO dto)
        {
            string script = @"UPDATE tb_estoque SET nm_produto = @nm_produto, qtd_estocado = @qtd_estocado WHERE id_compra = @id_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", dto.Id));
            parms.Add(new MySqlParameter("nm_produto", dto.NomeProduto));
            parms.Add(new MySqlParameter("qtd_estocado", dto.QTDestocada));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_estoque WHERE id_estoque = @id_estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_estoque", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<EstoqueDTO> Listar()
        {
            string script = @"SELECT * FROM tb_estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EstoqueDTO> produto = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.Id = reader.GetInt32("id_");
                dto.IdCompra = reader.GetInt32("id_compra");
                dto.QTDestocada = reader.GetInt32("qtd_estocado");
                dto.QTDMinima = reader.GetInt32("qtd_minima");
                dto.NomeProduto = reader.GetString("nm_produto");

                produto.Add(dto);


            }
            reader.Close();
            return produto;
        }
        public List<EstoqueDTO> Consultar(string nome)
        {
            string script = @"SELECT * FROM tb_estoque WHERE nm_produto LIKE @nm_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EstoqueDTO> produto = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.Id = reader.GetInt32("id_estoque");
                dto.NomeProduto = reader.GetString("nm_nome");


                produto.Add(dto);



            }
            reader.Close();
            return produto;





        }
    }
}
