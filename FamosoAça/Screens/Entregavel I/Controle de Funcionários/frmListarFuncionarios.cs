using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Funcionarios;

namespace FamosoAça.Screens.Entregavel_I.Controle_de_Funcionários
{
    public partial class frmListarFuncionarios : UserControl
    {
        public frmListarFuncionarios()
        {
            InitializeComponent();
            AutoCarregar();
        }

        public void CarregarGrid()
        {
            string nome = txtNome.Text;
            string cidade = txtCidade.Text;

            FuncionariosBusiness buss = new FuncionariosBusiness();
            List<FuncionarioDTO> dto = buss.Consultar(nome, cidade);

            dgvListarFuncionario.AutoGenerateColumns = false;
            dgvListarFuncionario.DataSource = dto;
        }

        public void AutoCarregar()
        {
            FuncionariosBusiness buss = new FuncionariosBusiness();
            List<FuncionarioDTO> dto = buss.Listar();

            dgvListarFuncionario.AutoGenerateColumns = false;
            dgvListarFuncionario.DataSource = dto;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
