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
using FamosoAça.Classes.Venda;

namespace FamosoAça.Screens.Entregavel_III.ConsultarVenda
{
    public partial class frmVenda : UserControl
    {
        public frmVenda()
        {
            InitializeComponent();
        }
      

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProdutoDTO cbo = cboNome.SelectedItem as ProdutoDTO;

            VendaDTO dto = new VendaDTO();
            dto.IdProduto = cboNome.;
            dto.QuantidadeComprada = Convert.ToInt32(nudQtd.Value);
            dto.DataVenda = mskData.Text;
            dto.ValorVenda = Convert.ToDecimal(txtValorTotal.Text);

            CompraBusiness buss = new CompraBusiness();
            buss.Salvar(dto);

            MessageBox.Show("Compra registrada com sucesso!", "Catioro's", MessageBoxButtons.OK);
        }
    }
}
