namespace aplikasi_tokobuah_UAS_ABD
{
    partial class LaporanStok
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
            this.tokobuahDataSet = new aplikasi_tokobuah_UAS_ABD.tokobuahDataSet();
            this.buahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buahTableAdapter = new aplikasi_tokobuah_UAS_ABD.tokobuahDataSetTableAdapters.buahTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tokobuahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buahBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetBuah";
            reportDataSource1.Value = this.buahBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "aplikasi_tokobuah_UAS_ABD.laporan stok.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(698, 382);
            this.reportViewer1.TabIndex = 0;
            // 
            // tokobuahDataSet
            // 
            this.tokobuahDataSet.DataSetName = "tokobuahDataSet";
            this.tokobuahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buahBindingSource
            // 
            this.buahBindingSource.DataMember = "buah";
            this.buahBindingSource.DataSource = this.tokobuahDataSet;
            // 
            // buahTableAdapter
            // 
            this.buahTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 383);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LaporanStok";
            this.Text = "LaporanStok";
            this.Load += new System.EventHandler(this.LaporanStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tokobuahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buahBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource buahBindingSource;
        private tokobuahDataSet tokobuahDataSet;
        private tokobuahDataSetTableAdapters.buahTableAdapter buahTableAdapter;
    }
}