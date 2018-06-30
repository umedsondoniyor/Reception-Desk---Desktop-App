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
    public partial class WF_MusteriCikis : Form
    {
        public WF_MusteriCikis()
        {
            InitializeComponent();
        }

        private void btn_cikti_Click(object sender, EventArgs e)
        {
            report_musteri_cikis report = new report_musteri_cikis();
            report.Show();
        }

        private void btn_kayit_sil_Click(object sender, EventArgs e)
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();


            DialogResult cevap = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                var sil = otel.tbl_musteris.Single(s => s.id == (int)dataGridView1.CurrentRow.Cells[0].Value);
                otel.tbl_musteris.DeleteOnSubmit(sil);
                otel.SubmitChanges();
                MessageBox.Show("Secilen Kayit Silindi");
                cagir();
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();
           var giridigigun = (from t in otel.tbl_musteris
                                    where t.id == (int)dataGridView1.CurrentRow.Cells[0].Value
                                    select t.girisTarih).FirstOrDefault();
            
            var ciktigigun = (from t in otel.tbl_musteris
                                    where t.id == (int)dataGridView1.CurrentRow.Cells[0].Value
                                    select t.cikisTarih).FirstOrDefault();
            TimeSpan kaldigi = ciktigigun.Value - giridigigun.Value;
           int kalinangun = Convert.ToInt32(kaldigi.Days);
           lbl_kalinan_gun_sayisi.Text = kalinangun.ToString();


           var odaNo = (from t in otel.tbl_musteris
                        where t.id == (int)dataGridView1.CurrentRow.Cells[0].Value
                        select t.odaNo).FirstOrDefault();
           if ((int)odaNo == 1 || (int)odaNo == 2 || (int)odaNo == 3 || (int)odaNo == 4 || (int)odaNo == 5 || (int)odaNo == 6)
           {
               lbl_toplam_ucret.Text = (Convert.ToInt32(lbl_kalinan_gun_sayisi.Text) * 50).ToString();
               lbl_oda_fiyati.Text = "50 TL";
           }
           else if ((int)odaNo == 16 || (int)odaNo == 17 || (int)odaNo == 18 || (int)odaNo == 19 || (int)odaNo == 20)
           {
               lbl_toplam_ucret.Text = (Convert.ToInt32(lbl_kalinan_gun_sayisi.Text) * 100).ToString();
               lbl_oda_fiyati.Text = "100 TL";
           }
           else
           {
               lbl_toplam_ucret.Text = (Convert.ToInt32(lbl_kalinan_gun_sayisi.Text) * 150).ToString();
               lbl_oda_fiyati.Text = "150 TL";
           }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        void cagir()
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();
            var query = from t in otel.tbl_musteris
                        select t;
            dataGridView1.DataSource = query.ToList();
        }
        private void WF_MusteriCikis_Load(object sender, EventArgs e)
        {
            cagir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
