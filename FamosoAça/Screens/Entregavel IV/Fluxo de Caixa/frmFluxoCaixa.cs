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
    }
}
