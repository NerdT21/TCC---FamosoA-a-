using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Venda;
using FamosoAça.Classes.Produto;

namespace FamosoAça.Screens.Entregavel_III.ConsultarVenda
{
    public partial class FrmConsultarVenda : UserControl
    {
        public FrmConsultarVenda()
        {
            InitializeComponent();
            CarregarCombos();
        }
        void CarregarCombos()
        {
            ProdutoBusiness buss = new ProdutoBusiness();
            List<ProdutoDTO> dto = buss.Listar();

            cboNome.ValueMember = nameof(ProdutoDTO.Id);
            cboNome.DisplayMember = nameof(ProdutoDTO.Nome);
            cboNome.DataSource = dto;
        }
        void CarregarGrid()
        {
            string produto = cboNome.Text;

            VendaBusiness buss = new VendaBusiness();
            List<VendaDTO> dto = buss.Consultar(produto);

            dgvProduto.AutoGenerateColumns = false;
            dgvProduto.DataSource = dto;

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
