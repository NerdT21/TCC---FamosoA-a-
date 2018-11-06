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
            EstadoBusiness biss = new EstadoBusiness();
            List<EstadoDTO> lista = biss.Listar();

            //DisplayMember = Motra,ValueMember=oque de verdade , DataSource = Lista
            cboEstado.ValueMember = nameof(EstadoDTO.IdEstado);
            cboEstado.DisplayMember = nameof(EstadoDTO.Estado);
            cboEstado.DataSource = lista;
        
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //try
            //{
                EstadoDTO estado = cboEstado.SelectedItem as EstadoDTO;

                FornecedorDTO dto = new FornecedorDTO();

                dto.Nome = txtNome.Text;
                dto.Email = txtEmail.Text;
                dto.CNPJ = txtCnpj.Text;
                dto.Cidade = txtCidade.Text;
                dto.Cep= mkbCep.Text;
                dto.Telefone = txtTelefone.Text;
                dto.IDEstado = estado.IdEstado;

                FornecedorBusiness business = new FornecedorBusiness();
                business.Salvar(dto);

              

               
           // }
           
           //catch (Exception ex)
           // {
           //    MessageBox.Show("Ocorreu um erro: "+ ex.Message, "Famoso Açai", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
        


        //try
        //{
        //    EstadoDTO dt = cboEstado.SelectedItem as EstadoDTO;

        //    FornecedorDTO dto = new FornecedorDTO();
        //    dto.Nome = txtNome.Text;
        //    dto.Email = txtEmail.Text;
        //    dto.CNPJ = txtCnpj.Text;
        //    dto.Cidade = txtCidade.Text;
        //    dto.Cep = mkbCep.Text;
        //    dto.Telefone = txtTelefone.Text;
        //    dto.Estado = dt.ID;


        //    FornecedorBusiness buss = new FornecedorBusiness();
        //    buss.Salvar(dto);

        //    MessageBox.Show("Fornecedor Cadastrado!", "Famoso Açai", MessageBoxButtons.OK);

        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Ocorreu um erro: "+ ex.Message, "Famoso Açai", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
    }
    }
}
