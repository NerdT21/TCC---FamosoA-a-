using FamosoAça.Classes.Login;
using FamosoAça.Consultar;
using FamosoAça.Login;
using FamosoAça.Screens;
using FamosoAça.Screens.Entregavel_I;
using FamosoAça.Screens.Entregavel_I.Controle_de_Funcionários;
using FamosoAça.Screens.Entregavel_I.Departamentos;
using FamosoAça.Screens.Entregavel_II.Controle_De_Compras;
using FamosoAça.Screens.Entregavel_II.Controle_De_Fornecedores;
using FamosoAça.Screens.Entregavel_II.Controle_De_Produto;
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
            frmHome t = new frmHome();
            OpenScreen(t);
        }

        public void OpenScreen(UserControl control)
        {
            if (pnlCentro.Controls.Count == 1)
            {
                pnlCentro.Controls.RemoveAt(0);
            }
            pnlCentro.Controls.Add(control);
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

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario tela = new frmCadastrarFuncionario();
            OpenScreen(tela);
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarFuncionarios tela = new frmListarFuncionarios();
            OpenScreen(tela);
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento TELA = new frmDepartamento();
            OpenScreen(TELA);
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

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool mover;
        private int cX, cY;

        private void pnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - pnlBarra.Left);
                this.Top += e.Y - (cY - pnlBarra.Top);
            }
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome tela = new frmHome();
            OpenScreen(tela);
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras tela = new frmCompras();
            OpenScreen(tela);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto frm = new frmCadastrarProduto();
            OpenScreen(frm);
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastrarFornecedor frm = new frmCadastrarFornecedor();
            OpenScreen(frm);
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor frm = new frmConsultaFornecedor();
            OpenScreen(frm);
        }

        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Screens.Entregavel_II.Controle_De_Produto.frmConsultarProduto frm = new Screens.Entregavel_II.Controle_De_Produto.frmConsultarProduto();
            OpenScreen(frm);
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnlBarra_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mover = false;
            }
        }
    }
}
