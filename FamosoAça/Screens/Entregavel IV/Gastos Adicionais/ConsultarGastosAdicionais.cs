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
            GastosABusiness buss = new GastosABusiness();
            List<GastosADTO> lista = buss.Listar();

            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = lista;
        }

        void CarregarGrid()
        {
            string data = mkbData.Text;

            GastosABusiness buss = new GastosABusiness();
            List<GastosADTO> lista = buss.Consultar(data);

            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
