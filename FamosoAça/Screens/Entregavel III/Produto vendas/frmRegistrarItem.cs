using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Fornecedor;
using FamosoAça.Classes.Compra.Item;
using FamosoAça.Classes.Venda.Produto;
using FamosoAça.Classes.Estoque;

namespace FamosoAça.Screens.Entregavel_III.Item
{
    public partial class frmRegistrarItem : UserControl
    {
        public frmRegistrarItem()
        {
            InitializeComponent();
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCadatrar_Click(object sender, EventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();
            dto.Nome = txtNome.Text;
            dto.Marca = txtMarca.Text;
            dto.Descricao = txtDesc.Text;
            dto.Preco = nudPreco.Value;

            ProdutoBusiness business = new ProdutoBusiness();
            int pk = business.Salvar(dto);

            EstoqueDTO estoque = new EstoqueDTO();
            estoque.Produto = txtNome.Text;
            estoque.ItemProdutoId = pk;
            estoque.QtdEstocado = 0;

            EstoqueBusiness buss = new EstoqueBusiness();
            buss.Salvar(estoque);
        }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
