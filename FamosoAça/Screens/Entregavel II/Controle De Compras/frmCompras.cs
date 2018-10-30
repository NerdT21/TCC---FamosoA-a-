using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Compra.Item;
using FamosoAça.Classes.Compra;

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Compras
{
    public partial class frmCompras : UserControl
    {
        public frmCompras()
        {
            InitializeComponent();
            CarregarData();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            ItemBusiness buss = new ItemBusiness();
            List<ItemDTO> dto = buss.Listar();

            cboItem.ValueMember = nameof(ItemDTO.Id);
            cboItem.DisplayMember = nameof(ItemDTO.Nome);
            cboItem.DataSource = dto;
        }

        void CarregarData()
        {
            DateTime ano = DateTime.Now;
            DateTime data = ano.Date;
            string soData = data.ToString();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ItemDTO dto = cboItem.SelectedItem as ItemDTO;

            string item = txtItem.Text;
            string qtd = nudQtd.Value.ToString();
            string preco = dto.Preco.ToString();

            MandarProCarrinho(item, qtd, preco);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ItemDTO item = cboItem.SelectedItem as ItemDTO;

            CompraDTO dto = new CompraDTO();
            dto.IdItem = item.Id;
            dto.QuantidadeComprada = Convert.ToInt32(nudQtd.Value);
            dto.DataCompra = mkbData.Text;
            dto.Preco = Convert.ToDecimal(txtValorTotal.Text);

            CompraBusiness buss = new CompraBusiness();
            buss.Salvar(dto);

            MessageBox.Show("Compra registrada com sucesso!", "Catioro's", MessageBoxButtons.OK);
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemDTO item = cboItem.SelectedItem as ItemDTO;

            txtItem.Text = item.Nome;
            txtFornecedor.Text = item.IdFornecedor.ToString();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
