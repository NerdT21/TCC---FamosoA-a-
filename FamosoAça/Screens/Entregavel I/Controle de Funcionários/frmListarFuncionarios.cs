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
    }
}
