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
            CompraBusiness buss = new CompraBusiness();
            List<ViewCompra> dto = buss.Listar();

            dgvCompra.AutoGenerateColumns = false;
            dgvCompra.DataSource = dto;
        }

        void CarregarGrid()
        {
            string data = mkbData.Text;

            CompraBusiness buss = new CompraBusiness();
            List<ViewCompra> dto = buss.Consultar(data);

            dgvCompra.AutoGenerateColumns = false;
            dgvCompra.DataSource = dto;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
