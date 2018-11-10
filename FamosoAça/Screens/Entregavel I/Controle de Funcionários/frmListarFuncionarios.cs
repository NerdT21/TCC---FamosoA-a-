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
using FamosoAça.CustomExceptions.TelasException;

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
            try
            {
                string nome = txtNome.Text;
                string cidade = txtCidade.Text;

                FuncionariosBusiness buss = new FuncionariosBusiness();
                List<ViewFuncionario> dto = buss.Consultar(nome, cidade);

                dgvListarFuncionario.AutoGenerateColumns = false;
                dgvListarFuncionario.DataSource = dto;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
            
        }

        public void AutoCarregar()
        {
            try
            {
                FuncionariosBusiness buss = new FuncionariosBusiness();
                List<ViewFuncionario> dto = buss.Listar();

                dgvListarFuncionario.AutoGenerateColumns = false;
                dgvListarFuncionario.DataSource = dto;
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
            try
            {
                CarregarGrid();
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
            
        }

        private void frmListarFuncionarios_Load(object sender, EventArgs e)
        {
            dgvListarFuncionario.BorderStyle = BorderStyle.None;
            dgvListarFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(84, 26, 82);
            dgvListarFuncionario.RowsDefaultCellStyle.BackColor = Color.FromArgb(124, 33, 121);
            dgvListarFuncionario.RowsDefaultCellStyle.ForeColor = Color.White;

            dgvListarFuncionario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListarFuncionario.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvListarFuncionario.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvListarFuncionario.BackgroundColor = Color.White;

            dgvListarFuncionario.EnableHeadersVisualStyles = false;
            dgvListarFuncionario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListarFuncionario.RowHeadersVisible = false;

            dgvListarFuncionario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvListarFuncionario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvListarFuncionario.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvListarFuncionario.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvListarFuncionario.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
