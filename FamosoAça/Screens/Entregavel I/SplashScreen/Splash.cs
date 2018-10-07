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
            timer.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {



        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer.Stop();
                frmLogin tela = new frmLogin();
                tela.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
