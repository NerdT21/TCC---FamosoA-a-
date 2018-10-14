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

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Fornecedores
{
    public partial class frmCadastrarFornecedor : UserControl
    {
        public frmCadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorDTO dto = new FornecedorDTO();

                dto.Nome = txtNome.Text;
                dto.Email = txtEmail.Text;
                dto.CNPJ = txtCnpj.Text;
                dto.Cep = mkbCep.Text;
                dto.Telefone = txtTelefone.Text;
                dto.Estado = Convert.ToString(cboEstado.SelectedItem);

                FornecedorBusiness buss= new FornecedorBusiness();
                buss.Salvar(dto);

                MessageBox.Show("Fornecedor cadatrado!","Catioro's",MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: "+ ex.Message, "Catioro's", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
