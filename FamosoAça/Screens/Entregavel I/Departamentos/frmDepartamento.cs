using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Cargo;

namespace FamosoAça.Screens.Entregavel_I.Departamentos
{
    public partial class frmDepartamento : UserControl
    {
        public frmDepartamento()
        {
            InitializeComponent();
            AutoCarregar();
        }

        public void CarregarGrid()
        {
            string depto = txtProcurarDepto.Text;

            CargoBusiness buss = new CargoBusiness();
            List<CargoDTO> dto = buss.Consultar(depto);

            dgvDepto.AutoGenerateColumns = false;
            dgvDepto.DataSource = dto;
        }

        public void AutoCarregar()
        {
            CargoBusiness buss = new CargoBusiness();
            List<CargoDTO> dto = buss.Listar();

            dgvDepto.AutoGenerateColumns = false;
            dgvDepto.DataSource = dto;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //try
            //{
                CargoDTO dto = new CargoDTO();
                dto.Nome = txtDepto.Text;
                dto.Descricao = txtDesc.Text;

                CargoBusiness buss = new CargoBusiness();
                buss.Salvar(dto);

                MessageBox.Show("Departamento cadastrado com suceso!!", "SIGMA", MessageBoxButtons.OK);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ocorreu um erro: " + ex.Message);
            //}
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
