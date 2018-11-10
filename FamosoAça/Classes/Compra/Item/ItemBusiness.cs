using FamosoAça.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Compra.Item
{
    public class ItemBusiness
    {
        public int Salvar(ItemDTO dto)
        {
            //========================NOME============================

            string nome = dto.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O nome do produto não pode passar de 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O nome do produto não pode estar vazio.");
            }

            //=======================PREÇO============================

            decimal preco = dto.Preco;

            if (preco == 0)
            {
                throw new ValidacaoException("O preço do produto não pode ser zero.");
            }

            //======================DESCRIÇÃO=========================

            string descricao = dto.Descricao;
            descricao = descricao.Trim();
            int qtdDescricao = descricao.Count();

            if (qtdDescricao > 300)
            {
                throw new ValidacaoException("A descrição do produto não pode passar de 300 caracteres.");
            }
            if (qtdDescricao == 0)
            {
                throw new ValidacaoException("O produto precisa ter uma descrição.");
            }

            ItemDatabase db = new ItemDatabase();
            return db.Salvar(dto);
        }

        public void Alterar(ItemDTO dto)
        {
            //========================NOME============================

            string nome = dto.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O nome do produto não pode passar de 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O nome do produto não pode estar vazio.");
            }

            //=======================PREÇO============================

            decimal preco = dto.Preco;

            if (preco == 0)
            {
                throw new ValidacaoException("O preço do produto não pode ser zero.");
            }

            //======================DESCRIÇÃO=========================

            string descricao = dto.Descricao;
            descricao = descricao.Trim();
            int qtdDescricao = descricao.Count();

            if (qtdDescricao > 300)
            {
                throw new ValidacaoException("A descrição do produto não pode passar de 300 caracteres.");
            }
            if (qtdDescricao == 0)
            {
                throw new ValidacaoException("O produto precisa ter uma descrição.");
            }


            ItemDatabase db = new ItemDatabase();
            db.Alterar(dto);
        }

        public List<ItemView> Listar()
        {
            ItemDatabase db = new ItemDatabase();
            return db.Listar();
        }

        public List<ItemView> Consultar(string nome, string fornecedor)
        {
            ItemDatabase db = new ItemDatabase();
            return db.Consultar(nome, fornecedor);
        }

        public ItemDTO ConsultarProTxt(string nome, int fornecedor)
        {
            ItemDatabase db = new ItemDatabase();
            return db.ConsultarProTxt(nome, fornecedor);
        }

    }
}
