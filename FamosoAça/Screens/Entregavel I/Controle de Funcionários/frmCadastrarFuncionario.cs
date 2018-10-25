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
            CargoBusiness buss = new CargoBusiness();
            List<CargoDTO> lista = buss.Listar();

            cboDepto.ValueMember = nameof(CargoDTO.Id);
            cboDepto.DisplayMember = nameof(CargoDTO.Nome);
            cboDepto.DataSource = lista;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CargoDTO depto = cboDepto.SelectedItem as CargoDTO;

                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Nome = txtNome.Text;
                dto.Nascimento = mtbNasc.Text;
                dto.RG = mtbRg.Text;
                dto.Salario = Convert.ToDecimal(txtSalario.Text);
                dto.CPF = mtbCpf.Text;
                dto.Telefone = mtbTelefone.Text;
                dto.Email = txtEmail.Text;

                dto.DeptoId = depto.Id;

                dto.Cidade = txtCidade.Text;
                dto.Estado = cboEstado.Text;
                dto.Bairro = txtBairro.Text;
                dto.Rua = txtRua.Text;
                dto.CEP = txtCep.Text;
                dto.Imagem = ImagemPlugIn.ConverterParaString(pbxImagem.Image);

                FuncionariosBusiness buss = new FuncionariosBusiness();
                buss.Salvar(dto);

                MessageBox.Show("Funcionário cadastrado com suceso!!", "FamosoAçaí", MessageBoxButtons.OK);
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Funcionario já está cadastrado. Verifique se o RG ou CPF estão corretamento preenchidos ou se ele já esta no sistema.",
                        "FamosoAçaí", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FamosoAçaí", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pbxImagem.ImageLocation = dialog.FileName;
            }
        }
    }
}
