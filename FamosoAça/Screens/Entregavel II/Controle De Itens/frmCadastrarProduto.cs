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

                frmMessage tela = new frmMessage();
                tela.LoadScreen("Produto cadastrado com sucesso.");
                tela.ShowDialog();
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

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.FromArgb(84, 26, 82), Color.FromArgb(84, 26, 82), Color.Transparent);
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor, Color backgroundColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
    }
}
