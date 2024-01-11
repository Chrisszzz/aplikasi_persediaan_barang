namespace aplikasi_tokobuah_UAS_ABD
{
    partial class laporanpenjualan
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
            this.tokobuahDataSet2 = new aplikasi_tokobuah_UAS_ABD.tokobuahDataSet2();
            this.itemnotajualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemnotajualTableAdapter = new aplikasi_tokobuah_UAS_ABD.tokobuahDataSet2TableAdapters.itemnotajualTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tokobuahDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemnotajualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.itemnotajualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "aplikasi_tokobuah_UAS_ABD.laporanpenjualan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 487);
            this.reportViewer1.TabIndex = 0;
            // 
            // tokobuahDataSet2
            // 
            this.tokobuahDataSet2.DataSetName = "tokobuahDataSet2";
            this.tokobuahDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemnotajualBindingSource
            // 
            this.itemnotajualBindingSource.DataMember = "itemnotajual";
            this.itemnotajualBindingSource.DataSource = this.tokobuahDataSet2;
            // 
            // itemnotajualTableAdapter
            // 
            this.itemnotajualTableAdapter.ClearBeforeFill = true;
            // 
            // laporanpenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 485);
            this.Controls.Add(this.reportViewer1);
            this.Name = "laporanpenjualan";
            this.Text = "laporanpenjualan";
            this.Load += new System.EventHandler(this.laporanpenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tokobuahDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemnotajualBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource itemnotajualBindingSource;
        private tokobuahDataSet2 tokobuahDataSet2;
        private tokobuahDataSet2TableAdapters.itemnotajualTableAdapter itemnotajualTableAdapter;
    }
}