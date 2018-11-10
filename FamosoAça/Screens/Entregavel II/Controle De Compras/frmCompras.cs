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
using FamosoAça.Classes.Compra;
using FamosoAça.Classes.Login;

namespace FamosoAça.Screens.Entregavel_II.Controle_De_Compras
{
    public partial class frmCompras : UserControl
    {
        public frmCompras()
        {
            InitializeComponent();
            CarregarCombos();
            DataParaHoje();
            //CarregarTxt();
        }

        BindingList<ItemView> carrinhoAdd = new BindingList<ItemView>();
        BindingList<decimal> valor = new BindingList<decimal>();

        void DataParaHoje()
        {
            DateTime hoje = DateTime.Now;
            int dia = hoje.Day;
            int mes = hoje.Month;
            int ano = hoje.Year;

            if (dia < 10)
            {
                string data = "0" + dia + "/" + mes + "/" + ano;
                mkbData.Text = data;
            }
            else
            {
                string data = dia + "/" + mes + "/" + ano;
                mkbData.Text = data;
            }

        }

        void CarregarTxt()
        {
            ItemView item = cboItem.SelectedItem as ItemView;

            if (item.Nome != null)
            {
                txtItem.Text = item.Nome;

                txtValorTotal.Text = Convert.ToString(item.Preco);
                txtFornecedor.Text = item.Fornecedor;
            }
            else
            {
                txtItem.Text = "NULL";
            }

        }

        void CarregarCombos()
        {
            ItemBusiness buss = new ItemBusiness();
            List<ItemView> dto = buss.Listar();

            cboItem.ValueMember = nameof(ItemDTO.Id);
            cboItem.DisplayMember = nameof(ItemDTO.Nome);
            cboItem.DataSource = dto;
        }

        void CarregarGrid()
        {
            dgvCompras.AutoGenerateColumns = false;
            dgvCompras.DataSource = carrinhoAdd;
        }

        void MandarProCarrinho(string item, string qtd, string preco)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ItemView dto = cboItem.SelectedItem as ItemView;

            int quantidade = Convert.ToInt32(nudQtd.Value);

            for (int i = 0; i < quantidade; i++)
            {
                carrinhoAdd.Add(dto);
            }

            CarregarGrid();

            valor.Add(dto.Preco * quantidade);
            txtValorTotal.Text = Convert.ToString(valor.Sum());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompraDTO dto = new CompraDTO();
            dto.UsuarioId = UserSession.UsuarioLogado.Id;
            dto.Data = mkbData.Text;
            dto.FormaPagto = Convert.ToString(cboTipoPag.SelectedItem);

            CompraBusiness buss = new CompraBusiness();
            buss.Salvar(dto, carrinhoAdd.ToList());

            MessageBox.Show("Compra registrada com sucesso!", "Catioro's", MessageBoxButtons.OK);
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarTxt();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
