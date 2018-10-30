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
            EstadoBusiness buss = new EstadoBusiness();
            List<EstadoDTO> lista = buss.Listar();

            cboEstado.ValueMember = nameof(EstadoDTO.ID);
            cboEstado.DisplayMember = nameof(EstadoDTO.Nome);
            cboEstado.DataSource = lista;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //try
            //{
                EstadoDTO dt = cboEstado.SelectedItem as EstadoDTO;

                FornecedorDTO dto = new FornecedorDTO();
                dto.Nome = txtNome.Text;
                dto.Email = txtEmail.Text;
                dto.CNPJ = txtCnpj.Text;
                dto.Cep = mkbCep.Text;
                dto.Telefone = txtTelefone.Text;
                dto.Estado = cboEstado.Text;


                FornecedorBusiness buss = new FornecedorBusiness();
                buss.Salvar(dto);

                MessageBox.Show("Fornecedor Cadastrado!", "Famoso Açai", MessageBoxButtons.OK);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ocorreu um erro: "+ ex.Message, "Famoso Açai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
