using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamosoAça.CustomExceptions.TelasException
{
    public partial class frmQuestion : Form
    {
        public frmQuestion()
        {
            InitializeComponent();
        }

        public bool BotaoYes = false;

        public void LoadScreen(string msg)
        {
            txtMsg.Text = msg;
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            BotaoYes = true;
            this.Close();
        }
    }
}
