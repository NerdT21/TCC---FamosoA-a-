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
using FamosoAça.PlugIn;
using FamosoAça.Classes.FolhaPagamento;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_I
{
    public partial class frmFolhaPagto : UserControl
    {
        public frmFolhaPagto()
        {
            InitializeComponent();
            CarregarCombos();        
            GerarCredenciais();
            DataParaHoje();
        }

        void DataParaHoje()
        {
            DateTime hoje = DateTime.Now;
            int dia = hoje.Day;
            int mes = hoje.Month;
            int ano = hoje.Year;

            if (dia < 10)
            {
                string data = "0" + dia + "/" + mes + "/" + ano;
                mkbData.Text = data;
            }
            else
            {
                string data = dia + "/" + mes + "/" + ano;
                mkbData.Text = data;
            }
        }

        void GerarCredenciais()
        {
            try
            {
                string nome = cboFuncionario.Text;
                ViewFuncionario dto = cboFuncionario.SelectedItem as ViewFuncionario;

                mkbCPF.Text = dto.Cpf;
                txtSalario.Text = dto.Salario.ToString();
                txtDepto.Text = dto.Depto.ToString();

                if (dto.Imagem == string.Empty)
                {
                    pbxImgFuncionario.Image = null;
                }
                else
                {
                    pbxImgFuncionario.Image = ImagemPlugIn.ConverterParaImagem(dto.Imagem);
                }
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }          
        }

        void CarregarCombos()
        {
            try
            {
                FuncionariosBusiness buss = new FuncionariosBusiness();
                List<ViewFuncionario> lista = buss.Listar();

                cboFuncionario.ValueMember = nameof(FuncionarioDTO.Id);
                cboFuncionario.DisplayMember = nameof(FuncionarioDTO.Nome);
                cboFuncionario.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
            
        }

        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            GerarCredenciais();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                FolhaPagto pagto = new FolhaPagto();
                pagto.Salario = Convert.ToDecimal(txtSalario.Text);
                pagto.Faltas = Convert.ToInt32(nudFaltas.Value);
                pagto.HoraExtra = Convert.ToDateTime(mkbHE.Text);
                pagto.Atrasos = Convert.ToDateTime(mkbAtraso.Text);
                pagto.Domingos = Convert.ToInt32(nudDom.Value);
                pagto.Percentual = Convert.ToInt32(txtPercent.Text);

                txtINSS.Text = pagto.CalcularINSS().ToString("F2");
                txtIR.Text = pagto.CalcularIR().ToString("F2");
                txtFGTS.Text = pagto.CalcularFGTS().ToString("F2");
                TxtSalFam.Text = pagto.VerificarSalarioFamilia().ToString("F2");
                txtValTrans.Text = pagto.CalcularValeTransporte().ToString("F2");
                txtSalLiquido.Text = pagto.CalcularSalarioLiquido().ToString("F2");
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }          
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDTO funcionario = cboFuncionario.SelectedItem as FuncionarioDTO;

                FolhaPagamentoDTO dto = new FolhaPagamentoDTO();
                dto.HorasExtras = mkbHE.Text;
                dto.Faltas = Convert.ToInt32(nudFaltas.Value);
                dto.SalBruto = Convert.ToDecimal(txtSalario.Text);
                dto.ImpostoRenda = Convert.ToDecimal(txtIR.Text);
                dto.Fgts = Convert.ToDecimal(txtFGTS.Text);
                dto.VLTars = Convert.ToDecimal(txtValTrans.Text);
                dto.IdFuncio = funcionario.Id;
                dto.SalLiq = Convert.ToDecimal(txtSalLiquido.Text);
                dto.Inss = Convert.ToDecimal(txtINSS.Text);
                dto.SalFamilia = Convert.ToDecimal(TxtSalFam.Text);
                dto.Data = mkbData.Text;

                FolhaPagamentoBusiness buss = new FolhaPagamentoBusiness();
                buss.Salvar(dto);

                frmMessage tela = new frmMessage();
                tela.LoadScreen("Pagamento registrado com sucesso!");
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
