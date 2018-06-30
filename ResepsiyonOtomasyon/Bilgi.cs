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
    public partial class WF_bilgi : Form
    {
        public WF_bilgi()
        {
            InitializeComponent();
        }
   
        private void WF_bilgi_Load(object sender, EventArgs e)
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();//verilerin veritabaninda degisiklikler yapmak icin dataContex kullanilir
            var musteriSayisi = (from otel1 in otel.tbl_musteris select otel1.id).Count();
            lblTopMustSayisi.Text = musteriSayisi.ToString();
            
        }
       
    }
}
