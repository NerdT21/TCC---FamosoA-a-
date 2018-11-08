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

namespace FamosoAça.Screens.Entregavel_IV.Gastos_Adicionais
{
    public partial class frmGastosAdicionais : UserControl
    {
        public frmGastosAdicionais()
        {
            InitializeComponent();
            DataHoje();
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        void DataHoje()
        {

            DateTime hj = DateTime.Now;
            int dia = hj.Day;
            int mes = hj.Month;
            int ano = hj.Year;

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
            //try
            //{
                GastosADTO dto = new GastosADTO();
                dto.Nome = txtNome.Text;
                dto.Decricao = txtNome.Text;
                dto.Data = mktData.Text;
                dto.Valor = nudValor.Value;

                GastosABusiness buss = new GastosABusiness();
                buss.Salvar(dto);

                MessageBox.Show("Salvo com sucesso !" , "Famoso Açai", MessageBoxButtons.OK);


            //}
            //catch (Exception ex)
            //{
            //  MessageBox.Show("Ocorreu um erro: " + ex.Message);
            //}
        }

        private void frmGastosAdicionais_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
