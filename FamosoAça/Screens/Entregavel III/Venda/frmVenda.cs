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
using FamosoAça.Classes.Login;

namespace FamosoAça.Screens.Entregavel_III.ConsultarVenda
{
    public partial class frmVenda : UserControl
    {
        public frmVenda()
        {
            InitializeComponent();
            CarregarCombos();
            DataHoje();
        }

        BindingList<ProdutoDTO> carrinhoAdd = new BindingList<ProdutoDTO>();
        BindingList<decimal> val = new BindingList<decimal>();

        void CarregarCombos()
        {
            ProdutoBusiness buss = new ProdutoBusiness();
            List<ProdutoDTO> dto = buss.Listar();

            cboNome.ValueMember = nameof(ProdutoDTO.Id);
            cboNome.DisplayMember = nameof(ProdutoDTO.Nome);
            cboNome.DataSource = dto;
        }

        void CarregarGrid()
        {

            dgvVendas.AutoGenerateColumns = false;
            dgvVendas.DataSource = carrinhoAdd;

        }

        void DataHoje()
        {

            DateTime hj = DateTime.Now;
            int dia = hj.Day;
            int mes = hj.Month;
            int ano = hj.Year;

            if(dia < 10)
            {
                string data = "0" + dia + "/" + mes + "/" + ano;
                mktData.Text = data;

            }
            else
            {

                string data = dia + "/" + mes + "/" + ano;
                mktData.Text = data;

            }


        }

        
         private void btnCadastrar_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VendaDTO dto = new VendaDTO();
            dto.IdUsuario = UserSession.UsuarioLogado.Id;
            dto.DataVenda = mktData.Text;
            dto.FormaDePagamento = Convert.ToString(cboTipoPag.SelectedItem);

            VendaBusiness buss = new VendaBusiness();
            buss.Salvar(dto, carrinhoAdd.ToList());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO dto = cboNome.SelectedItem as ProdutoDTO;

                int quantidade = Convert.ToInt32(nudQtd.Value);

                for (int i = 0; i < quantidade; i++)
                {

                    carrinhoAdd.Add(dto);

                }

                CarregarGrid();

                val.Add(dto.Preco * quantidade);
                txtValorTotal.Text = Convert.ToString(val.Sum());

            }
            catch (Exception ex)
            {

               MessageBox.Show("Ocorreu um Erro: "+ ex.Message,"Famoso Açai",MessageBoxButtons.OK);
            }
        }

        private void cboTipoPag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProduto.Text = cboNome.Text;
        }
    }
}
