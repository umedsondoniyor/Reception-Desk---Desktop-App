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
    public partial class WF_Personeller : Form
    {
        public WF_Personeller()
        {
            InitializeComponent();
        }


        private void btn_yeni_Click(object sender, EventArgs e)
        {
            txt_adi.Clear(); txt_adres.Clear(); txt_gorevi.Clear(); txt_mesai_saati.Clear();
            txt_mesai_ucret.Clear(); txt_soyadi.Clear(); txt_tc_no.Clear(); txt_tel_no.Clear();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();

            if(txt_adi.Text==""||txt_adres.Text==""||txt_gorevi.Text==""||txt_mesai_saati.Text==""||txt_mesai_ucret.Text==""||txt_soyadi.Text==""||txt_tc_no.Text==""||txt_tel_no.Text=="")
            {
                MessageBox.Show(" Lutfen Bilgileri Bos Birakmatiniz! ");
            }
            else
            {
                tbl_Personel personel = new tbl_Personel();
                personel.TCno =Convert.ToInt32( txt_tc_no.Text);
                personel.Adi = txt_adi.Text;
                personel.adress = txt_adres.Text;
                if (rbtn_bay.Checked)
                {
                    personel.Cinsiyet = rbtn_bay.Text;
                }
                else
                {
                    personel.Cinsiyet = rbtn_bayan.Text;
                }
                personel.dogumTarih = dateTimePicker_dogum_tarih.Value;
                personel.girisTarih = dateTimePicker_giris_tarih.Value;
                personel.gorevi = txt_gorevi.Text;
                
                if (rbtn_bekar.Checked)
                {
                    personel.MedeniHali = rbtn_bekar.Text;
                }
                else if (rbtn_dull.Checked)
                {
                    personel.MedeniHali = rbtn_dull.Text;
                }
                else
                {
                    personel.MedeniHali = rbtn_evli.Text;
                }
                personel.mesaiSaati =Convert.ToInt32( txt_mesai_saati.Text);
                personel.mesaiUcreti =Convert.ToInt32( txt_mesai_ucret.Text);
                personel.Soyadi = txt_soyadi.Text;
                personel.TelNo =Convert.ToInt32( txt_tel_no.Text);

                otel.tbl_Personels.InsertOnSubmit(personel);
                otel.SubmitChanges();
                cagir();
                MessageBox.Show(" Basariyla Kaydedildi ☺ ");
            }
        }

        void cagir()
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();
            var query = from t in otel.tbl_Personels
                        select t;
            dataGridView1.DataSource = query.ToList();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();

             DialogResult cevap = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             if (cevap == DialogResult.Yes)
             {
                 var sil = otel.tbl_Personels.Single(s => s.id == (int)dataGridView1.CurrentRow.Cells[0].Value);
                 otel.tbl_Personels.DeleteOnSubmit(sil);
                 otel.SubmitChanges();
                 MessageBox.Show("Seciler Kayit Silindi");
                 cagir();
             }
        }

        private void btn_cikti_Click(object sender, EventArgs e)
        {
            report_personeller personel = new report_personeller();
            personel.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_tc_no.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_adi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_soyadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                if (rbtn_bay.Checked)
                {
                    rbtn_bay.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                }
                else
                {
                    rbtn_bayan.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                }
                txt_tel_no.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_adres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_gorevi.Text=dataGridView1.CurrentRow.Cells[7].Value.ToString();        
                txt_mesai_saati.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
            catch { }
        }

        private void WF_Personeller_Load(object sender, EventArgs e)
        {
            cagir();
        }
    }
}
