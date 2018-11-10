using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Estoque;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_IV.Estoque
{
    public partial class Estoque : UserControl
    {
        public Estoque()
        {
            InitializeComponent();
            AutoCarregarGrid();

        }

        void AutoCarregarGrid()
        {
            try
            {
                EstoqueBusiness buss = new EstoqueBusiness();
                List<EstoqueDTO> list = buss.Listar();

                dgvEstoque.AutoGenerateColumns = false;
                dgvEstoque.DataSource = list;
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
            string produto = txtNome.Text;

            EstoqueBusiness buss = new EstoqueBusiness();
            List<EstoqueView> list = buss.Consultar(produto);

            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.DataSource = list;
        }

        private void Estoque_Load(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();

            }
            catch (Exception ex)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
        }
    }
}
