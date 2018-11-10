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
            FluxoBusiness buss = new FluxoBusiness();
            List<FluxoDTO> lista = buss.Listar();

            dgvFluxoDeCaixa.AutoGenerateColumns = false;
            dgvFluxoDeCaixa.DataSource = lista;
        }
    }
}
