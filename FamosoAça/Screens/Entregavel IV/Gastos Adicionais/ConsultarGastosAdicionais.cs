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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
