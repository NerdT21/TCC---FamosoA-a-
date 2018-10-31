using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Item
{
   public class ItemDataBase
    {


        public int Salvar(ItemDTO dto)
        {

            string script = @"INSERT INTO (id_fornecedor,
                                           nm_item,
                                           ds_item,
                                           vl_preco)
                                    VALUES(@id_fornecedor,
                                           @nm_item,
                                           @ds_item,
                                           @vl_preco)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", dto.IdFornecedor));
            parms.Add(new MySqlParameter("nm_item", dto.Nome));
            parms.Add(new MySqlParameter("ds_item", dto.Descricao));
            parms.Add(new MySqlParameter("vl_preco", dto.Preco));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar(ItemDTO dto)
        {

            string script = @"UPDATE SET id_fornecedor = @id_fornecedor,
                                         nm_item = @nm_item,
                                         ds_item = @ds_item,
                                         vl_preco = @vl_preco
                                   WHERE id_item = @id_item";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", dto.IdFornecedor));
            parms.Add(new MySqlParameter("nm_item", dto.Nome));
            parms.Add(new MySqlParameter("ds_item", dto.Descricao));
            parms.Add(new MySqlParameter("vl_preco", dto.Preco));


            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover(int Id)
        {

            string script =
                "DELETE FROM tb_item WHERE id_item = @id_produto";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item", Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<ItemDTO> Listar()
        {

            string script = @"SELECT * FROM tb_item ";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ItemDTO> lista = new List<ItemDTO>();
            while (reader.Read())
            {

                ItemDTO add = new ItemDTO();
                add.Id = reader.GetInt32("id_item");
                add.IdFornecedor = reader.GetInt32("id_fornecedor");
                add.Nome = reader.GetString("nm_item");
                add.Descricao = reader.GetString("ds_item");
                add.Preco = reader.GetDecimal("vl_preco");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }

        public List<ItemDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_item WHERE nm_item LIKE @nm_item";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_item", nome + "%"));
          

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ItemDTO> lista = new List<ItemDTO>();
            while (reader.Read())
            {

                ItemDTO add = new ItemDTO();

                add.Id = reader.GetInt32("id_item");
                add.IdFornecedor = reader.GetInt32("id_fornecedor");
                add.Nome = reader.GetString("nm_item");
                add.Descricao = reader.GetString("ds_item");
                add.Preco = reader.GetDecimal("vl_preco");

                lista.Add(add);
            }

            reader.Close();

            return lista;

        }




    }
}
