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
    public partial class menu : Form
    {
        Tabel Tabel = new Tabel("view_stok");
        private string username, hakakses, pass;
        public menu(string username, string pass, string hakakses)
        {
            this.username = username;
            this.pass = pass;
            this.hakakses = hakakses;
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokobuahDataSet9.view_user' table. You can move, or remove it, as needed.
            this.view_userTableAdapter.Fill(this.tokobuahDataSet9.view_user);
            // TODO: This line of code loads data into the 'tokobuahDataSet8.view_customer' table. You can move, or remove it, as needed.
            this.view_customerTableAdapter.Fill(this.tokobuahDataSet8.view_customer);
            // TODO: This line of code loads data into the 'tokobuahDataSet7.view_supplier' table. You can move, or remove it, as needed.
            this.view_supplierTableAdapter.Fill(this.tokobuahDataSet7.view_supplier);
            // TODO: This line of code loads data into the 'tokobuahDataSet6.view_stok' table. You can move, or remove it, as needed.
            this.view_stokTableAdapter.Fill(this.tokobuahDataSet6.view_stok);

            label1.Text = username;
            if (hakakses == "kasir")
            {
                tspenjualan.Enabled = true;
                tspembelian.Enabled = false;
                menuitembuah.Enabled = true;
            }
            else if (hakakses == "gudang")
            {
                tspenjualan.Enabled = false;
                tspembelian.Enabled = true;
                menuitembuah.Enabled = true;
            } 

        }

        private void transaksiPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notajual formnotajual = new notajual();
            formnotajual.ShowDialog();
            formnotajual.Dispose();
        }

        private void transksiPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notabeli formnotabeli = new notabeli();
            formnotabeli.ShowDialog();
            formnotabeli.Dispose();
        }

        private void menuitembuah_Click(object sender, EventArgs e)
        {
            Form1 formnotabeli = new Form1();
            formnotabeli.ShowDialog();
            formnotabeli.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.view_stokTableAdapter.FillBy(this.tokobuahDataSet6.view_stok);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void descendingStokToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.view_stokTableAdapter.DescendingStok(this.tokobuahDataSet6.view_stok);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        

        private void txtjenisbuah_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
