using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FamosoAça.Classes.Compra.itemCompra
{
    public class ItemCompraDatabase
    {
        public int Salvar(ItemCompraDTO dto)
        {
            string script = @"INSERT INTO tb_item_compra(id_item, id_compra)
                                                  VALUES(@id_item, @id_compra)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_item", dto.IdItem));
            parms.Add(new MySqlParameter("id_compra", dto.IdCompra));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<ItemCompraDTO> Listar()
        {
            string script = @"SELECT * FROM tb_item_compra";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<ItemCompraDTO> lista = new List<ItemCompraDTO>();
            while (reader.Read())
            {
                ItemCompraDTO dto = new ItemCompraDTO();
                dto.Id = reader.GetInt32("id_item_compra");
                dto.IdItem = reader.GetInt32("id_item");
                dto.IdCompra = reader.GetInt32("id_compra");

                lista.Add(dto);
            }

            reader.Close();
            return lista;
        }
    }
}
