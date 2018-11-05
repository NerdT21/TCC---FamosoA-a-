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
            EstadoBusiness biss = new EstadoBusiness();
            List<EstadoDTO> lista = biss.Listar();

            //DisplayMember = Motra,ValueMember=oque de verdade , DataSource = Lista
            cboEstado.ValueMember = nameof(EstadoDTO.IdEstado);
            cboEstado.DisplayMember = nameof(EstadoDTO.Estado);
            cboEstado.DataSource = lista;
            
            //EstadoBusiness buss = new EstadoBusiness();
            //List<EstadoDTO> lista = buss.Listar();

            //cboEstado.ValueMember = nameof(EstadoDTO.ID);
            //cboEstado.DisplayMember = nameof(EstadoDTO.Nome);
            //cboEstado.DataSource = lista;
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


                MessageBox.Show("O FILHO DA PUTA ESTÁ CADASTRADO", "FILHO DA PUTA", MessageBoxButtons.OKCancel);

            }
            catch (MySqlException mex)
            {
                if (mex.Number == 1062)
                {
                    MessageBox.Show("CNPJ já cadastrado.", "Famoso Açai", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Famoso Açai", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }
    }
}
