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
    }
}
