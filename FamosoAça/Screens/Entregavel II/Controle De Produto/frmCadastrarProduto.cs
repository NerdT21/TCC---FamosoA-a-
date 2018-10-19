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

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Produto
{
    public partial class frmCadastrarProduto : UserControl
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Nome = txtNome.Text;
                dto.Marca = txtMarca.Text;
                dto.Descricao = txtDesc.Text;
                dto.Preco = nudPreco.Value;

                ProdutoBusiness buss = new ProdutoBusiness();
                buss.Salvar(dto);

                MessageBox.Show("Produto cadastrado com sucesso!!", "Famoso Açai", MessageBoxButtons.OK);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: " + ex.Message,"Famoso Açai",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
    }
}
