using FamosoAça.Classes.Login;
using FamosoAça.CustomExceptions.TelasException;
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
 
        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
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
                frmAlert tela = new frmAlert();
                tela.LoadScreen("Nome de usuário ou senha incorretos.");
                tela.ShowDialog();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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
                frmAlert tela = new frmAlert();
                tela.LoadScreen("É preciso ser um Administraor do sistema para acessar o cadastro de logins.");
                tela.ShowDialog();
            }

        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbxShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void pbxShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btnEntrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                    frmAlert tela = new frmAlert();
                    tela.LoadScreen("Nome de usuário ou senha incorretos.");
                    tela.ShowDialog();
                }
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                    frmAlert tela = new frmAlert();
                    tela.LoadScreen("Nome de usuário ou senha incorretos.");
                    tela.ShowDialog(); MessageBox.Show("Nome de usuário ou senha incorretos.");
                }
            }
        }
    }
}
