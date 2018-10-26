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
            FornecedorDTO dto = cboFornecedor.SelectedItem as FornecedorDTO;

            ItemDTO dt = new ItemDTO();
            dt.Nome = txtItem.Text;
            dt.IdFornecedor = Convert.ToInt32(cboFornecedor.Text);
            dt.Descricao = txtDescricao.Text;
            dt.Preco = Convert.ToDecimal(nudPreco.Value);

            ItemBusiness business = new ItemBusiness();
            business.Salvar(dt);

            MessageBox.Show("Item registrado com sucesso", "Famoso Açai",MessageBoxButtons.OK);

        }
    }
}
