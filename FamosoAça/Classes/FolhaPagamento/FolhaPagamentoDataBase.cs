using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FamosoAça.Classes.FolhaPagamento
{
    public class FolhaPagamentoDataBase
    {
        public int Salvar(FolhaPagamentoDTO folha)
        {

            string script = @"INSERT INTO tb_folhaDePagamento(ds_horasExtras,
                                                                id_funcionario
                                                                int_faltas,
                                                                vl_salarioBruto,
                                                                vl_impostoDeRenda,
                                                                vl_ftgs,
                                                                vl_valeTransporte,
                                                                id_funcionario,
                                                                vl_salarioLiq,
                                                                vl_inss,
                                                                vl_salFamilia,
                                                                dt_pagamento)
                                                        VALUES (@ds_horasExtras,
                                                                @id_funcionario,
                                                                @int_faltas,
                                                                @vl_salarioBruto,
                                                                @vl_impostoDeRenda,
                                                                @vl_ftgs,
                                                                @vl_valeTransporte,
                                                                @id_funcionario,
                                                                @vl_salarioLiq,
                                                                @vl_inss,
                                                                @vl_salFamilia,
                                                                @dt_pagamento)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_horasExtras", folha.HorasExtras));
            parms.Add(new MySqlParameter("id_funcionario", folha.IdFuncio));
            parms.Add(new MySqlParameter("int_faltas", folha.Faltas));
            parms.Add(new MySqlParameter("vl_salarioBruto", folha.SalBruto));
            parms.Add(new MySqlParameter("vl_impostoDeRenda", folha.ImpostoRenda));
            parms.Add(new MySqlParameter("vl_ftgs", folha.Fgts));
            parms.Add(new MySqlParameter("vl_valeTransporte", folha.VLTars));
            parms.Add(new MySqlParameter("id_funcionario", folha.IdFuncio));
            parms.Add(new MySqlParameter("vl_salarioLiq", folha.SalLiq));
            parms.Add(new MySqlParameter("vl_inss", folha.Inss));
            parms.Add(new MySqlParameter("vl_salFamilia", folha.SalFamilia));
            parms.Add(new MySqlParameter("dt_pagamento", folha.Data));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Remover(int IdFolha)
        {

            string script =
                "DELETE FROM tb_folhaDePagamento  WHERE id_folha_pag = @id_folha_pag";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folha_pag", IdFolha));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<FolhaPagamentoDTO> Listar()
        {
            string script = @"SELECT * FROM tb_folhaDePagamento";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FolhaPagamentoDTO> folhaL = new List<FolhaPagamentoDTO>();
            while (reader.Read())
            {
                FolhaPagamentoDTO folha = new FolhaPagamentoDTO();
                folha.Id = reader.GetInt32("id_folhaPagto");
                folha.HorasExtras = reader.GetString("ds_horasExtras");
                folha.Faltas = reader.GetInt32("int_faltas");
                folha.SalBruto = reader.GetDecimal("vl_salarioBruto");
                folha.ImpostoRenda = reader.GetDecimal("vl_impostoDeRenda");
                folha.Fgts = reader.GetDecimal("vl_ftgs");
                folha.VLTars = reader.GetDecimal("vl_valeTransporte");
                folha.IdFuncio = reader.GetInt32("id_funcionario");
                folha.SalLiq = reader.GetDecimal("vl_salarioLiq");
                folha.Inss = reader.GetInt32("vl_inss");
                folha.SalFamilia = reader.GetInt32("vl_salFamilia");
                folha.Data = reader.GetString("dt_pagamento");

                folhaL.Add(folha);
            }
            reader.Close();
            return folhaL;
        }

        public List<FolhaPagamentoDTO> Consultar(string nome)
        {
            string script = @"SELECT * FROM tb_folhaDePagamento WHERE id_funcionario LIKE @id_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FolhaPagamentoDTO> folhaL = new List<FolhaPagamentoDTO>();
            while (reader.Read())
            {
                FolhaPagamentoDTO folha = new FolhaPagamentoDTO();
                folha.Id = reader.GetInt32("id_folhaPagto");
                folha.HorasExtras = reader.GetString("ds_horasExtras");
                folha.Faltas = reader.GetInt32("int_faltas");
                folha.SalBruto = reader.GetDecimal("vl_salarioBruto");
                folha.ImpostoRenda = reader.GetDecimal("vl_impostoDeRenda");
                folha.Fgts = reader.GetDecimal("vl_ftgs");
                folha.VLTars = reader.GetDecimal("vl_valeTransporte");
                folha.IdFuncio = reader.GetInt32("id_funcionario");
                folha.SalLiq = reader.GetDecimal("vl_salarioLiq");
                folha.Inss = reader.GetInt32("vl_inss");
                folha.SalFamilia = reader.GetInt32("vl_salFamilia");
                folha.Data = reader.GetString("dt_pagamento");

                folhaL.Add(folha);
            }
            reader.Close();
            return folhaL;
        }

    }
}
