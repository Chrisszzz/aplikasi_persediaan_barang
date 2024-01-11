namespace aplikasi_tokobuah_UAS_ABD
{
    partial class Laporan_pembelian
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
            this.tokobuahDataSet1 = new aplikasi_tokobuah_UAS_ABD.tokobuahDataSet1();
            this.itemnotabeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemnotabeliTableAdapter = new aplikasi_tokobuah_UAS_ABD.tokobuahDataSet1TableAdapters.itemnotabeliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tokobuahDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemnotabeliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.itemnotabeliBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "aplikasi_tokobuah_UAS_ABD.laporan pembelian.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(825, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // tokobuahDataSet1
            // 
            this.tokobuahDataSet1.DataSetName = "tokobuahDataSet1";
            this.tokobuahDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemnotabeliBindingSource
            // 
            this.itemnotabeliBindingSource.DataMember = "itemnotabeli";
            this.itemnotabeliBindingSource.DataSource = this.tokobuahDataSet1;
            // 
            // itemnotabeliTableAdapter
            // 
            this.itemnotabeliTableAdapter.ClearBeforeFill = true;
            // 
            // Laporan_pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 503);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Laporan_pembelian";
            this.Text = "Laporan_pembelian";
            this.Load += new System.EventHandler(this.Laporan_pembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tokobuahDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemnotabeliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource itemnotabeliBindingSource;
        private tokobuahDataSet1 tokobuahDataSet1;
        private tokobuahDataSet1TableAdapters.itemnotabeliTableAdapter itemnotabeliTableAdapter;
    }
}