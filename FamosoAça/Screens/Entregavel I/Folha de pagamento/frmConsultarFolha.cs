using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.FolhaPagamento;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_I
{
    public partial class frmConsultarFolha : UserControl
    {
        public frmConsultarFolha()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            try
            {
                FolhaPagamentoBusiness buss = new FolhaPagamentoBusiness();
                List<FolhaPagamentoDTO> lista = buss.Listar();

                dgvFolha.AutoGenerateColumns = false;
                dgvFolha.DataSource = lista;
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
