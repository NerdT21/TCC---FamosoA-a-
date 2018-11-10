using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamosoAça.Classes.Gatos_Adicionais;
using FamosoAça.CustomExceptions.TelasException;

namespace FamosoAça.Screens.Entregavel_IV.Gastos_Adicionais
{
    public partial class frmGastosAdicionais : UserControl
    {
        public frmGastosAdicionais()
        {
            InitializeComponent();
            DataParaHoje();
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        void DataParaHoje()
        {
            DateTime hoje = DateTime.Now;
            int dia = hoje.Day;
            int mes = hoje.Month;
            int ano = hoje.Year;

            if (dia < 10)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GastosADTO dto = new GastosADTO();
                dto.Nome = txtNome.Text;
                dto.Descricao = txtDescricao.Text;
                dto.Data = mktData.Text;
                dto.Valor = nudValor.Value;

                GastosABusiness buss = new GastosABusiness();
                buss.Salvar(dto);

                string msg = "Gasto adicionado com sucesso.";
                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (Exception)
            {
                frmException tela = new frmException();
                tela.LoadScreen("Ocorreu um erro.\nConsulte o administrador do sistema.");
                tela.ShowDialog();
            }          
        }

        private void frmGastosAdicionais_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
