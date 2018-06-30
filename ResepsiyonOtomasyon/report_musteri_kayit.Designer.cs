namespace ResepsiyonOtomasyon
{
    partial class report_musteri_kayit
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hotelDataSet1 = new ResepsiyonOtomasyon.hotelDataSet1();
            this.tbl_musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_musteriTableAdapter = new ResepsiyonOtomasyon.hotelDataSet1TableAdapters.tbl_musteriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_musteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_musteriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ResepsiyonOtomasyon.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(891, 463);
            this.reportViewer1.TabIndex = 0;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "hotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_musteriBindingSource
            // 
            this.tbl_musteriBindingSource.DataMember = "tbl_musteri";
            this.tbl_musteriBindingSource.DataSource = this.hotelDataSet1;
            // 
            // tbl_musteriTableAdapter
            // 
            this.tbl_musteriTableAdapter.ClearBeforeFill = true;
            // 
            // report_musteri_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 470);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_musteri_kayit";
            this.Text = "report_musteri_kayit";
            this.Load += new System.EventHandler(this.report_musteri_kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_musteriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_musteriBindingSource;
        private hotelDataSet1 hotelDataSet1;
        private hotelDataSet1TableAdapters.tbl_musteriTableAdapter tbl_musteriTableAdapter;
    }
}