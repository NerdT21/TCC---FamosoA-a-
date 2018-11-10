using FamosoAça.CustomExceptions;
using FamosoAça.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Funcionarios
{
    public class FuncionariosBusiness
    {
        public int Salvar(FuncionarioDTO funcionario)
        {
            // ============================ NOME =============================

            string nome = funcionario.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O campo 'Nome' não pode ultrapassar 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O campo 'Nome' não pode estar vazio.");
            }
            // ============================ SALARIO =============================

            decimal salario = funcionario.Salario;
            string txtSalario = salario.ToString();

            if (txtSalario == string.Empty)
            {
                throw new ValidacaoException("O campo 'Salário' deve ser definido.");
            }
            else if (salario == 0.00m)
            {
                throw new ValidacaoException("O campo 'Salário' não pode ser zero");
            }

            // ============================ CIDADE =============================

            string cidade = funcionario.Cidade;
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

            string rua = funcionario.Rua;
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

            // ============================ CEP ==============================

            if (funcionario.Cep == "     -")
            {
                throw new ValidacaoException("O campo 'CEP' é obrigatório.");
            }

            // ============================ EMAIL =============================

            string email = funcionario.Email;
            email = email.Trim();
            int qtdEmail = email.Count();

            ValidarEmail validEmail = new ValidarEmail();
            bool e = validEmail.VerificarEmail(email);
            if (e == false)
            {
                throw new ValidacaoException("Email inválido.");
            }
            else if (qtdEmail == 0)
            {
                throw new ValidacaoException("O campo 'Email' é obrigatório.");
            }

            // ============================ CPF =============================

            string cpf = funcionario.Cpf;

            ValidarCPF_CNPJ validCpf = new ValidarCPF_CNPJ();
            bool c = validCpf.VerificaCpfCnpj(cpf);

            if (cpf == "   ,   ,   -")
            {
                throw new ValidacaoException("O campo 'CPF' é obrigatório.");
            }
            else if (c == false)
            {
                throw new ValidacaoException("CPF inválido.");
            }

            // ============================ RG =============================

            string rg = funcionario.Rg;

            if (rg == "  ,   ,   -")
            {
                throw new ValidacaoException("O campo 'RG' é obrigatório.");
            }

            // ============================ TELEFONE =============================

            string telefone = funcionario.Telefone;

            ValidarTelefone validTell = new ValidarTelefone();
            bool t = validTell.VerificarTelefone(telefone);

            if (t == false)
            {
                throw new ValidacaoException("Telefone inválido");
            }

            // ============================ NUMERO =============================

            string numero = funcionario.Numero;
            numero = numero.Trim();
            int qtdNumero = numero.Count();

            if (qtdNumero > 6)
            {
                throw new ValidacaoException("O número informado é muito grande.");
            }


            FuncionarioDataBase DB = new FuncionarioDataBase();
            return DB.Salvar(funcionario);
        }

        public void Alterar(FuncionarioDTO funcionario)
        {
            // ============================ NOME =============================

            string nome = funcionario.Nome;
            nome = nome.Trim();
            int qtdNome = nome.Count();

            if (qtdNome > 50)
            {
                throw new ValidacaoException("O campo 'Nome' não pode ultrapassar 50 caracteres.");
            }
            else if (qtdNome == 0)
            {
                throw new ValidacaoException("O campo 'Nome' não pode estar vazio.");
            }
            // ============================ SALARIO =============================

            decimal salario = funcionario.Salario;
            string txtSalario = salario.ToString();

            if (txtSalario == string.Empty)
            {
                throw new ValidacaoException("O campo 'Salário' deve ser definido.");
            }

            // ============================ CIDADE =============================

            string cidade = funcionario.Cidade;
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

            string rua = funcionario.Rua;
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

            // ============================ CEP ==============================

            if (funcionario.Cep == "     -")
            {
                throw new ValidacaoException("O campo 'CEP' é obrigatório.");
            }

            // ============================ EMAIL =============================

            string email = funcionario.Email;
            email = email.Trim();
            int qtdEmail = email.Count();

            ValidarEmail validEmail = new ValidarEmail();
            bool e = validEmail.VerificarEmail(email);
            if (e == false)
            {
                throw new ValidacaoException("Email inválido.");
            }
            else if (qtdEmail == 0)
            {
                throw new ValidacaoException("O campo 'Email' é obrigatório.");
            }

            // ============================ CPF =============================

            string cpf = funcionario.Cpf;

            ValidarCPF_CNPJ validCpf = new ValidarCPF_CNPJ();
            bool c = validCpf.VerificaCpfCnpj(cpf);

            if (cpf == "   ,   ,   -")
            {
                throw new ValidacaoException("O campo 'CPF' é obrigatório.");
            }
            else if (c == false)
            {
                throw new ValidacaoException("CPF inválido.");
            }

            // ============================ RG =============================

            string rg = funcionario.Rg;

            if (rg == "  ,   ,   -")
            {
                throw new ValidacaoException("O campo 'RG' é obrigatório.");
            }

            // ============================ TELEFONE =============================

            string telefone = funcionario.Telefone;

            ValidarTelefone validTell = new ValidarTelefone();
            bool t = validTell.VerificarTelefone(telefone);

            if (t == false)
            {
                throw new ValidacaoException("Telefone inválido");
            }

            // ============================ NUMERO =============================

            string numero = funcionario.Numero;
            numero = numero.Trim();
            int qtdNumero = numero.Count();

            if (qtdNumero > 6)
            {
                throw new ValidacaoException("O número informado é muito grande.");
            }


            FuncionarioDataBase DB = new FuncionarioDataBase();
            DB.Alterar(funcionario);
        }

        public void Remover(int idfuncionario)
        {
            FuncionarioDataBase DB = new FuncionarioDataBase();
            DB.Remover(idfuncionario);
        }

        public List<ViewFuncionario> Listar()
        {
            FuncionarioDataBase DB = new FuncionarioDataBase();
            List<ViewFuncionario> funcionario = DB.Listar();
            return funcionario;
        }

        public List<ViewFuncionario> Consultar(string nome, string cpf)
        {
            FuncionarioDataBase db = new FuncionarioDataBase();
            return db.Consultar(nome, cpf);
        }
    }
}


