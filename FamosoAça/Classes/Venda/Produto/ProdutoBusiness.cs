using FamosoAça.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Venda.Produto
{
    public class ProdutoBusiness
    {
        public int Salvar(ProdutoDTO dto)
        {
            //----------------NOME-----------------
            string nome = dto.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O nome do produto não pode passar de 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O nome do produto é obrigatório.");
            }

            //------------MARCA----------------
            string marca = dto.Marca;
            marca = marca.Trim();
            int qtdMarca = marca.Count();

            if (qtdMarca > 100)
            {
                throw new ValidacaoException("A marca não pode passar de 50 caracteres.");
            }
            else if (qtdMarca == 0)
            {
                throw new ValidacaoException("Marca é obrigatória.");
            }

            //----------DESCRICAO---------------
            string desc = dto.Descricao;
            desc = desc.Trim();
            int qtdDesc = desc.Count();

            if (qtdDesc > 300)
            {
                throw new ValidacaoException("A descrição não pode passar de 300 caracteres.");
            }
            else if (qtdDesc == 0)
            {
                throw new ValidacaoException("A descrição é obrigatória.");
            }

            //----------------PREÇO----------------
            decimal preco = dto.Preco;

            if (preco == 0)
            {
                throw new ValidacaoException("O preço não pode ser zero.");
            }

            ProdutoDatabase db = new ProdutoDatabase();
            return db.Salvar(dto);
        }

        public void Alterar(ProdutoDTO dto)
        {
            //----------------NOME-----------------
            string nome = dto.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O nome do produto não pode passar de 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O nome do produto é obrigatório.");
            }

            //------------MARCA----------------
            string marca = dto.Marca;
            marca = marca.Trim();
            int qtdMarca = marca.Count();

            if (qtdMarca > 100)
            {
                throw new ValidacaoException("A marca não pode passar de 50 caracteres.");
            }
            else if (qtdMarca == 0)
            {
                throw new ValidacaoException("Marca é obrigatória.");
            }

            //----------DESCRICAO---------------
            string desc = dto.Descricao;
            desc = desc.Trim();
            int qtdDesc = desc.Count();

            if (qtdDesc > 300)
            {
                throw new ValidacaoException("A descrição não pode passar de 300 caracteres.");
            }
            else if (qtdDesc == 0)
            {
                throw new ValidacaoException("A descrição é obrigatória.");
            }

            //----------------PREÇO----------------
            decimal preco = dto.Preco;

            if (preco == 0)
            {
                throw new ValidacaoException("O preço não pode ser zero.");
            }

            ProdutoDatabase db = new ProdutoDatabase();
            db.Alterar(dto);
        }

        public List<ProdutoDTO> Listar()
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Listar();
        }

        public List<ProdutoDTO> Consultar(string nome, string marca)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Consultar(nome, marca);
        }

    }
}
