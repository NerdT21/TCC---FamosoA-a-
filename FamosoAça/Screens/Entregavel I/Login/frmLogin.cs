using FamosoAça.Classes.Login;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginBusiness business = new LoginBusiness();
            string user = txtUser.Text;
            string pass = txtPass.Text;

            LoginDTO usuario = business.Logar(user, pass);


            if (usuario != null)
            {
                UserSession.UsuarioLogado = usuario;

                frmMenuPrincipal tela = new frmMenuPrincipal();
                tela.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos.");
            }
        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {

            LoginBusiness business = new LoginBusiness();
            string user = txtUser.Text;
            string pass = txtPass.Text;

            LoginDTO usuario = business.Logar(user, pass);


            if (usuario != null)
            {
                UserSession.UsuarioLogado = usuario;

                frmCadastroLogin tela = new frmCadastroLogin();
                tela.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("É preciso ser um Administraor do sistema para acessar o cadastro de logins.");
            }
           
        }
    }
}
