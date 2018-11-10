using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.FluxoDeCaixa;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_IV.Fluxo_de_Caixa
{
    public partial class frmFluxoCaixa : UserControl
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            try
            {
                FluxoBusiness buss = new FluxoBusiness();
                List<FluxoDTO> lista = buss.Listar();

                dgvFluxoDeCaixa.AutoGenerateColumns = false;
                dgvFluxoDeCaixa.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
          
        }

        private void frmFluxoCaixa_Load(object sender, EventArgs e)
        {
            dgvFluxoDeCaixa.BorderStyle = BorderStyle.None;
            dgvFluxoDeCaixa.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(84, 26, 82);
            dgvFluxoDeCaixa.RowsDefaultCellStyle.BackColor = Color.FromArgb(124, 33, 121);
            dgvFluxoDeCaixa.RowsDefaultCellStyle.ForeColor = Color.White;

            dgvFluxoDeCaixa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFluxoDeCaixa.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvFluxoDeCaixa.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvFluxoDeCaixa.BackgroundColor = Color.White;

            dgvFluxoDeCaixa.EnableHeadersVisualStyles = false;
            dgvFluxoDeCaixa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFluxoDeCaixa.RowHeadersVisible = false;

            dgvFluxoDeCaixa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvFluxoDeCaixa.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvFluxoDeCaixa.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvFluxoDeCaixa.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvFluxoDeCaixa.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
