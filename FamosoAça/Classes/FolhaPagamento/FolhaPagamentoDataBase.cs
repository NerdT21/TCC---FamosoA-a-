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
        public int Salvar(FolhaPagamentoDTO dto)
        {
            string script = @"INSERT INTO tb_folha_pagamento (
                            id_funcionario,
                            id_inss,
                            ds_horas_extras,
                            int_faltas,
                            ds_atraso,
                            id_imposto_renda,
                            vl_imposto_de_renda,
                            vl_fgts,
                            vl_vale_transporte,
                            vl_salario_liq,
                            id_sal_familia) VALUES(
                            @id_funcionario,
                            @id_inss,
                            @ds_horas_extras,
                            @int_faltas,
                            @ds_atraso,
                            @id_imposto_renda,
                            @vl_imposto_de_renda,
                            @vl_fgts,
                            @vl_vale_transporte,
                            @vl_salario_liq,
                            @id_sal_familia)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", dto.IdFuncinario));
            parms.Add(new MySqlParameter("id_inss", dto.IdINSS));
            parms.Add(new MySqlParameter("ds_horas_extras", dto.HoraExtra));
            parms.Add(new MySqlParameter("int_faltas", dto.Faltas));
            parms.Add(new MySqlParameter("ds_atraso", dto.Atraso));
            parms.Add(new MySqlParameter("id_imposto_renda", dto.IdImpostoRenda));
            parms.Add(new MySqlParameter("vl_fgts", dto.FGTS));
            parms.Add(new MySqlParameter("vl_vale_transporte", dto.ValeTransporte));
            parms.Add(new MySqlParameter("vl_salario_liq", dto.SalarioLiq));
            parms.Add(new MySqlParameter("id_sal_familia", dto.IdSalarioFamilia));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);

        }


    }
}
