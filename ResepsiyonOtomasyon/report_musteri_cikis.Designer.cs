namespace ResepsiyonOtomasyon
{
    partial class report_musteri_cikis
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
            this.hotelDataSet = new ResepsiyonOtomasyon.hotelDataSet();
            this.tbl_RzervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RzervasyonTableAdapter = new ResepsiyonOtomasyon.hotelDataSetTableAdapters.tbl_RzervasyonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_RzervasyonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_RzervasyonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ResepsiyonOtomasyon.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(995, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_RzervasyonBindingSource
            // 
            this.tbl_RzervasyonBindingSource.DataMember = "tbl_Rzervasyon";
            this.tbl_RzervasyonBindingSource.DataSource = this.hotelDataSet;
            // 
            // tbl_RzervasyonTableAdapter
            // 
            this.tbl_RzervasyonTableAdapter.ClearBeforeFill = true;
            // 
            // musteri_Cikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 400);
            this.Controls.Add(this.reportViewer1);
            this.Name = "musteri_Cikis";
            this.Text = "musteri_Cikis";
            this.Load += new System.EventHandler(this.musteri_Cikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_RzervasyonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_RzervasyonBindingSource;
        private hotelDataSet hotelDataSet;
        private hotelDataSetTableAdapters.tbl_RzervasyonTableAdapter tbl_RzervasyonTableAdapter;
    }
}