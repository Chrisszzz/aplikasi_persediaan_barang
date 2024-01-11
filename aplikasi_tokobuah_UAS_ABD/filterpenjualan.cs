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
    public partial class filterpenjualan : Form
    {
        public filterpenjualan()
        {
            InitializeComponent();
        }
        Tabel barang = new Tabel("buah");
        private void filterpenjualan_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            laporanpenjualan formLaporanjual = new laporanpenjualan();
            String kd1, kd2;
            kd1 = txtjual1.Text;
            kd2 = txtjual2.Text;
            formLaporanjual.getitemnotajualBindingSource().Filter = "nonotajual >= " + kd1 + " AND " +
            "nonotajual <= " + kd2;
            formLaporanjual.ShowDialog();
            formLaporanjual.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
