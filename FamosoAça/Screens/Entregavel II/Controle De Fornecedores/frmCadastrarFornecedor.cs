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
using FamosoAça.CustomExceptions;

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
                dto.CEP = mkbCep.Text;
                dto.Telefone = txtTelefone.Text;
                dto.IdEstado = estado.IdEstado;
                dto.Rua = txtRua.Text;
                dto.Numero = txtNumero.Text;

                FornecedorBusiness business = new FornecedorBusiness();
                business.Salvar(dto);

                string msg = "Fornecedor cadastrado com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (ValidacaoException vex)
            {
                string msg = vex.Message;

                frmAlert tela = new frmAlert();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (MySqlException mex)
            {
                if (mex.Number == 1062)
                {
                    string msg = "Esse fornecedor já está cadastrado. " +
                        "Verifique se o CNPJ está corretamente preenchido ou se ele já está cadastrado no sistema.";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
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
                    txtRua.Text = resposta.end;
                }
                catch (Exception)
                {
                    frmAlert tela = new frmAlert();
                    tela.LoadScreen("O CEP não foi encontrado");
                    tela.ShowDialog();
                }
            }
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor, Color backgroundColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.FromArgb(84, 26, 82), Color.FromArgb(84, 26, 82), Color.Transparent);

        }
    }
}
