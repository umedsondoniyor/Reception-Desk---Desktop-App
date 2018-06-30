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
    public partial class report_rezervasyon : Form
    {
        public report_rezervasyon()
        {
            InitializeComponent();
        }

        private void report_rezervasyon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.tbl_rezervasyon' table. You can move, or remove it, as needed.
            this.tbl_rezervasyonTableAdapter.Fill(this.hotelDataSet1.tbl_rezervasyon);

            this.reportViewer1.RefreshReport();
        }
    }
}
