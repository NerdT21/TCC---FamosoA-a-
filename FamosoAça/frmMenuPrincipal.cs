using FamosoAça.Classes.Login;
//using FamosoAça.Consultar;
using FamosoAça.Login;
using FamosoAça.Screens;
using FamosoAça.Screens.Entregavel_I;
using FamosoAça.Screens.Entregavel_I.Controle_de_Funcionários;
using FamosoAça.Screens.Entregavel_I.Departamentos;
using FamosoAça.Screens.Entregavel_II.Controle_De_Compras;
using FamosoAça.Screens.Entregavel_II.Controle_De_Fornecedores;
using FamosoAça.Screens.Entregavel_II.Controle_De_Produto;
using FamosoAça.Screens.Entregavel_III.ConsultarVenda;
using FamosoAça.Screens.Entregavel_III.Item;
using FamosoAça.Screens.Entregavel_IV.Estoque;
using FamosoAça.Screens.Entregavel_IV.Gastos_Adicionais;
using FamosoAça.Screens.Entregavel_IV.Gatos_Adicionais;
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
            frmRegistrarItem frm = new frmRegistrarItem();
            OpenScreen(frm);
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Screens.Entregavel_II.Controle_De_Fornecedores.frmConsultarFornecedores frm = new Screens.Entregavel_II.Controle_De_Fornecedores.frmConsultarFornecedores();
            OpenScreen(frm);
        }

        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Screens.Entregavel_II.Controle_De_Produto.frmConsultarProduto frm = new Screens.Entregavel_II.Controle_De_Produto.frmConsultarProduto();
            OpenScreen(frm);
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmConsultarItem frm = new frmConsultarItem();
            OpenScreen(frm);
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque frm = new Estoque();
            OpenScreen(frm);
        }

      
          

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frm = new frmVenda();
            OpenScreen(frm);
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultarVenda frm = new FrmConsultarVenda();
            OpenScreen(frm);
        }

        private void verComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void gastosAdicionaisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void gastosAdicionaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarGastosAdicionais frm = new ConsultarGastosAdicionais();
            OpenScreen(frm);
        }

        private void gastosAdicionaisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmGastosAdicionais frm = new frmGastosAdicionais();
            OpenScreen(frm);
        }

        private void gastosAdicionaisToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ConsultarGastosAdicionais frm = new ConsultarGastosAdicionais();
            OpenScreen(frm);
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
