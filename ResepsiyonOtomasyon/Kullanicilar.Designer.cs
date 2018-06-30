namespace ResepsiyonOtomasyon
{
    partial class WF_Kullanicilar
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullanici_ad = new System.Windows.Forms.TextBox();
            this.txt_Tc_no = new System.Windows.Forms.TextBox();
            this.txt_ad_soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ekle.Location = new System.Drawing.Point(191, 150);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 21;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(159, 113);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(135, 20);
            this.txt_sifre.TabIndex = 20;
            // 
            // txt_kullanici_ad
            // 
            this.txt_kullanici_ad.Location = new System.Drawing.Point(159, 87);
            this.txt_kullanici_ad.Name = "txt_kullanici_ad";
            this.txt_kullanici_ad.Size = new System.Drawing.Size(135, 20);
            this.txt_kullanici_ad.TabIndex = 19;
            // 
            // txt_Tc_no
            // 
            this.txt_Tc_no.Location = new System.Drawing.Point(159, 61);
            this.txt_Tc_no.Name = "txt_Tc_no";
            this.txt_Tc_no.Size = new System.Drawing.Size(135, 20);
            this.txt_Tc_no.TabIndex = 18;
            // 
            // txt_ad_soyad
            // 
            this.txt_ad_soyad.Location = new System.Drawing.Point(159, 35);
            this.txt_ad_soyad.Name = "txt_ad_soyad";
            this.txt_ad_soyad.Size = new System.Drawing.Size(135, 20);
            this.txt_ad_soyad.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(125, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(117, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "TC no :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(89, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kullanıcı Adi :";
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_ad_soyad.Location = new System.Drawing.Point(100, 38);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(59, 13);
            this.lbl_ad_soyad.TabIndex = 11;
            this.lbl_ad_soyad.Text = "Ad Soyad :";
            // 
            // WF_Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(414, 219);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici_ad);
            this.Controls.Add(this.txt_Tc_no);
            this.Controls.Add(this.txt_ad_soyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ad_soyad);
            this.Name = "WF_Kullanicilar";
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.WF_Kullanicilar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullanici_ad;
        private System.Windows.Forms.TextBox txt_Tc_no;
        private System.Windows.Forms.TextBox txt_ad_soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ad_soyad;
    }
}