﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Compra.Item;
using FamosoAça.Classes.Fornecedor;
using FamosoAça.Classes.Venda.Produto;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_III.Item
{
    public partial class frmConsultarItem : UserControl
    {
        public frmConsultarItem()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            try
            {
                ProdutoBusiness buss = new ProdutoBusiness();
                List<ProdutoDTO> lista = buss.Listar();

                dgvProduto.DataSource = lista;
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
            try
            {
                string nome = txtNome.Text;
                string marca = txtMarca.Text;

                ProdutoBusiness buss = new ProdutoBusiness();
                List<ProdutoDTO> lista = buss.Consultar(nome, marca);

                dgvProduto.DataSource = lista;
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }
           
        }

        private void frmConsultarItem_Load(object sender, EventArgs e)
        {
            dgvProduto.BorderStyle = BorderStyle.None;
            dgvProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(84, 26, 82);
            dgvProduto.RowsDefaultCellStyle.BackColor = Color.FromArgb(124, 33, 121);
            dgvProduto.RowsDefaultCellStyle.ForeColor = Color.White;

            dgvProduto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProduto.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvProduto.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvProduto.BackgroundColor = Color.White;

            dgvProduto.EnableHeadersVisualStyles = false;
            dgvProduto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProduto.RowHeadersVisible = false;

            dgvProduto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvProduto.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvProduto.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvProduto.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvProduto.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
