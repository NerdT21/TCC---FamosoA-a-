using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Gatos_Adicionais;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_IV.Gatos_Adicionais
{
    public partial class ConsultarGastosAdicionais : UserControl
    {
        public ConsultarGastosAdicionais()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            try
            {
                GastosABusiness buss = new GastosABusiness();
                List<GastosADTO> lista = buss.Listar();

                dgvGastos.AutoGenerateColumns = false;
                dgvGastos.DataSource = lista;
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
                string data = mkbData.Text;

                GastosABusiness buss = new GastosABusiness();
                List<GastosADTO> lista = buss.Consultar(data);

                dgvGastos.AutoGenerateColumns = false;
                dgvGastos.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
           
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void ConsultarGastosAdicionais_Load(object sender, EventArgs e)
        {

            dgvGastos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGastos.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvGastos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvGastos.BackgroundColor = Color.White;

            dgvGastos.EnableHeadersVisualStyles = false;
            dgvGastos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGastos.RowHeadersVisible = false;

            dgvGastos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvGastos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvGastos.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvGastos.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvGastos.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
