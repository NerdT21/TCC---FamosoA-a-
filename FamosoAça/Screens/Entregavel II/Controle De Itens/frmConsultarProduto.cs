using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Venda.Produto;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Produto
{
    public partial class frmConsultarProduto : UserControl
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
            AutoCarregar();
        }


        void AutoCarregar()
        {
            try
            {
                ProdutoBusiness buss = new ProdutoBusiness();
                List<ProdutoDTO> lista = buss.Listar();

                dgvProduto.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
            
        }

        void CarregarGrid()
        {
            try
            {
                string nome = txtNome.Text;
                string marca = txtMarca.Text;

                ProdutoBusiness buss = new ProdutoBusiness();
                List<ProdutoDTO> lista = buss.Consultar(nome, marca);

                dgvProduto.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
          
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
