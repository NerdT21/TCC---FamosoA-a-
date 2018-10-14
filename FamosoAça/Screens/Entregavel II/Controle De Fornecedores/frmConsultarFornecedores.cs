using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Fornecedor;

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Fornecedores
{
    public partial class frmConsultarFornecedores : UserControl
    {
        public frmConsultarFornecedores()
        {
            InitializeComponent();
            Autocarregar();
        }

        void Autocarregar()
        {
            FornecedorBusiness buss = new FornecedorBusiness();
            List<FornecedorDTO> lista = buss.Listar();

            dgvFornecedor.DataSource = lista;
        }

        void CarregarGrid()
        {
            string nome = txtNome.Text;
            string cidade = txtCidade.Text;

            FornecedorBusiness buss = new FornecedorBusiness();
            List<FornecedorDTO> lista = buss.Consultar(nome, cidade);

            dgvFornecedor.DataSource = lista;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
