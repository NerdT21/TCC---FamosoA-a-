using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Venda.ProdutoVendas
{
    public class ProdutoVendasDatabase
    {
        public int Salvar(ProdutoVendasDTO dto)
        {
            string script = @"INSERT INTO tb_produtoVenda(id_produto, id_venda)
                                                   VALUES(@id_produto, @id_venda)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", dto.ProdutoId));
            parms.Add(new MySqlParameter("id_venda", dto.VendaId));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
    }
}
