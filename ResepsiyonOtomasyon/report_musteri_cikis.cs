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
    public partial class report_musteri_cikis : Form
    {
        public report_musteri_cikis()
        {
            InitializeComponent();
        }

        private void musteri_Cikis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_Rzervasyon' table. You can move, or remove it, as needed.
            
            this.reportViewer1.RefreshReport();
        }
    }
}
