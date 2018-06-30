using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// giris combobxtan silinmesi gerek 
// 

namespace ResepsiyonOtomasyon
{
    public partial class WF_rezervasyon : Form
    {
        public WF_rezervasyon()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();

            if (txt_ad_soyad.Text == "" || txt_kimlik_no.Text == "" || txt_telefon.Text == "" || txt_aciklama.Text == "" )
            {
                MessageBox.Show("Bos bilgi birakmayin lutfeeen!");
            }
            else
            {
                tbl_rezervasyon rezerve = new tbl_rezervasyon();
                rezerve.KimlikSeriNo =Convert.ToInt32( txt_kimlik_no.Text);
                rezerve.OdaNo = Convert.ToInt32(cmb_oda_no.Text);
                rezerve.AdSoyad = txt_ad_soyad.Text;
                rezerve.Aciklama = txt_aciklama.Text;
                rezerve.Telefon = Convert.ToInt32(txt_telefon.Text);
                rezerve.Giristarih = dateTimePicker_giris_tarih.Value;
                rezerve.Cikistarih = dateTimePicker_cikis_tarih.Value;

                otel.tbl_rezervasyons.InsertOnSubmit(rezerve);
                otel.SubmitChanges();
                cagir();
                MessageBox.Show(" Basariyla Kaydedildi ☺ ");
            }

        }
        void cagir()
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();
            var query = from t in otel.tbl_rezervasyons
                        select t;
            dataGridView1.DataSource = query.ToList();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();

            DialogResult cevap = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(cevap==DialogResult.Yes)
            {
                var sil = otel.tbl_rezervasyons.Single(s => s.id == (int)dataGridView1.CurrentRow.Cells[0].Value);
                otel.tbl_rezervasyons.DeleteOnSubmit(sil);
                otel.SubmitChanges();            
                MessageBox.Show("Seciler Kayit Silindi");
                cagir();
            }          
        
        }

        private void WF_rezervasyon_Load(object sender, EventArgs e)
        {
            cagir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_kimlik_no.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cmb_oda_no.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_ad_soyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker_giris_tarih.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
                dateTimePicker_cikis_tarih.Value =(DateTime) dataGridView1.CurrentRow.Cells[5].Value;
                txt_telefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_aciklama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        private void btn_cikti_Click(object sender, EventArgs e)
        {
            report_rezervasyon report = new report_rezervasyon();
            report.Show();
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            txt_aciklama.Clear(); txt_ad_soyad.Clear(); txt_kimlik_no.Clear(); txt_telefon.Clear();
            

        }
    
        private void cmb_oda_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            otelResepsiyonDataContext otel = new otelResepsiyonDataContext();
            int odnom = Convert.ToInt32(cmb_oda_no.Text);
            if (otel.tbl_musteris.Any(q => q.odaNo == odnom))
            {
                MessageBox.Show("BU oda doludur degistiriniz");
            }
        }
    }
}
