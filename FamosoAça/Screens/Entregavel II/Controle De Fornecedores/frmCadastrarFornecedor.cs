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
using FamosoAça.Classes.Estado;
using MySql.Data.MySqlClient;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Fornecedores
{
    public partial class frmCadastrarFornecedor : UserControl
    {
        public frmCadastrarFornecedor()
        {
            InitializeComponent();
            CarregarCombos();
        }
        void CarregarCombos()
        {
            try
            {
                EstadoBusiness biss = new EstadoBusiness();
                List<EstadoDTO> lista = biss.Listar();

                //DisplayMember = Motra,ValueMember=oque de verdade , DataSource = Lista
                cboEstado.ValueMember = nameof(EstadoDTO.IdEstado);
                cboEstado.DisplayMember = nameof(EstadoDTO.Estado);
                cboEstado.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                EstadoDTO estado = cboEstado.SelectedItem as EstadoDTO;

                FornecedorDTO dto = new FornecedorDTO();

                dto.Nome = txtNome.Text;
                dto.Email = txtEmail.Text;
                dto.CNPJ = txtCnpj.Text;
                dto.Cidade = txtCidade.Text;
                dto.Cep = mkbCep.Text;
                dto.Telefone = txtTelefone.Text;
                dto.IDEstado = estado.IdEstado;

                FornecedorBusiness business = new FornecedorBusiness();
                business.Salvar(dto);

                frmMessage tela = new frmMessage();
                tela.LoadScreen("Forncedor cadstrado com suceso");
                tela.ShowDialog();
            }
            catch (MySqlException mex)
            {
                if (mex.Number == 1062)
                {
                    frmAlert tela = new frmAlert();
                    tela.LoadScreen("CNPJ já cadastrado.");
                    tela.ShowDialog();
                }
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
        }

        private void mkbCep_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    var ws = new WSCorreios.AtendeClienteClient();
                    //var ws = new WSCorreios.AtendeClienteClient();
                    var resposta = ws.consultaCEP(mkbCep.Text);
                    
                    txtCidade.Text = resposta.cidade;
                    cboEstado.Text = resposta.uf;                   
                }
                catch (Exception)
                {
                    frmAlert tela = new frmAlert();
                    tela.LoadScreen("O CEP não foi encontrado");
                    tela.ShowDialog();
                }
            }
        }
    }
}
