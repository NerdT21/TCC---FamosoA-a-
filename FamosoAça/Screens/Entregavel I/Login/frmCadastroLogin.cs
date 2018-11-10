using FamosoAça.Classes.Login;
using FamosoAça.CustomExceptions.TelasException;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamosoAça.Login
{
    public partial class frmCadastroLogin : Form
    {
        public frmCadastroLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDTO dto = new LoginDTO();
                dto.Usuario = txtUsuario.Text;
                dto.Funcionario = txtNome.Text;
                dto.Senha = txtSenha.Text;
                dto.PermissaoAdm = ckbAdm.Checked;
                dto.PermissaoCadastros = ckbCadastros.Checked;
                dto.PermissaoCaixa = ckbCaixa.Checked;
                dto.PermissaoEstoque = ckbEstoque.Checked;
                dto.PermissaoFinanceiro = ckbFinanceiro.Checked;

                LoginBusiness business = new LoginBusiness();
                business.Salvar(dto);

                frmMessage tela = new frmMessage();
                tela.LoadScreen("Cadastro efetuado com sucesso.");
                tela.ShowDialog();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    frmAlert tela = new frmAlert();
                    tela.LoadScreen("O nome de usuário já existe.");
                    tela.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmLogin tela = new frmLogin();
            tela.Show();
            this.Close();
        }

        private void ckbAdm_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAdm.Checked == true)
            {
                string msg = "Ao definir esse usuário com permissão ADM, ele terá acesso a todas as funções do sistema." +
                   "\n Deseja mesmo torná-lo ADM?";

                frmQuestion tela = new frmQuestion();
                tela.LoadScreen(msg);
                tela.ShowDialog();

                bool click = tela.BotaoYes;

                if (click == true)
                {
                    ckbCaixa.Checked = true;
                    ckbEstoque.Checked = true;
                    ckbCadastros.Checked = true;
                    ckbFinanceiro.Checked = true;
                    ckbProdutos.Checked = true;
                }                
            }
            else
            {
                ckbCaixa.Checked = true;
                ckbEstoque.Checked = true;
                ckbCadastros.Checked = true;
                ckbFinanceiro.Checked = true;
                ckbProdutos.Checked = true;
            }
        }
    }
}
