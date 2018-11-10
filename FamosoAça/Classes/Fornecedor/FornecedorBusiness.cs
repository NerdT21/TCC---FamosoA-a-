using FamosoAça.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Fornecedor
{
    public class FornecedorBusiness
    {
        public int Salvar(FornecedorDTO forncedor)
        {
            //=========================NOME==============================

            string nome = forncedor.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 200)
            {
                throw new ValidacaoException("Nome do fornecedor não pode passar de 200 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("Nome do fornecedor não pode ser nulo.");
            }

            //=========================Email==============================

            string email = forncedor.Email;
            email = email.Trim();
            int qtdEmail = email.Count();

            if (qtdEmail > 100)
            {
                throw new ValidacaoException("Email não pode passar de 100 caracteres.");
            }
            else if (qtdEmail == 0)
            {
                throw new ValidacaoException("Email é obrigatório.");
            }

            Validacoes.ValidarEmail validacaoEmail = new Validacoes.ValidarEmail();
            bool e = validacaoEmail.VerificarEmail(email);

            if (e == false)
            {
                throw new ValidacaoException("Email inválido.");
            }

            //=========================CNPJ==============================

            string cnpj = forncedor.CNPJ;
            Validacoes.ValidarCPF_CNPJ validCnpj = new Validacoes.ValidarCPF_CNPJ();
            bool c = validCnpj.VerificaCpfCnpj(cnpj);

            if (cnpj == "  .   .   /    -")
            {
                throw new ValidacaoException("CNPJ é obrigatório.");
            }
            else if (c == false)
            {
                throw new ValidacaoException("CNPJ inválido.");
            }

            //=========================TELEFONE==============================

            string telefone = forncedor.Telefone;
            Validacoes.ValidarTelefone validTelefone = new Validacoes.ValidarTelefone();
            bool t = validTelefone.VerificarTelefone(telefone);

            if (t == false)
            {
                throw new ValidacaoException("Telefone inválido");
            }

            // ============================ CIDADE =============================

            string cidade = forncedor.Cidade;
            cidade = cidade.Trim();
            int qtdCidade = cidade.Count();

            if (qtdCidade > 50)
            {
                throw new ValidacaoException("O campo 'Cidade' não pode possuir mais de 50 caracteres.");
            }
            else if (qtdCidade == 0)
            {
                throw new ValidacaoException("O campo 'Cidade' é obrigatório.");
            }

            // ============================ RUA ===============================

            string rua = forncedor.Rua;
            rua = rua.Trim();
            int qtdRua = rua.Count();

            if (qtdRua > 200)
            {
                throw new ValidacaoException("O campo 'Rua' não pode possuir mais de 200 caracteres.");
            }
            else if (qtdRua == 0)
            {
                throw new ValidacaoException("O campo 'Rua' é obrigatório.");
            }


            FornecedorDataBase DB = new FornecedorDataBase();
            int id = DB.Salvar(forncedor);
            return id;
        }

        public void Alterar(FornecedorDTO forncedor)
        {
            //=========================NOME==============================

            string nome = forncedor.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 200)
            {
                throw new ValidacaoException("Nome do fornecedor não pode passar de 200 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("Nome do fornecedor não pode ser nulo.");
            }

            //=========================Email==============================

            string email = forncedor.Email;
            email = email.Trim();
            int qtdEmail = email.Count();

            if (qtdEmail > 100)
            {
                throw new ValidacaoException("Email não pode passar de 100 caracteres.");
            }
            else if (qtdEmail == 0)
            {
                throw new ValidacaoException("Email é obrigatório.");
            }

            Validacoes.ValidarEmail validacaoEmail = new Validacoes.ValidarEmail();
            bool e = validacaoEmail.VerificarEmail(email);

            if (e == false)
            {
                throw new ValidacaoException("Email inválido.");
            }

            //=========================CNPJ==============================

            string cnpj = forncedor.CNPJ;
            Validacoes.ValidarCPF_CNPJ validCnpj = new Validacoes.ValidarCPF_CNPJ();
            bool c = validCnpj.VerificaCpfCnpj(cnpj);

            if (cnpj == "  .   .   /    -")
            {
                throw new ValidacaoException("CNPJ é obrigatório.");
            }
            else if (c == false)
            {
                throw new ValidacaoException("CNPJ inválido.");
            }

            //=========================TELEFONE==============================

            string telefone = forncedor.Telefone;
            Validacoes.ValidarTelefone validTelefone = new Validacoes.ValidarTelefone();
            bool t = validTelefone.VerificarTelefone(telefone);

            if (t == false)
            {
                throw new ValidacaoException("Telefone inválido");
            }

            // ============================ CIDADE =============================

            string cidade = forncedor.Cidade;
            cidade = cidade.Trim();
            int qtdCidade = cidade.Count();

            if (qtdCidade > 50)
            {
                throw new ValidacaoException("O campo 'Cidade' não pode possuir mais de 50 caracteres.");
            }
            else if (qtdCidade == 0)
            {
                throw new ValidacaoException("O campo 'Cidade' é obrigatório.");
            }

            // ============================ RUA ===============================

            string rua = forncedor.Rua;
            rua = rua.Trim();
            int qtdRua = rua.Count();

            if (qtdRua > 200)
            {
                throw new ValidacaoException("O campo 'Rua' não pode possuir mais de 200 caracteres.");
            }
            else if (qtdRua == 0)
            {
                throw new ValidacaoException("O campo 'Rua' é obrigatório.");
            }


            FornecedorDataBase DB = new FornecedorDataBase();
            DB.Alterar(forncedor);
        }

        public void Remover(int idforncedor)
        {
            FornecedorDataBase DB = new FornecedorDataBase();
            DB.Remover(idforncedor);
        }

        public FornecedorDTO Listar()
        {
            FornecedorDataBase DB = new FornecedorDataBase();
            return DB.Listar();
        }

        public List<FornecedorView> Consultar(string nome, string cidade)
        {
            FornecedorDataBase db = new FornecedorDataBase();
            return db.Consultar(nome, cidade);
        }

        public List<FornecedorView> ListarPraGrid()
        {
            FornecedorDataBase db = new FornecedorDataBase();
            return db.ListarPraGrid();
        }

        public List<FornecedorDTO> ListarPraCombo()
        {
            FornecedorDataBase db = new FornecedorDataBase();
            return db.ListarPraCombo();
        }
    }
}
