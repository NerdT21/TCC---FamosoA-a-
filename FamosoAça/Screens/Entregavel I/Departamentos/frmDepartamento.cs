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
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_I.Departamentos
{
    public partial class frmDepartamento : UserControl
    {
        public frmDepartamento()
        {
            InitializeComponent();
            AutoCarregar();
        }

        public void CarregarGrid()
        {
            try
            {
                string depto = txtProcurarDepto.Text;

                CargoBusiness buss = new CargoBusiness();
                List<CargoDTO> dto = buss.Consultar(depto);

                dgvDepto.AutoGenerateColumns = false;
                dgvDepto.DataSource = dto;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
            
        }

        public void AutoCarregar()
        {
            try
            {
                CargoBusiness buss = new CargoBusiness();
                List<CargoDTO> dto = buss.Listar();

                dgvDepto.AutoGenerateColumns = false;
                dgvDepto.DataSource = dto;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
       
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                CargoDTO dto = new CargoDTO();
                dto.Nome = txtDepto.Text;
                dto.Descricao = txtDecricao.Text;

                CargoBusiness buss = new CargoBusiness();
                buss.Salvar(dto);

                frmMessage tela = new frmMessage();
                tela.LoadScreen("Departamento cadastrado com sucesso!");
                tela.ShowDialog();
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            CarregarGrid();
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

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.FromArgb(84, 26, 82), Color.FromArgb(84, 26, 82), Color.Transparent);
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            dgvDepto.BorderStyle = BorderStyle.None;
            dgvDepto.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(84, 26, 82);
            dgvDepto.RowsDefaultCellStyle.BackColor = Color.FromArgb(124, 33, 121);
            dgvDepto.RowsDefaultCellStyle.ForeColor = Color.White;

            dgvDepto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDepto.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvDepto.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDepto.BackgroundColor = Color.White;

            dgvDepto.EnableHeadersVisualStyles = false;
            dgvDepto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDepto.RowHeadersVisible = false;

            dgvDepto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvDepto.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvDepto.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvDepto.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvDepto.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
