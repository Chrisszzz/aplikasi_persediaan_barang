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
    public partial class LaporanStok : Form
    {
        public LaporanStok()
        {
            InitializeComponent();
        }

        private void LaporanStok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokobuahDataSet.buah' table. You can move, or remove it, as needed.
            this.buahTableAdapter.Fill(this.tokobuahDataSet.buah);

            this.reportViewer1.RefreshReport();
        }
        public BindingSource getbuahBindingSource()
        {
            return buahBindingSource;
        }
    }
}
