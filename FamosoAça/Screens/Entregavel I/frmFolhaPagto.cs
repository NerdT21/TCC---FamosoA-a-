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

namespace FamosoAça.Screens.Entregavel_I
{
    public partial class frmFolhaPagto : UserControl
    {
        public frmFolhaPagto()
        {
            InitializeComponent();
            CarregarCombos();        
            GerarCredenciais();                    
        }

        void GerarCredenciais()
        {
            string nome = cboFuncionario.Text;
            FuncionarioDTO dto = cboFuncionario.SelectedItem as FuncionarioDTO;

            if (dto == null)
            {
                
            }
            else
            {
                mkbCPF.Text = dto.CPF;
                txtSalario.Text = dto.Salario.ToString();
                txtDepto.Text = dto.DeptoId.ToString();
                pbxImgFuncionario.Image = ImagemPlugIn.ConverterParaImagem(dto.Imagem);
            }

        }
        void CarregarCombos()
        {
            FuncionariosBusiness buss = new FuncionariosBusiness();
            List<FuncionarioDTO> lista = buss.Listar();

            cboFuncionario.ValueMember = nameof(FuncionarioDTO.Id);
            cboFuncionario.DisplayMember = nameof(FuncionarioDTO.Nome);
            cboFuncionario.DataSource = lista;
        }

        //public decimal FolhaCoordenadora()
        //{
        //    FolhaPagto folha = new FolhaPagto();
        //    decimal salarioHora = folha.SalarioHora(Convert.ToDecimal(txtSalario.Text));
        //    decimal valeTransporte = folha.ValeTransporte(Convert.ToDecimal(txtSalario.Text));
        //    decimal INSS = folha.CalculoINSS(Convert.ToDecimal(txtSalario.Text), nudFaltas.Value, Convert.ToDecimal(txtAtraso.Text), Convert.ToDecimal(txtHE.Text), Convert.ToDecimal(txtHE.Text), );
        //}

        void btnCalcular_Click(object sender, EventArgs e)
        {

            FuncionarioDTO funcio = cboFuncionario.SelectedItem as FuncionarioDTO;
            FolhaPagamentoDTO dto = new FolhaPagamentoDTO();
            dto.IdFuncinario = funcio.Id;
            txtHE.Text = dto.HoraExtra;
            //txtAtraso.Text = dto.A;
            

            MessageBox.Show("Folha de pagamento Salvo com sucesso!!", "Famoso Açaí", MessageBoxButtons.OK);

        }

        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            GerarCredenciais();
        }
    }
}
