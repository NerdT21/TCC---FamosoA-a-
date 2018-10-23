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
        void MandarProCarrinho(string item, string qtd, string preco)
        {
            List<string> addCarrinho = new List<string>();
            addCarrinho.Add(item + ", " + qtd + ", " + preco);

            foreach (string i in addCarrinho)
            {
                lbxCarrinho.Text = i;
            }
        }

      


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProdutoDTO cbo = cboNome.SelectedItem as ProdutoDTO;

            VendaDTO dto = new VendaDTO();
            dto.IdProduto = cbo.Id;
            dto.Quantidade = Convert.ToInt32(nudQtd.Value);
            dto.DataVenda = mskData.Text;
            dto.ValorVenda = Convert.ToDecimal(txtValorTotal.Text);

            VendaBusiness buss = new VendaBusiness();
            buss.Salvar(dto);

            MessageBox.Show("Venda efetuada!", "Catioro's", MessageBoxButtons.OK);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProdutoDTO dto = cboNome.SelectedItem as ProdutoDTO;

            string item = txtProduto.Text;
            string qtd = nudQtd.Value.ToString();
            string preco = dto.Preco.ToString();

            MandarProCarrinho(item, qtd, preco);
        }
    }
}
