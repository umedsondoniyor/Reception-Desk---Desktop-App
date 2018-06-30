using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResepsiyonOtomasyon
{
    public partial class WF_progressBar : Form
    {
        public WF_progressBar()
        {
            InitializeComponent();
        }

        private void WF_progressBar_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 1;
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            if (progressBar1.Value == 100)
            {
                WF_islemler islemler = new WF_islemler();
                islemler.Show();
                this.Close();
            }
        }
    }
}
