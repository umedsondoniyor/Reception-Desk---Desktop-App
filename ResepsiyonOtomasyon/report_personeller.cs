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
    public partial class report_personeller : Form
    {
        public report_personeller()
        {
            InitializeComponent();
        }

        private void report_personeller_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet2.tbl_Personel' table. You can move, or remove it, as needed.
          

            this.reportViewer1.RefreshReport();
        }
    }
}
