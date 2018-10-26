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
using FamosoAça.Classes.Fornecedor;

namespace FamosoAça.Screens.Entregavel_III.Item
{
    public partial class frmConsultarItem : UserControl
    {
        public frmConsultarItem()
        {
            InitializeComponent();
            CarregarCombos();
            FornecedorDTO dt = cboFornecedor.SelectedItem as FornecedorDTO;
        }
        void CarregarCombos()
        {
            ItemBusiness business = new ItemBusiness();
            List<ItemDTO> lista = business.Listar();

            dgvItem.DataSource = lista;
        }
        void CarregarGrid()
        {
           
             
            string nome = txtNome.Text;
            string fornecedor = txtFornecedor.Text;

            ItemBusiness buss = new ItemBusiness();
            List<ItemDTO> dto = buss.Consultar(nome, fornecedor);

            dgvItem.AutoGenerateColumns = false;
            dgvItem.DataSource = dto;

        }

        private void frmConsultarItem_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
