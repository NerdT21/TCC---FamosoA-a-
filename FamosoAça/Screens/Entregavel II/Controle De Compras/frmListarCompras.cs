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
            CompraBusiness bus = new CompraBusiness();
            List<ItemComprasView> dto = bus.Listar();

            dgvCompra.AutoGenerateColumns = false;
            dgvCompra.DataSource = dto;
        }

        void CarregarGrid()
        {
            string data = mkbData.Text;

            CompraBusiness bus = new CompraBusiness();
            List<ItemComprasView> dto = bus.Consultar(data);

            dgvCompra.AutoGenerateColumns = false;
            dgvCompra.DataSource = dto;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
