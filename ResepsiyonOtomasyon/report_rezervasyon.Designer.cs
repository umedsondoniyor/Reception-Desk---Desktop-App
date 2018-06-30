namespace ResepsiyonOtomasyon
{
    partial class report_rezervasyon
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
            this.tbl_rezervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_rezervasyonTableAdapter = new ResepsiyonOtomasyon.hotelDataSet1TableAdapters.tbl_rezervasyonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_rezervasyonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_rezervasyonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ResepsiyonOtomasyon.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(715, 348);
            this.reportViewer1.TabIndex = 0;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "hotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_rezervasyonBindingSource
            // 
            this.tbl_rezervasyonBindingSource.DataMember = "tbl_rezervasyon";
            this.tbl_rezervasyonBindingSource.DataSource = this.hotelDataSet1;
            // 
            // tbl_rezervasyonTableAdapter
            // 
            this.tbl_rezervasyonTableAdapter.ClearBeforeFill = true;
            // 
            // report_rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 351);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_rezervasyon";
            this.Text = "report_rezervasyon";
            this.Load += new System.EventHandler(this.report_rezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_rezervasyonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_rezervasyonBindingSource;
        private hotelDataSet1 hotelDataSet1;
        private hotelDataSet1TableAdapters.tbl_rezervasyonTableAdapter tbl_rezervasyonTableAdapter;
    }
}