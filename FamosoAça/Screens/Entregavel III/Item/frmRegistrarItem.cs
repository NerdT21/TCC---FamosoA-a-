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
            CarregarCbo();
        }
        void CarregarCbo()
        {
            FornecedorBusiness buss = new FornecedorBusiness();
            List<FornecedorDTO> list = new List<FornecedorDTO>();

            cboFornecedor.ValueMember = nameof(FornecedorDTO.Id);
            cboFornecedor.DisplayMember = nameof(FornecedorDTO.Nome);
            cboFornecedor.DataSource = list;
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCadatrar_Click(object sender, EventArgs e)
        {

            try
            {
                FornecedorDTO dto = cboFornecedor.SelectedItem as FornecedorDTO;

                ItemDTO dt = new ItemDTO();
                dt.Nome = txtItem.Text;
                dt.IdFornecedor = Convert.ToInt32(cboFornecedor.Text);
                dt.Descricao = txtDescricao.Text;
                dt.Preco = Convert.ToDecimal(nudPreco.Value);

                ItemBusiness business = new ItemBusiness();
                business.Salvar(dt);

                MessageBox.Show("Item registrado com sucesso", "Famoso Açai", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um Erro inesperado,Tente Novamente ou Solicite Ajuda ao Gerente" + MessageBoxButtons.OK);
            }
            

        }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
