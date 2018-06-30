namespace ResepsiyonOtomasyon
{
    partial class gecmis
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
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_cikti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(12, 16);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(224, 20);
            this.txt_ara.TabIndex = 1;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(258, 16);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 2;
            this.btn_ara.Text = "Ara.";
            this.btn_ara.UseVisualStyleBackColor = true;
            // 
            // btn_cikti
            // 
            this.btn_cikti.Location = new System.Drawing.Point(711, 16);
            this.btn_cikti.Name = "btn_cikti";
            this.btn_cikti.Size = new System.Drawing.Size(75, 23);
            this.btn_cikti.TabIndex = 3;
            this.btn_cikti.Text = "Cikti.";
            this.btn_cikti.UseVisualStyleBackColor = true;
            // 
            // gecmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(798, 387);
            this.Controls.Add(this.btn_cikti);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.dataGridView1);
            this.Name = "gecmis";
            this.Text = "gecmis";
            this.Load += new System.EventHandler(this.gecmis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_cikti;
    }
}