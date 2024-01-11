using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aplikasi_tokobuah_UAS_ABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Tabel buah1 = new Tabel("buah");
        private bool baru;
        private string kodeLama;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = buah1.getBs();
            modesave();
        }

        void ikat()
        {
            txtkdbuah.DataBindings.Add("Text", buah1.getBs(), "kdbuah");
            txtnmbuah.DataBindings.Add("Text", buah1.getBs(), "nmbuah");
            txtstok.DataBindings.Add("Text", buah1.getBs(), "stok");
            txtsatuan.DataBindings.Add("Text", buah1.getBs(), "satuan");
            txthrgbeli.DataBindings.Add("Text", buah1.getBs(), "hrg");
        }

        private void lepas()
        {
            txtkdbuah.DataBindings.Clear();
            txtnmbuah.DataBindings.Clear();
            txtstok.DataBindings.Clear();
            txtsatuan.DataBindings.Clear();
            txthrgbeli.DataBindings.Clear();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            buah1.getBs().MoveFirst();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            buah1.getBs().MovePrevious();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            buah1.getBs().MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            buah1.getBs().MoveLast();
        }

        private void modesave()
        {
            txtkdbuah.Enabled = false;
            txtnmbuah.Enabled = false;
            txtstok.Enabled = false;
            txtsatuan.Enabled = false;
            txthrgbeli.Enabled = false;

            btn_prev.Enabled = true;
            btn_back.Enabled = true;
            btn_next.Enabled = true;
            btn_last.Enabled = true;

            btn_print.Enabled = true;
            btn_new.Enabled = true;
            btn_find.Enabled = true;
            btn_del.Enabled = true;
            btn_close.Enabled = true;
            btn_edit.Enabled = true;

            btn_save.Visible = false;
            btn_undo.Visible = false;
            btn_new.Visible = true;
            btn_edit.Visible = true;
            ikat();
        }

        private void modeEdit()
        {
            txtkdbuah.Enabled = true;
            txtnmbuah.Enabled = true;
            txtstok.Enabled = true;
            txtsatuan.Enabled = true;
            txthrgbeli.Enabled = true;

            btn_prev.Enabled = false;
            btn_back.Enabled = false;
            btn_next.Enabled = false;
            btn_last.Enabled = false;

            btn_print.Enabled = false;
            btn_new.Enabled = false;
            btn_find.Enabled = false;
            btn_del.Enabled = true;
            btn_close.Enabled = false;
            btn_edit.Enabled = false;

            btn_save.Visible = true;
            btn_undo.Visible = true;
            btn_edit.Visible = false;
            btn_new.Visible = false;
            lepas();
            txtkdbuah.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String kode, nama, stok, satuan, harga, stringSQL;
            kode = txtkdbuah.Text;
            nama = txtnmbuah.Text;
            stok = txtstok.Text;
            satuan = txtsatuan.Text;
            harga = txthrgbeli.Text;

            if (baru)
            {

                stringSQL = "INSERT INTO buah (kdbuah, nmbuah, stok, satuan, hrg)";
                stringSQL += "VALUES('{0}','{1}','{2}','{3}','{4}')";
                stringSQL = String.Format(stringSQL, kode, nama, stok, satuan, harga);
            }
            else
            {
                stringSQL = "UPDATE buah set kdbuah='{0}', nmbuah='{1}', stok='{2}', satuan='{3}', hrg='{4}' WHERE kdbuah ='{5}'";
                stringSQL = String.Format(stringSQL, kode, nama, stok, satuan, harga, this.kodeLama);
            }

            this.buah1.eksekusisql(stringSQL);
            modesave();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            modeEdit();
            this.baru = false;
            this.kodeLama = txtkdbuah.Text;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            modeEdit();
            txtkdbuah.Text = "";
            txtnmbuah.Text = "";
            txtstok.Text = "0";
            txtsatuan.Text = "";
            txthrgbeli.Text = "0";
            this.baru = true;
            txtkdbuah.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            modesave();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string insert;
            System.Windows.Forms.DialogResult jwb;
            jwb = MessageBox.Show("Apakah data dengan kode " + txtkdbuah.Text + " akan dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jwb == System.Windows.Forms.DialogResult.Yes)
            {
                insert = "delete from buah where kdbuah ='{0}'";
                insert = String.Format(insert, txtkdbuah.Text);
                MessageBox.Show(insert);
                buah1.eksekusisql(insert);
                MessageBox.Show("Data Berhasil dihapus");
            }
            else
            {
                MessageBox.Show("Data Gagal dihapus");
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            LaporanStok formLaporanStok = new LaporanStok();
            formLaporanStok.ShowDialog();
            formLaporanStok.Dispose();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            filterbuah formfilterStok = new filterbuah();
            formfilterStok.ShowDialog();
            formfilterStok.Dispose();
        }

    }
}
