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
using FamosoAça.Classes.Funcionarios;
using MySql.Data.MySqlClient;
using FamosoAça.PlugIn;
using FamosoAça.Classes.Estado;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_I.Controle_de_Funcionários
{
    public partial class frmCadastrarFuncionario : UserControl
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            try
            {
                CargoBusiness buss = new CargoBusiness();
                List<CargoDTO> lista = buss.Listar();

                cboDepto.ValueMember = nameof(CargoDTO.Id);
                cboDepto.DisplayMember = nameof(CargoDTO.Nome);
                cboDepto.DataSource = lista;

                EstadoBusiness bess = new EstadoBusiness();
                List<EstadoDTO> li = bess.Listar();

                cboEstado.ValueMember = nameof(EstadoDTO.IdEstado);
                cboEstado.DisplayMember = nameof(EstadoDTO.Estado);
                cboEstado.DataSource = li;
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
                CargoDTO depto = cboDepto.SelectedItem as CargoDTO;
                EstadoDTO dt = cboEstado.SelectedItem as EstadoDTO;

                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Nome = txtNome.Text;
                dto.Nascimento = mtbNasc.Text;
                dto.Rg = mtbRg.Text;
                dto.Cpf = mtbCpf.Text;
                dto.Telefone = mtbTelefone.Text;
                dto.Email = txtEmail.Text;
                dto.IdDepto = depto.Id;
                dto.Cidade = txtCidade.Text;
                dto.IdEstado = dt.IdEstado;
                //dto.Bairro = txtBairro.Text;
                dto.Salario = Convert.ToInt32(txtSalario.Text);
                dto.Rua = txtRua.Text;
                dto.Cep = txtCep.Text;
                dto.Imagem = ImagemPlugIn.ConverterParaString(pbxImagem.Image);

                FuncionariosBusiness buss = new FuncionariosBusiness();
                buss.Salvar(dto);

                frmMessage tela = new frmMessage();
                tela.LoadScreen("Funcionário cadastrado com sucesso!");
                tela.ShowDialog();

            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    frmAlert tela = new frmAlert();
                    tela.LoadScreen("Funcionario já está cadastrado.\nVerifique se o RG ou CPF estão corretamento preenchidos ou se ele já esta no sistema.");
                    tela.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
        }

        private void pbxImagem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pbxImagem.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
           
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            { 
                try
                {
                    var ws = new WSCorreios.AtendeClienteClient();
                    //var ws = new WSCorreios.AtendeClienteClient();
                    var resposta = ws.consultaCEP(txtCep.Text);

                    txtRua.Text = resposta.end;
                    txtCidade.Text = resposta.cidade;
                    cboEstado.Text = resposta.uf;
                    txtBairro.Text = resposta.bairro;

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
