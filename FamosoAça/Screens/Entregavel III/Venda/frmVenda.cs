﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Venda;
using FamosoAça.Classes.Login;
using FamosoAça.Classes.Venda.Produto;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_III.ConsultarVenda
{
    public partial class frmVenda : UserControl
    {
        public frmVenda()
        {
            InitializeComponent();
            CarregarCombos();
            DataHoje();
        }

        BindingList<ProdutoDTO> carrinhoAdd = new BindingList<ProdutoDTO>();
        BindingList<decimal> val = new BindingList<decimal>();

        void CarregarCombos()
        {
            try
            {
                ProdutoBusiness buss = new ProdutoBusiness();
                List<ProdutoDTO> dto = buss.Listar();

                cboNome.ValueMember = nameof(ProdutoDTO.Id);
                cboNome.DisplayMember = nameof(ProdutoDTO.Nome);
                cboNome.DataSource = dto;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
       
        }

        void CarregarGrid()
        {
            dgvVendas.AutoGenerateColumns = false;
            dgvVendas.DataSource = carrinhoAdd;
        }

        void DataHoje()
        {
            DateTime hj = DateTime.Now;
            int dia = hj.Day;
            int mes = hj.Month;
            int ano = hj.Year;

            if(dia < 10)
            {
                string data = "0" + dia + "/" + mes + "/" + ano;
                mktData.Text = data;

            }
            else
            {

                string data = dia + "/" + mes + "/" + ano;
                mktData.Text = data;

            }
        }

        
         private void btnCadastrar_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                VendaDTO dto = new VendaDTO();
                dto.IdUsuario = UserSession.UsuarioLogado.Id;
                dto.Data = mktData.Text;
                dto.FormaPagto = Convert.ToString(cboTipoPag.SelectedItem);

                VendaBusiness buss = new VendaBusiness();
                buss.Salvar(dto, carrinhoAdd.ToList());

                frmMessage tela = new frmMessage();
                tela.LoadScreen("Venda realizada com sucesso.");
                tela.ShowDialog();
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO dto = cboNome.SelectedItem as ProdutoDTO;

                int quantidade = Convert.ToInt32(nudQtd.Value);

                for (int i = 0; i < quantidade; i++)
                {

                    carrinhoAdd.Add(dto);

                }

                CarregarGrid();

                val.Add(dto.Preco * quantidade);
                txtValorTotal.Text = Convert.ToString(val.Sum());

            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
        }

        private void cboTipoPag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProduto.Text = cboNome.Text;
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            dgvVendas.BorderStyle = BorderStyle.None;
            dgvVendas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(84, 26, 82);
            dgvVendas.RowsDefaultCellStyle.BackColor = Color.FromArgb(124, 33, 121);
            dgvVendas.RowsDefaultCellStyle.ForeColor = Color.White;

            dgvVendas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVendas.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvVendas.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVendas.BackgroundColor = Color.White;

            dgvVendas.EnableHeadersVisualStyles = false;
            dgvVendas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVendas.RowHeadersVisible = false;

            dgvVendas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvVendas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvVendas.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvVendas.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvVendas.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
