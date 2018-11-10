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
            ProdutoBusiness buss = new ProdutoBusiness();
            List<ProdutoDTO> lista = buss.Listar();

            dgvProduto.DataSource = lista;
        }

        void CarregarGrid()
        {
            string nome = txtNome.Text;
            string marca = txtMarca.Text;

            ProdutoBusiness buss = new ProdutoBusiness();
            List<ProdutoDTO> lista = buss.Consultar(nome, marca);

            dgvProduto.DataSource = lista;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
