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
    public partial class filterpembelian : Form
    {
        public filterpembelian()
        {
            InitializeComponent();
        }

        private void filterpembelian_Load(object sender, EventArgs e)
        {

        }

        private void filter1_Click(object sender, EventArgs e)
        {
            Laporan_pembelian formLaporanjual = new Laporan_pembelian();
            String kd1, kd2;
            kd1 = txtbeli1.Text;
            kd2 = txtbeli2.Text;
            formLaporanjual.getitemnotabeliBindingSource().Filter = "nonotabeli >= " + kd1 + " AND " +
            "nonotabeli <= " + kd2;
            formLaporanjual.ShowDialog();
            formLaporanjual.Dispose();
        }

        private void closef1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
