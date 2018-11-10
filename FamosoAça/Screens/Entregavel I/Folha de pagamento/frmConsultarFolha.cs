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
            FolhaPagamentoBusiness buss = new FolhaPagamentoBusiness();
            List<FolhaPagamentoDTO> lista = buss.Listar();

            dgvFolha.AutoGenerateColumns = false;
            dgvFolha.DataSource = lista;
        }
    }
}
