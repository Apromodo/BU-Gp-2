namespace report_viewer_uygulamasi
{
    partial class Form1
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
            this.LH_ERPDataSet = new report_viewer_uygulamasi.LH_ERPDataSet();
            this.Tbl_Musteri_SiparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tbl_Musteri_SiparisTableAdapter = new report_viewer_uygulamasi.LH_ERPDataSetTableAdapters.Tbl_Musteri_SiparisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LH_ERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Musteri_SiparisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tbl_Musteri_SiparisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "report_viewer_uygulamasi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(828, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // LH_ERPDataSet
            // 
            this.LH_ERPDataSet.DataSetName = "LH_ERPDataSet";
            this.LH_ERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_Musteri_SiparisBindingSource
            // 
            this.Tbl_Musteri_SiparisBindingSource.DataMember = "Tbl_Musteri_Siparis";
            this.Tbl_Musteri_SiparisBindingSource.DataSource = this.LH_ERPDataSet;
            // 
            // Tbl_Musteri_SiparisTableAdapter
            // 
            this.Tbl_Musteri_SiparisTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 466);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LH_ERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Musteri_SiparisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_Musteri_SiparisBindingSource;
        private LH_ERPDataSet LH_ERPDataSet;
        private LH_ERPDataSetTableAdapters.Tbl_Musteri_SiparisTableAdapter Tbl_Musteri_SiparisTableAdapter;
    }
}

