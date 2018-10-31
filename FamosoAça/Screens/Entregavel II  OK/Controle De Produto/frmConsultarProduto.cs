using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Produto;

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Produto
{
    public partial class frmConsultarProduto : UserControl
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
            Carregar();
        }

        void Carregar()
        {
            ProdutoBusiness buss = new ProdutoBusiness();
            List<ProdutoDTO> list = buss.Listar();

            dgvProduto.DataSource = list;
        } 

        void CarregarGrid()
        {
            string nome = txtNome.Text;


            ProdutoBusiness buss = new ProdutoBusiness();
            List<ProdutoDTO> lista = buss.Consultar(nome);
        }
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
