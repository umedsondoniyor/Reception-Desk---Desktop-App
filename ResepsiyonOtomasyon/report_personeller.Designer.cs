namespace ResepsiyonOtomasyon
{
    partial class report_personeller
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
            this.hotelDataSet2 = new ResepsiyonOtomasyon.hotelDataSet2();
            this.tbl_PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonelTableAdapter = new ResepsiyonOtomasyon.hotelDataSet2TableAdapters.tbl_PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PersonelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ResepsiyonOtomasyon.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(787, 342);
            this.reportViewer1.TabIndex = 0;
            // 
            // hotelDataSet2
            // 
            this.hotelDataSet2.DataSetName = "hotelDataSet2";
            this.hotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelBindingSource
            // 
            this.tbl_PersonelBindingSource.DataMember = "tbl_Personel";
            this.tbl_PersonelBindingSource.DataSource = this.hotelDataSet2;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // report_personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 344);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_personeller";
            this.Text = "report_personeller";
            this.Load += new System.EventHandler(this.report_personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PersonelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_PersonelBindingSource;
        private hotelDataSet2 hotelDataSet2;
        private hotelDataSet2TableAdapters.tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
    }
}