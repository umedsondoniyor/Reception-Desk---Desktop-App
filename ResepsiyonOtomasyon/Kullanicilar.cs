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
    public partial class WF_Kullanicilar : Form
    {
        public WF_Kullanicilar()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();

            if (txt_ad_soyad.Text == "" || txt_Tc_no.Text == "" || txt_kullanici_ad.Text == "" || txt_sifre.Text == "")
            {
                MessageBox.Show("Lutfen bos birakmayin! ☺");
            }
            else
            {
                tbl_giri kullanici = new tbl_giri();
                kullanici.AdSoyad = txt_ad_soyad.Text;
                kullanici.TcNo = Convert.ToInt32(txt_Tc_no.Text);
                kullanici.Kullanici = txt_kullanici_ad.Text;
                kullanici.sifre = txt_sifre.Text;
                MessageBox.Show("Yeni Kullanici basariyla eklenndi! ☺  ");
            }
        }

        private void WF_Kullanicilar_Load(object sender, EventArgs e)
        {

        }

        
    }
}
