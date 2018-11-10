using FamosoAça.Classes.Login;
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

                MessageBox.Show("Cadastro efetuado com sucesso.", "FamosoAçaí", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("O nome de usuário já existe.", "FamosoAçaí", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FamosoAçaí", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ckbCaixa.Checked = true;
                ckbEstoque.Checked = true;
            }
            else if (ckbEstoque.Checked == false)
            {
                ckbCaixa.Checked = false;
                ckbEstoque.Checked = false;
            }
        }
    }
}
