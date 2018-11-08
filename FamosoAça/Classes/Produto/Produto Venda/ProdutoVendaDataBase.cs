using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Produto.Produto_Venda
{
    public class ProdutoVendaDataBase
    {

        public int Salvar(ProdutoVendaDTO dto)
        {

            string script = @"INSERT INTO tb_produtoVenda(id_produto,
                                                          id_venda)
                                                   VALUES(@id_produto,
                                                          @id_venda) ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto",dto.IdProduto));
            parms.Add(new MySqlParameter("id_venda",dto.IdVenda));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script,parms);

        }

    }
}
