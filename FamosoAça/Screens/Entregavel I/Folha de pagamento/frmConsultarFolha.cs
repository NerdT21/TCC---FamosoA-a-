using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.FolhaPagamento;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_I
{
    public partial class frmConsultarFolha : UserControl
    {
        public frmConsultarFolha()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            try
            {
                FolhaPagamentoBusiness buss = new FolhaPagamentoBusiness();
                List<FolhaPagamentoDTO> lista = buss.Listar();

                dgvFolha.AutoGenerateColumns = false;
                dgvFolha.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
            
        }

        private void frmConsultarFolha_Load(object sender, EventArgs e)
        {
            dgvFolha.BorderStyle = BorderStyle.None;
            dgvFolha.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(84, 26, 82);
            dgvFolha.RowsDefaultCellStyle.BackColor = Color.FromArgb(124, 33, 121);
            dgvFolha.RowsDefaultCellStyle.ForeColor = Color.White;

            dgvFolha.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFolha.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvFolha.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvFolha.BackgroundColor = Color.White;

            dgvFolha.EnableHeadersVisualStyles = false;
            dgvFolha.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFolha.RowHeadersVisible = false;

            dgvFolha.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvFolha.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvFolha.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvFolha.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvFolha.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
