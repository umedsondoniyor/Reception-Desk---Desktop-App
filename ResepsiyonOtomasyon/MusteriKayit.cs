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
    public partial class Musteri_kayit : Form
    {
       
        public Musteri_kayit()
        {
            InitializeComponent();
        }
        private void Musteri_kayit_Load(object sender, EventArgs e)
        {
            cagir();

        }
       
        otelResepsiyonDataContext otel = new otelResepsiyonDataContext();
        private void btn_yeni_Click(object sender, EventArgs e)
        {
            txt_ad_soyad.Clear(); txt_adres.Clear(); txt_ana_adi.Clear(); txt_baba_adi.Clear(); txt_cep_tel.Clear();
            txt_dogum_yeri.Clear(); txt_email.Clear(); txt_ev_tel.Clear(); txt_is_tel.Clear(); txt_kisi_sayisi.Clear();
            txt_not.Clear(); txt_pasaport_no.Clear(); txt_sehir.Clear(); txt_seri_no.Clear(); txt_ulke.Clear();
            txt_verildigi_ulke.Clear(); cmb_oda_no.Text = "";
        }
        tbl_musteri must = new tbl_musteri();
        void cagir()
        {
          //  otelResepsiyonDataContext otel = new otelResepsiyonDataContext();
            var query = from t in otel.tbl_musteris
                        select t;
            dataGridView1.DataSource = query.ToList();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_ad_soyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_cep_tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_is_tel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_ev_tel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_email.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_ulke.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                dateTimePicker_giris_tarih.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker_cikis_tarih.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                txt_kisi_sayisi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txt_sehir.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txt_seri_no.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                txt_ana_adi.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                txt_baba_adi.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                txt_dogum_yeri.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();

                dateTimePicker_dogum_tarih.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();

                txt_pasaport_no.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                txt_verildigi_ulke.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();

                dateTimePicker_verildigi_tarih.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                dateTimePicker_bitis_tarih.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();

                txt_not.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                txt_adres.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();

                if (rbt_bay.Checked)
                {
                    rbt_bay.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                }
                else if (rbt_bayan.Checked)
                {
                    rbt_bayan.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                }

                 cmb_oda_no.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
                

                //if (cmb_oda_no.Text == "")
                //{
                //    cmb_oda_no.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
                //}
                //else
                //{
                //    cmb_oda_no.Text = "1";
                //}

            }
            catch { }

        }
      
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
           
           
           
                if (txt_ad_soyad.Text == "" || txt_email.Text == "" || cmb_oda_no.Text == "")
                {
                    MessageBox.Show("Yildizli bilgileri bos birakmayiniz lutfeeen!");
                }
                else
                {


                    must.AdiSoyadi = txt_ad_soyad.Text;
                    must.Adres = txt_adres.Text;
                    must.CepTel = Convert.ToInt32(txt_cep_tel.Text);
                    must.cikisTarih = dateTimePicker_cikis_tarih.Value;
                    must.EvTel = Convert.ToInt32(txt_ev_tel.Text);
                    must.girisTarih = dateTimePicker_giris_tarih.Value;
                    must.isTel = Convert.ToInt32(txt_is_tel.Text);
                    must.KisiSayisi = Convert.ToInt32(txt_kisi_sayisi.Text);
                    must.mailAdress = txt_email.Text;
                    must.odaNo = Convert.ToInt32(cmb_oda_no.Text);
                    must.sehir = txt_sehir.Text;
                    must.Ulke = txt_ulke.Text;

                    //otel.tbl_musteris.InsertOnSubmit(must);
                    //otel.SubmitChanges();
                    //cagir();
                    //MessageBox.Show(" Basariyla Kaydedildi ☺ ");

                    if (rbt_kimlik_bilgiler.Checked)
                    {
                        
                        if (otel.tbl_musteris.Any(q => q.seriNo == txt_seri_no.Text))
                        {
                            MessageBox.Show("Bu seri no zaten kayitta");
                        }
                        else
                        {
                            if (txt_seri_no.Text == "" || txt_ana_adi.Text == "" || txt_baba_adi.Text == "" || txt_dogum_yeri.Text == "")
                            {
                                MessageBox.Show("Kimlik Bilgilerinin Yildizli bilgileri bos birakmayiniz lutfeeen!");
                            }
                            else
                            {
                                must.seriNo = txt_seri_no.Text;
                                must.AnaAdi = txt_ana_adi.Text;
                                must.BabaAdi = txt_baba_adi.Text;
                                must.Dogumyeri = txt_dogum_yeri.Text;
                                must.DogumTarih = dateTimePicker_dogum_tarih.Value;
                                if (rbt_bay.Checked)
                                {
                                    must.cinsiyet = rbt_bay.Text;
                                }
                                else if (rbt_bayan.Checked)
                                {
                                    must.cinsiyet = rbt_bayan.Text;

                                }

                                //otel.tbl_musteris.InsertOnSubmit(must);
                                //otel.SubmitChanges();
                                //cagir();
                                //MessageBox.Show(" Basariyla Kaydedildi ☺ ");

                            }
                        }
                    }
                    else if (rbt_pasaport_bilgiler.Checked)
                    {
                        if (otel.tbl_musteris.Any(q => q.PasaportNo == txt_pasaport_no.Text))
                        {
                            MessageBox.Show("Bu pasaport var zten");
                        }
                        else
                        {
                            if (txt_pasaport_no.Text == "" || txt_verildigi_ulke.Text == "")
                            {
                                MessageBox.Show("Pasaport Bilgilerinin Yildizli bilgileri bos birakmayiniz lutfeeen!");
                            }
                            else
                            {
                                must.PasaportNo = txt_pasaport_no.Text;
                                must.VerildigiUlke = txt_verildigi_ulke.Text;
                                must.VerildigiTarih = dateTimePicker_verildigi_tarih.Value;
                                must.BitisTarih = dateTimePicker_bitis_tarih.Value;
                                must.NotBilgi = txt_not.Text;

                                //otel.tbl_musteris.InsertOnSubmit(must);
                                //otel.SubmitChanges();
                                //cagir();
                                //MessageBox.Show(" Basariyla Kaydedildi ☺ ");
                            }
                        }
                    }
                   
                    otel.tbl_musteris.InsertOnSubmit(must);
                    otel.SubmitChanges();
                    cagir();
                    MessageBox.Show(" Basariyla Kaydedildi ☺ ");
             
                } // bitis
            
        }


        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            var update = otel.tbl_musteris.Single(q => q.id == (int)dataGridView1.CurrentRow.Cells[0].Value);
            update.isTel =Convert.ToInt32( txt_is_tel.Text);
            update.KisiSayisi = Convert.ToInt32(txt_kisi_sayisi.Text);
            update.odaNo = Convert.ToInt32(cmb_oda_no.Text);
            update.AdiSoyadi = txt_ad_soyad.Text;
            update.Adres = txt_adres.Text;
            update.girisTarih = dateTimePicker_giris_tarih.Value;
            update.mailAdress = txt_email.Text;
            update.CepTel =Convert.ToInt32( txt_cep_tel.Text);
            update.cikisTarih = dateTimePicker_cikis_tarih.Value;

            if (rbt_kimlik_bilgiler.Checked)
            {

                if (otel.tbl_musteris.Any(q => q.seriNo == txt_seri_no.Text))
                {
                    MessageBox.Show("Bu seri no zaten kayitta");
                }
                else
                {
                    if (txt_seri_no.Text == "" || txt_ana_adi.Text == "" || txt_baba_adi.Text == "" || txt_dogum_yeri.Text == "")
                    {
                        MessageBox.Show("Kimlik Bilgilerinin Yildizli bilgileri bos birakmayiniz lutfeeen!");
                    }
                    else
                    {
                       update.seriNo = txt_seri_no.Text;
                       update.AnaAdi = txt_ana_adi.Text;
                       update.BabaAdi = txt_baba_adi.Text;
                       update.Dogumyeri = txt_dogum_yeri.Text;
                       update.DogumTarih = dateTimePicker_dogum_tarih.Value;
                        if (rbt_bay.Checked)
                        {
                            must.cinsiyet = rbt_bay.Text;
                        }
                        else if (rbt_bayan.Checked)
                        {
                            must.cinsiyet = rbt_bayan.Text;

                        }

                        //otel.tbl_musteris.InsertOnSubmit(must);
                        //otel.SubmitChanges();
                        //cagir();
                        //MessageBox.Show(" Basariyla Kaydedildi ☺ ");

                    }
                }

            }
            else if (rbt_pasaport_bilgiler.Checked)
            {
                if (otel.tbl_musteris.Any(q => q.PasaportNo == txt_pasaport_no.Text))
                {
                    MessageBox.Show("Bu pasaport var zten");
                }
                else
                {
                    if (txt_pasaport_no.Text == "" || txt_verildigi_ulke.Text == "")
                    {
                        MessageBox.Show("Pasaport Bilgilerinin Yildizli bilgileri bos birakmayiniz lutfeeen!");
                    }
                    else
                    {
                        update.PasaportNo = txt_pasaport_no.Text;
                        update.VerildigiUlke = txt_verildigi_ulke.Text;
                        update.VerildigiTarih = dateTimePicker_verildigi_tarih.Value;
                        update.BitisTarih = dateTimePicker_bitis_tarih.Value;
                        update.NotBilgi = txt_not.Text;

                        //otel.tbl_musteris.InsertOnSubmit(must);
                        //otel.SubmitChanges();
                        //cagir();
                        //MessageBox.Show(" Basariyla Kaydedildi ☺ ");
                    }
                }
            }                                      
            //devamini yaza oglum unutma haa!
            otel.SubmitChanges();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            otelResepsiyonDataContext motel = new otelResepsiyonDataContext();
            #region sildikten sonra kayt ettigimiz yer
            var gecmis = new tbl_gecmi();
                gecmis.AdiSoyadi = txt_ad_soyad.Text;
                gecmis.Adres = txt_adres.Text;
                if (txt_cep_tel.Text == "")
                {
                    txt_cep_tel.Text = "0";
                    gecmis.CepTel = Convert.ToInt32(txt_cep_tel.Text);
                }
                else
                    gecmis.CepTel = Convert.ToInt32(txt_cep_tel.Text);
                gecmis.cikisTarih = dateTimePicker_cikis_tarih.Value;
                if (txt_ev_tel.Text == "")
                {
                    txt_ev_tel.Text = "0";
                    gecmis.EvTel = Convert.ToInt32(txt_ev_tel.Text);
                }
                else
                    gecmis.EvTel = Convert.ToInt32(txt_ev_tel.Text);
                gecmis.girisTarih = dateTimePicker_giris_tarih.Value;
                if (txt_is_tel.Text == "")
                {
                    txt_is_tel.Text = "0";
                    gecmis.isTel = Convert.ToInt32(txt_is_tel.Text);
                }
                else
                    gecmis.isTel = Convert.ToInt32(txt_is_tel.Text);
                if (txt_kisi_sayisi.Text == "")
                {
                    txt_kisi_sayisi.Text = "0";
                    gecmis.KisiSayisi = Convert.ToInt32(txt_kisi_sayisi.Text);
                }
                else
                gecmis.KisiSayisi = Convert.ToInt32(txt_kisi_sayisi.Text);
                gecmis.mailAdress = txt_email.Text;
                gecmis.odaNo = Convert.ToInt32(cmb_oda_no.Text);
                gecmis.sehir = txt_sehir.Text;
                gecmis.Ulke = txt_ulke.Text;
                gecmis.seriNo = txt_seri_no.Text;
                gecmis.AnaAdi = txt_ana_adi.Text;
                gecmis.BabaAdi = txt_baba_adi.Text;
                gecmis.Dogumyeri = txt_dogum_yeri.Text;
                gecmis.DogumTarih = dateTimePicker_dogum_tarih.Value;
                gecmis.cinsiyet = rbt_bay.Text;                    
                gecmis.cinsiyet = rbt_bayan.Text;
                gecmis.PasaportNo = txt_pasaport_no.Text;
                gecmis.VerildigiUlke = txt_verildigi_ulke.Text;
                gecmis.VerildigiTarih = dateTimePicker_verildigi_tarih.Value;
                gecmis.BitisTarih = dateTimePicker_bitis_tarih.Value;
                gecmis.NotBilgi = txt_not.Text;               
                motel.tbl_gecmis.InsertOnSubmit(gecmis);
                motel.SubmitChanges();
                       
                        MessageBox.Show(" Basariyla  Arsive Kaydedildi ☺ ");
                
        
            #endregion

            #region
            DialogResult cevap = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                var sil = otel.tbl_musteris.Single(s => s.id == (int)dataGridView1.CurrentRow.Cells[0].Value);
                otel.tbl_musteris.DeleteOnSubmit(sil);
                otel.SubmitChanges();
                MessageBox.Show("Seciler Kayit Silindi");
                cagir();
            }
            #endregion
        }

        private void btn_cikti_Click(object sender, EventArgs e)
        {
            report_musteri_kayit report = new report_musteri_kayit();
            report.Show();
        }
              
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                var arama = from a in otel.tbl_musteris
                            where a.AdiSoyadi.Contains(textBox2.Text)
                            select a;
                dataGridView1.DataSource = arama;
            }
            else if (textBox2.Text == "")
                cagir();

        }

        private void txt_seri_no_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_oda_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            int odnom = Convert.ToInt32(cmb_oda_no.Text);
            if( otel.tbl_musteris.Any(q => q.odaNo == odnom))
            {
                MessageBox.Show("BU oda doludur degistiriniz");
            }
        }

      

       
    }
}
