using FamosoAça.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Gatos_Adicionais
{
    class GastosABusiness
    {
        public int Salvar(GastosADTO dto)
        {
            //---------------------NOME
            string nome = dto.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O nome do gasto não pode passar de 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O nome do gasto é obrigatório.");
            }

            //------------VALOR
            decimal valor = dto.Valor;

            if (valor == 0)
            {
                throw new ValidacaoException("O valor não pode ser zero.");
            }

            //--------------DESCRICAO
            string desc = dto.Descricao;
            desc = desc.Trim();
            int qtdDesc = desc.Count();

            if (qtdDesc > 500)
            {
                throw new ValidacaoException("A descrição não pode passsar de 500 caracteres.");
            }
            else if (qtdDesc == 0)
            {
                throw new ValidacaoException("A descrição é obrigatória.");
            }


            GastosADataBase db = new GastosADataBase();
            return db.Salvar(dto);
        }

        public List<GastosADTO> Listar()
        {
            GastosADataBase db = new GastosADataBase();
            return db.Listar();
        }

        public List<GastosADTO> Consultar(string data)
        {
            GastosADataBase db = new GastosADataBase();
            return db.Consultar(data);
        }

        public void Remover(int pk)
        {
            GastosADataBase db = new GastosADataBase();
            db.Remover(pk);
        }
    }
}
