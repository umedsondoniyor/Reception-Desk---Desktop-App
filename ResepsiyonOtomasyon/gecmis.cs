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
    public partial class gecmis : Form
    {
        public gecmis()
        {
            InitializeComponent();
        }
        otelResepsiyonDataContext otel = new otelResepsiyonDataContext();

        private void gecmis_Load(object sender, EventArgs e)
        {
            var sorgumm = (from a in otel.tbl_gecmis
                           select a).OrderBy(q => q.AdiSoyadi).ToList();
            dataGridView1.DataSource = sorgumm;
            
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            var arama = from ara in otel.tbl_gecmis
                        where ara.AdiSoyadi.Contains(txt_ara.Text)
                        select ara;
            dataGridView1.DataSource = arama;
           if(txt_ara.Text == null || txt_ara.Text == "")
           {
               var sorgumm = (from a in otel.tbl_gecmis
                              select a).OrderBy(q => q.AdiSoyadi).ToList();
               dataGridView1.DataSource = sorgumm;
           }
        }
    }
}
