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
using FamosoAça.Classes.Venda.ProdutoVendas;

namespace FamosoAça.Screens.Entregavel_III.ConsultarVenda
{
    public partial class FrmConsultarVenda : UserControl
    {
        public FrmConsultarVenda()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            VendaBusiness buss = new VendaBusiness();
            List<ProdutoVendasView> lista = buss.Listar();

            dgvProduto.AutoGenerateColumns = false;
            dgvProduto.DataSource = lista;
        }

        void CarregarGrid()
        {
            string data = mkbData.Text;

            VendaBusiness buss = new VendaBusiness();
            List<ProdutoVendasView> lista = buss.Consultar(data);

            dgvProduto.AutoGenerateColumns = false;
            dgvProduto.DataSource = lista;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception ex)
            {

               MessageBox.Show("Ocorreu um erro: " + ex.Message,"Famoso Açai",MessageBoxButtons.OK);
            } 
        }

        private void FrmConsultarVenda_Load(object sender, EventArgs e)
        {
            //Cabeça da GV
            dgvProduto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvProduto.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            //Fonte
            dgvProduto.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvProduto.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvProduto.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
