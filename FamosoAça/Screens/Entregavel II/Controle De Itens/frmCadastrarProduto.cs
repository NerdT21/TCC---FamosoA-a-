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
using FamosoAça.Classes.Estoque;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Produto
{
    public partial class frmCadastrarProduto : UserControl
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
            CarregarCombos();
        }


        void CarregarCombos()
        {
            try
            {
                FornecedorBusiness buss = new FornecedorBusiness();
                List<FornecedorDTO> lista = buss.Listar();

                cboFornecedor.ValueMember = nameof(FornecedorDTO.Id);
                cboFornecedor.DisplayMember = nameof(FornecedorDTO.Nome);
                cboFornecedor.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorDTO fornecedor = cboFornecedor.SelectedItem as FornecedorDTO;

                ItemDTO dto = new ItemDTO();
                dto.Nome = txtNome.Text;
                dto.FornecedorId = fornecedor.Id;
                dto.Descricao = txtDescricao.Text;
                dto.Preco = Convert.ToDecimal(nudPreco.Value);

                ItemBusiness buss = new ItemBusiness();
                int pk = buss.Salvar(dto);

                EstoqueDTO estoque = new EstoqueDTO();
                estoque.Produto = txtNome.Text;
                estoque.ItemProdutoId = pk;
                estoque.QtdEstocado = 0;

                EstoqueBusiness business = new EstoqueBusiness();
                business.Salvar(estoque);
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPreco_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
