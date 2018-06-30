namespace ResepsiyonOtomasyon
{
    partial class WF_MusteriCikis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_oda_fiyati = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_kalinan_gun_sayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_toplam_ucret = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_cikti = new System.Windows.Forms.Button();
            this.btn_kayit_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Oda Fiyati / Room Price :";
            // 
            // lbl_oda_fiyati
            // 
            this.lbl_oda_fiyati.AutoSize = true;
            this.lbl_oda_fiyati.Location = new System.Drawing.Point(145, 229);
            this.lbl_oda_fiyati.Name = "lbl_oda_fiyati";
            this.lbl_oda_fiyati.Size = new System.Drawing.Size(34, 13);
            this.lbl_oda_fiyati.TabIndex = 17;
            this.lbl_oda_fiyati.Text = "00.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kalinan Gun Sayisi / Number of days stayed :";
            // 
            // lbl_kalinan_gun_sayisi
            // 
            this.lbl_kalinan_gun_sayisi.AutoSize = true;
            this.lbl_kalinan_gun_sayisi.Location = new System.Drawing.Point(238, 256);
            this.lbl_kalinan_gun_sayisi.Name = "lbl_kalinan_gun_sayisi";
            this.lbl_kalinan_gun_sayisi.Size = new System.Drawing.Size(13, 13);
            this.lbl_kalinan_gun_sayisi.TabIndex = 19;
            this.lbl_kalinan_gun_sayisi.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Toplam ucret / Total fee :";
            // 
            // lbl_toplam_ucret
            // 
            this.lbl_toplam_ucret.AutoSize = true;
            this.lbl_toplam_ucret.Location = new System.Drawing.Point(145, 282);
            this.lbl_toplam_ucret.Name = "lbl_toplam_ucret";
            this.lbl_toplam_ucret.Size = new System.Drawing.Size(34, 13);
            this.lbl_toplam_ucret.TabIndex = 21;
            this.lbl_toplam_ucret.Text = "00.00";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(15, 328);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 22;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_cikti
            // 
            this.btn_cikti.Location = new System.Drawing.Point(599, 328);
            this.btn_cikti.Name = "btn_cikti";
            this.btn_cikti.Size = new System.Drawing.Size(75, 23);
            this.btn_cikti.TabIndex = 23;
            this.btn_cikti.Text = "Cikti";
            this.btn_cikti.UseVisualStyleBackColor = true;
            this.btn_cikti.Click += new System.EventHandler(this.btn_cikti_Click);
            // 
            // btn_kayit_sil
            // 
            this.btn_kayit_sil.Location = new System.Drawing.Point(599, 301);
            this.btn_kayit_sil.Name = "btn_kayit_sil";
            this.btn_kayit_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_kayit_sil.TabIndex = 24;
            this.btn_kayit_sil.Text = "Kayit Sil";
            this.btn_kayit_sil.UseVisualStyleBackColor = true;
            this.btn_kayit_sil.Click += new System.EventHandler(this.btn_kayit_sil_Click);
            // 
            // WF_MusteriCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(686, 373);
            this.Controls.Add(this.btn_kayit_sil);
            this.Controls.Add(this.btn_cikti);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.lbl_toplam_ucret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_kalinan_gun_sayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_oda_fiyati);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WF_MusteriCikis";
            this.Text = "Musteri Cikis";
            this.Load += new System.EventHandler(this.WF_MusteriCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_oda_fiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_kalinan_gun_sayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_toplam_ucret;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_cikti;
        private System.Windows.Forms.Button btn_kayit_sil;
    }
}