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
    public partial class WF_islemler : Form
    {
        public WF_islemler()
        {
            InitializeComponent();
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            WF_bilgi bilgi = new WF_bilgi();
            bilgi.Show();
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            WF_rezervasyon rezervasyon = new WF_rezervasyon();
            rezervasyon.Show();
        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            Musteri_kayit musteriKayit = new Musteri_kayit();
            musteriKayit.Show();
        }

        private void btnMusteriCikis_Click(object sender, EventArgs e)
        {
            WF_MusteriCikis musteriCikis = new WF_MusteriCikis();
            musteriCikis.Show();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            WF_Personeller personeller = new WF_Personeller();
            personeller.Show();
        }
        private void btn_kullanicilar_Click(object sender, EventArgs e)
        {
            WF_Kullanicilar kullanici = new WF_Kullanicilar();
            kullanici.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            WF_Odalar_Durumu odalarDurum = new WF_Odalar_Durumu();
            odalarDurum.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WF_islemler_Load(object sender, EventArgs e)
        {
            lbl_kullanan.Text = " Hos geldiniz sayin " + WF_giris.deger + " Bey ";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_kullanan.Text = lbl_kullanan.Text.Substring(1) + lbl_kullanan.Text.Substring(0, 1);
           
        }

        private void btn_gecmis_Click(object sender, EventArgs e)
        {
            gecmis gecms = new gecmis();         
            gecms.Show();
        }

       
    }
}
