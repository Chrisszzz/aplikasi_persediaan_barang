using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aplikasi_tokobuah_UAS_ABD
{
    public partial class laporanpenjualan : Form
    {
        public laporanpenjualan()
        {
            InitializeComponent();
        }

        private void laporanpenjualan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokobuahDataSet2.itemnotajual' table. You can move, or remove it, as needed.
            this.itemnotajualTableAdapter.Fill(this.tokobuahDataSet2.itemnotajual);

            this.reportViewer1.RefreshReport();
        }

        public BindingSource getitemnotajualBindingSource()
        {
            return itemnotajualBindingSource;
        }
    }
}
