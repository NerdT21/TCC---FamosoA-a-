using FamosoAça.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamosoAça
{
    public partial class Splash : Form
    {
        
        
        public Splash()
        {
            InitializeComponent();

            Task.Factory.StartNew(() =>
            {
                //Espara 5000 = 2 segundos 
                System.Threading.Thread.Sleep(5000);

                Invoke(new Action(() =>
                {
                    //Abre a Form de login
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    Hide();

                }));

            });

        }

        private void timer_Tick(object sender, EventArgs e)
        {
          
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
