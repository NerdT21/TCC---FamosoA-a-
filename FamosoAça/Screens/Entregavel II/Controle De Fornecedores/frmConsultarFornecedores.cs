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
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Fornecedores
{
    public partial class frmConsultarFornecedores : UserControl
    {
        public frmConsultarFornecedores()
        {
            InitializeComponent();
            Autocarregar();
        }

        void Autocarregar()
        {
            try
            {
                FornecedorBusiness buss = new FornecedorBusiness();
                List<FornecedorDTO> lista = buss.Listar();

                dgvFornecedor.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }           
        }

        void CarregarGrid()
        {
            try
            {
                string nome = txtNome.Text;
                string cidade = txtCidade.Text;

                FornecedorBusiness buss = new FornecedorBusiness();
                List<FornecedorDTO> lista = buss.Consultar(nome, cidade);

                dgvFornecedor.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }           
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmConsultarFornecedores_Load(object sender, EventArgs e)
        {
            dgvFornecedor.BorderStyle = BorderStyle.None;
            dgvFornecedor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(84, 26, 82);
            dgvFornecedor.RowsDefaultCellStyle.BackColor = Color.FromArgb(124, 33, 121);
            dgvFornecedor.RowsDefaultCellStyle.ForeColor = Color.White;

            dgvFornecedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFornecedor.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvFornecedor.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvFornecedor.BackgroundColor = Color.White;

            dgvFornecedor.EnableHeadersVisualStyles = false;
            dgvFornecedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFornecedor.RowHeadersVisible = false;

            dgvFornecedor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvFornecedor.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvFornecedor.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvFornecedor.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvFornecedor.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
