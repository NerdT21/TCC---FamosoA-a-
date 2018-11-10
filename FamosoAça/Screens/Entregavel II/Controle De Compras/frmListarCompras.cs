using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Compra;
using FamosoAça.Classes.Compra.itemCompra;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Compras
{
    public partial class frmListarCompras : UserControl
    {
        public frmListarCompras()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            try
            {
                CompraBusiness bus = new CompraBusiness();
                List<ItemComprasView> dto = bus.Listar();

                dgvCompra.AutoGenerateColumns = false;
                dgvCompra.DataSource = dto;
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

                CompraBusiness bus = new CompraBusiness();
                List<ItemComprasView> dto = bus.Consultar(data);

                dgvCompra.AutoGenerateColumns = false;
                dgvCompra.DataSource = dto;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }          
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmListarCompras_Load(object sender, EventArgs e)
        {
            dgvCompra.BorderStyle = BorderStyle.None;
            dgvCompra.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(84, 26, 82);
            dgvCompra.RowsDefaultCellStyle.BackColor = Color.FromArgb(124, 33, 121);
            dgvCompra.RowsDefaultCellStyle.ForeColor = Color.White;

            dgvCompra.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCompra.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvCompra.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCompra.BackgroundColor = Color.White;

            dgvCompra.EnableHeadersVisualStyles = false;
            dgvCompra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCompra.RowHeadersVisible = false;

            dgvCompra.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvCompra.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvCompra.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvCompra.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvCompra.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
