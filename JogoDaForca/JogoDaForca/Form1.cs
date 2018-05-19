using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlJogo.Visible = true;
            btnStart.Visible = false;
        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            lblText.Text = e.ToString();
        }
    }
}
