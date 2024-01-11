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
    public partial class filterbuah : Form
    {
        public filterbuah()
        {
            InitializeComponent();
        }

        private void filterbuah_Load(object sender, EventArgs e)
        {

        }

        private void filter3_Click(object sender, EventArgs e)
        {
            LaporanStok formLaporanjual = new LaporanStok();
            String kd1, kd2;
            kd1 = txtbuahf1.Text;
            kd2 = txtbuahf2.Text;
            formLaporanjual.getbuahBindingSource().Filter = "kdbuah=" + kd1 + " AND " +
            "kdbuah=" + kd2;
            formLaporanjual.ShowDialog();
            formLaporanjual.Dispose();
        }

        private void closef3_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
