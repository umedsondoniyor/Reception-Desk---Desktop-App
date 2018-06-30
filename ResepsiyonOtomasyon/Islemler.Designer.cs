namespace ResepsiyonOtomasyon
{
    partial class WF_islemler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.btnMusteriKayit = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.btnMusteri_cikis = new System.Windows.Forms.Button();
            this.btn_kullanicilar = new System.Windows.Forms.Button();
            this.lbl_kullanan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_gecmis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.Location = new System.Drawing.Point(183, 80);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(107, 23);
            this.btnRezervasyonYap.TabIndex = 0;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = true;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.Location = new System.Drawing.Point(183, 193);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(107, 23);
            this.btnOdalar.TabIndex = 1;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = true;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // btnMusteriKayit
            // 
            this.btnMusteriKayit.Location = new System.Drawing.Point(183, 109);
            this.btnMusteriKayit.Name = "btnMusteriKayit";
            this.btnMusteriKayit.Size = new System.Drawing.Size(107, 23);
            this.btnMusteriKayit.TabIndex = 2;
            this.btnMusteriKayit.Text = "Musteri Kayit";
            this.btnMusteriKayit.UseVisualStyleBackColor = true;
            this.btnMusteriKayit.Click += new System.EventHandler(this.btnMusteriKayit_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Location = new System.Drawing.Point(183, 164);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(107, 23);
            this.btnPersoneller.TabIndex = 3;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = true;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(183, 249);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(107, 23);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Cikis";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnBilgi
            // 
            this.btnBilgi.Location = new System.Drawing.Point(198, 51);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(75, 23);
            this.btnBilgi.TabIndex = 5;
            this.btnBilgi.Text = "Bilgi";
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.btnBilgi_Click);
            // 
            // btnMusteri_cikis
            // 
            this.btnMusteri_cikis.Location = new System.Drawing.Point(183, 137);
            this.btnMusteri_cikis.Name = "btnMusteri_cikis";
            this.btnMusteri_cikis.Size = new System.Drawing.Size(107, 23);
            this.btnMusteri_cikis.TabIndex = 6;
            this.btnMusteri_cikis.Text = "Musteri Cikis";
            this.btnMusteri_cikis.UseVisualStyleBackColor = true;
            this.btnMusteri_cikis.Click += new System.EventHandler(this.btnMusteriCikis_Click);
            // 
            // btn_kullanicilar
            // 
            this.btn_kullanicilar.Location = new System.Drawing.Point(183, 220);
            this.btn_kullanicilar.Name = "btn_kullanicilar";
            this.btn_kullanicilar.Size = new System.Drawing.Size(107, 23);
            this.btn_kullanicilar.TabIndex = 7;
            this.btn_kullanicilar.Text = "Kullanicilar ";
            this.btn_kullanicilar.UseVisualStyleBackColor = true;
            this.btn_kullanicilar.Click += new System.EventHandler(this.btn_kullanicilar_Click);
            // 
            // lbl_kullanan
            // 
            this.lbl_kullanan.AutoSize = true;
            this.lbl_kullanan.BackColor = System.Drawing.Color.Cyan;
            this.lbl_kullanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kullanan.Location = new System.Drawing.Point(109, 18);
            this.lbl_kullanan.Name = "lbl_kullanan";
            this.lbl_kullanan.Size = new System.Drawing.Size(52, 18);
            this.lbl_kullanan.TabIndex = 8;
            this.lbl_kullanan.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_gecmis
            // 
            this.btn_gecmis.Location = new System.Drawing.Point(334, 80);
            this.btn_gecmis.Name = "btn_gecmis";
            this.btn_gecmis.Size = new System.Drawing.Size(75, 23);
            this.btn_gecmis.TabIndex = 9;
            this.btn_gecmis.Text = "Gecmis";
            this.btn_gecmis.UseVisualStyleBackColor = true;
            this.btn_gecmis.Click += new System.EventHandler(this.btn_gecmis_Click);
            // 
            // WF_islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(476, 301);
            this.Controls.Add(this.btn_gecmis);
            this.Controls.Add(this.lbl_kullanan);
            this.Controls.Add(this.btn_kullanicilar);
            this.Controls.Add(this.btnMusteri_cikis);
            this.Controls.Add(this.btnBilgi);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.btnMusteriKayit);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Name = "WF_islemler";
            this.Text = "Islemler";
            this.Load += new System.EventHandler(this.WF_islemler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Button btnMusteriKayit;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.Button btnMusteri_cikis;
        private System.Windows.Forms.Button btn_kullanicilar;
        private System.Windows.Forms.Label lbl_kullanan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_gecmis;
    }
}