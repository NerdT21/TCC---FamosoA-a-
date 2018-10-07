using FamosoAça.Classes.Login;
using FamosoAça.Consultar;
using FamosoAça.Login;
using FamosoAça.Screens.Entregavel_I;
using FamosoAça.Screens.Entregavel_I.Controle_de_Funcionários;
using FamosoAça.Screens.Entregavel_I.Departamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamosoAça
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            Permissoes();
        }

        public void OpenScreen(UserControl control)
        {
            if (pnlScreen.Controls.Count == 1)
            {
                pnlScreen.Controls.RemoveAt(0);
            }
            pnlScreen.Controls.Add(control);
        }

        void Permissoes()
        {
            if (UserSession.UsuarioLogado.Adm == false)
            {
                if (UserSession.UsuarioLogado.Cadastro == false)
                {
                    cadastroToolStripMenuItem.Visible = false;
                }

                if (UserSession.UsuarioLogado.Consulta == false)
                {
                    consultaToolStripMenuItem.Visible = false;
                }

                if (UserSession.UsuarioLogado.Contabilidade == false)
                {
                    finançasToolStripMenuItem.Visible = false;
                }
            }
        }
    
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void funcionárisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario tela = new frmCadastrarFuncionario();
            OpenScreen(tela);
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarFuncionarios tela = new frmListarFuncionarios();
            OpenScreen(tela);
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFolhaPagto tela = new frmFolhaPagto();
            OpenScreen(tela);
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogin tela = new frmLogin();
            tela.Show();
            this.Close();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento tela = new frmDepartamento();
            OpenScreen(tela);
        }

        private void finançasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
