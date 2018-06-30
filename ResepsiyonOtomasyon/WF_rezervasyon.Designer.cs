namespace ResepsiyonOtomasyon
{
    partial class WF_rezervasyon
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
            this.btn_cikti = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.dateTimePicker_giris_tarih = new System.Windows.Forms.DateTimePicker();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_ad_soyad = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.cmb_oda_no = new System.Windows.Forms.ComboBox();
            this.txt_kimlik_no = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_cikis_tarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_yeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(768, 207);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btn_cikti
            // 
            this.btn_cikti.Location = new System.Drawing.Point(709, 196);
            this.btn_cikti.Name = "btn_cikti";
            this.btn_cikti.Size = new System.Drawing.Size(75, 23);
            this.btn_cikti.TabIndex = 46;
            this.btn_cikti.Text = "Cikti";
            this.btn_cikti.UseVisualStyleBackColor = true;
            this.btn_cikti.Click += new System.EventHandler(this.btn_cikti_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(631, 196);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 45;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(551, 196);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(75, 23);
            this.btn_kayit.TabIndex = 44;
            this.btn_kayit.Text = "Kayit";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // dateTimePicker_giris_tarih
            // 
            this.dateTimePicker_giris_tarih.Location = new System.Drawing.Point(81, 87);
            this.dateTimePicker_giris_tarih.Name = "dateTimePicker_giris_tarih";
            this.dateTimePicker_giris_tarih.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker_giris_tarih.TabIndex = 43;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(81, 145);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(264, 74);
            this.txt_aciklama.TabIndex = 42;
            // 
            // txt_ad_soyad
            // 
            this.txt_ad_soyad.Location = new System.Drawing.Point(81, 61);
            this.txt_ad_soyad.Name = "txt_ad_soyad";
            this.txt_ad_soyad.Size = new System.Drawing.Size(264, 20);
            this.txt_ad_soyad.TabIndex = 41;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(81, 119);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(133, 20);
            this.txt_telefon.TabIndex = 40;
            // 
            // cmb_oda_no
            // 
            this.cmb_oda_no.FormattingEnabled = true;
            this.cmb_oda_no.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmb_oda_no.Location = new System.Drawing.Point(81, 34);
            this.cmb_oda_no.Name = "cmb_oda_no";
            this.cmb_oda_no.Size = new System.Drawing.Size(133, 21);
            this.cmb_oda_no.TabIndex = 39;
            this.cmb_oda_no.SelectedIndexChanged += new System.EventHandler(this.cmb_oda_no_SelectedIndexChanged);
            // 
            // txt_kimlik_no
            // 
            this.txt_kimlik_no.Location = new System.Drawing.Point(81, 8);
            this.txt_kimlik_no.Name = "txt_kimlik_no";
            this.txt_kimlik_no.Size = new System.Drawing.Size(264, 20);
            this.txt_kimlik_no.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Aciklama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Giris Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Oda No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Kimlik Seri No :";
            // 
            // dateTimePicker_cikis_tarih
            // 
            this.dateTimePicker_cikis_tarih.Location = new System.Drawing.Point(395, 87);
            this.dateTimePicker_cikis_tarih.Name = "dateTimePicker_cikis_tarih";
            this.dateTimePicker_cikis_tarih.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker_cikis_tarih.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Cikis Tarihi :";
            // 
            // btn_yeni
            // 
            this.btn_yeni.Location = new System.Drawing.Point(470, 196);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(75, 23);
            this.btn_yeni.TabIndex = 50;
            this.btn_yeni.Text = "Yeni";
            this.btn_yeni.UseVisualStyleBackColor = true;
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // WF_rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(801, 441);
            this.Controls.Add(this.btn_yeni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker_cikis_tarih);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cikti);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.dateTimePicker_giris_tarih);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.txt_ad_soyad);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.cmb_oda_no);
            this.Controls.Add(this.txt_kimlik_no);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WF_rezervasyon";
            this.Text = "Rezervazyon";
            this.Load += new System.EventHandler(this.WF_rezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cikti;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_giris_tarih;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_ad_soyad;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.ComboBox cmb_oda_no;
        private System.Windows.Forms.TextBox txt_kimlik_no;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_cikis_tarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_yeni;
    }
}