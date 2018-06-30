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
    public partial class WF_Odalar_Durumu : Form
    {
        public WF_Odalar_Durumu()
        {
            InitializeComponent();
        }

        private void WF_Odalar_Durumu_Load(object sender, EventArgs e)
        {
         
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();

            for (int i = 0; i < 20; i++)
            {
                var a = (from t in otel.tbl_musteris where t.odaNo == i select t.odaNo).FirstOrDefault();

                foreach (Control btn in panel1.Controls)
                {
                    if (btn.Text == a.ToString())
                    {
                        btn.BackColor = Color.Red;
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
