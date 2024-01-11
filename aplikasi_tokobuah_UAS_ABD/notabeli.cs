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
    public partial class notabeli : Form
    {
        public notabeli()
        {
            InitializeComponent();
        }
        Tabel Tabel = new Tabel("viewnotabeli");
        Tabel detail = new Tabel("viewdetailbeli");
        private void notabeli_Load(object sender, EventArgs e)
        {
            ikat();
            tampil();
        }
        void ikat()
        {
            txtnotabeli.DataBindings.Add("Text", Tabel.getBs(), "nonotabeli");
            txttgl1.DataBindings.Add("Text", Tabel.getBs(), "tgl");
            txtkdsup.DataBindings.Add("Text", Tabel.getBs(), "kdsupplier");
            txtnmsup.DataBindings.Add("Text", Tabel.getBs(), "nmsupplier");
            txtalamat1.DataBindings.Add("Text", Tabel.getBs(), "alamat");
            txtkota1.DataBindings.Add("Text", Tabel.getBs(), "kota");
            txttelpon1.DataBindings.Add("Text", Tabel.getBs(), "telpon");
            dgvdetailbeli.DataSource = detail.getBs();

        }
        private void modesimpan()
        {
            btn_next1.Enabled = true;
            btn_top1.Enabled = true;
            btn_back1.Enabled = true;
            btn_last1.Enabled = true;
            btn_undo1.Visible = false;
            btn_save1.Visible = false;
            btn_new1.Enabled = true;
            btn_close1.Enabled = true;
            btn_del1.Enabled = true;
            btn_edit1.Enabled = true;
            btn_print1.Enabled = true;
            dgvdetailbeli.Enabled = false;
        }

        private void modeubah()
        {

            btn_undo1.Visible = true;
            btn_save1.Visible = true;
            btn_new1.Enabled = false;
            btn_top1.Enabled = false;
            btn_back1.Enabled = false;
            btn_del1.Enabled = false;
            btn_edit1.Enabled = false;
            btn_last1.Enabled = false;
            btn_next1.Enabled = false;
            btn_print1.Enabled = false;
            dgvdetailbeli.Enabled = true;
            txtkdbrg1.Focus();
        }
        void tampil()
        {
            detail.getBs().Filter = "nonotabeli= " + txtnotabeli.Text;
            total();
        }
        void hapus()
        {
            txtkdbrg1.Text = "";
            txtnmbrg1.Text = " ";
            txtqty1.Text = "0";
            txthrg1.Text = "0";
            txtjmlh1.Text = "0";
            txtkdbrg1.Focus();
        }
        void total()
        {
            int baris, total = 0;
            for (baris = 0; baris < dgvdetailbeli.Rows.Count - 1; baris++)
                total += int.Parse(dgvdetailbeli.Rows[baris].Cells[6].Value.ToString());
            txttotal1.Text = total.ToString("#,###");
        }

        private void btn_top1_Click(object sender, EventArgs e)
        {
            Tabel.getBs().MoveFirst();
            tampil();
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            Tabel.getBs().MovePrevious();
            tampil();
        }

        private void btn_next1_Click(object sender, EventArgs e)
        {
            Tabel.getBs().MoveNext();
            tampil();
        }

        private void btn_last1_Click(object sender, EventArgs e)
        {
            Tabel.getBs().MoveLast();
            tampil();
        }

        private void btn_close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtkdbrg1_Validated(object sender, EventArgs e)
        {
            if (txtkdbrg1.Text.Length > 0)
            {
                Tabel Tabel = new Tabel("buah");
                int barisDitemukan = Tabel.getBs().Find("kdbuah", txtkdbrg1.Text);
                if (barisDitemukan >= 0)
                {
                    Tabel.getBs().Position = barisDitemukan;
                    txtnmbrg1.Text = ((DataRowView)Tabel.getBs().Current).Row["nmbuah"].ToString();
                    txthrg1.Text = ((DataRowView)Tabel.getBs().Current).Row["hrg"].ToString();
                }
                else
                {
                    MessageBox.Show("Kode : " + txtkdbrg1.Text + "Tidak Ditemukan");
                    hapus();
                }
            }

        }

        private void txtkdbrg1_Leave(object sender, EventArgs e)
        {
            if (txtkdbrg1.Text.Length == 5)
                txtqty1.Focus();
        }

        private void txtkdbrg1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtkdbrg1.Text.Length == 5)
                txtqty1.Focus();
        }

        private void txtqty1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txthrg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtqty1_Validated(object sender, EventArgs e)
        {
            txtjmlh1.Text = (int.Parse(txtqty1.Text) * int.Parse(txthrg1.Text)).ToString();
        }

        private void txthrg1_Validated(object sender, EventArgs e)
        {
            txtjmlh1.Text = (int.Parse(txtqty1.Text) * int.Parse(txthrg1.Text)).ToString();
        }

        private void txthrg1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtqty1.Text.Length > 0)
                if (e.KeyData == Keys.Enter && int.Parse(txtqty1.Text) > 0)
                    txtjmlh1.Focus();
        }

        private void txtqty1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtqty1.Text.Length > 0)
                if (e.KeyData == Keys.Enter && int.Parse(txtqty1.Text) > 0)
                    txthrg1.Focus();
        }

        private void txtjmlh1_KeyDown(object sender, KeyEventArgs e)
        {
             if (txtjmlh1.Text.Length > 0)
                 if (e.KeyData == Keys.Enter && int.Parse(txtjmlh1.Text) > 0)
                 {
                     String strSQL, noNotaBeli, kdbuah, qty, harga;
                     noNotaBeli = txtnotabeli.Text;
                     kdbuah = txtkdbrg1.Text;
                     qty = txtqty1.Text;
                     harga = txthrg1.Text;

                     strSQL = "INSERT INTO itemnotabeli (nonotabeli, kdbuah, " + "qty, harga) VALUES('{0}','{1}','{2}','{3}')";
                     strSQL = String.Format(strSQL, noNotaBeli, kdbuah, qty, harga);

                     detail.eksekusisql(strSQL);
                     hapus();
                     total();
                 }
        }

        private void dgvdetailbeli_KeyDown(object sender, KeyEventArgs e)
        {
            int baris = dgvdetailbeli.SelectedCells[0].RowIndex;
            if (e.KeyData == Keys.Back)
            {
                txtkdbrg1.Text = dgvdetailbeli.Rows[baris].Cells[2].Value.ToString();
                txtnmbrg1.Text = dgvdetailbeli.Rows[baris].Cells[3].Value.ToString();
                txtqty1.Text = dgvdetailbeli.Rows[baris].Cells[4].Value.ToString();
                txthrg1.Text = dgvdetailbeli.Rows[baris].Cells[5].Value.ToString();
                txtjmlh1.Text = dgvdetailbeli.Rows[baris].Cells[6].Value.ToString();
                txtkdbrg1.Focus();
            }
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                String idNotaBeli = dgvdetailbeli.Rows[baris].Cells[0].Value.ToString();
                String strSQL = "DELETE FROM itemnotabeli where idnotabeli=" + idNotaBeli;
                detail.eksekusisql(strSQL);
            }
            total();
        }

        private void btn_del1_Click(object sender, EventArgs e)
        {
            DialogResult jawab;
            jawab = MessageBox.Show("hapus Nota No. " + txtnotabeli.Text + " ? ",
            "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                String nomorNota = txtnotabeli.Text;
                String strSQL = "DELETE FROM itemnotabeli WHERE nonotabeli = " + nomorNota + " ";
                detail.eksekusisql(strSQL);

                //hapus master kemudian
                strSQL = "DELETE FROM notabeli WHERE nonotabeli = " + nomorNota + " ";
                Tabel.eksekusisql(strSQL);

                MessageBox.Show("Penghapusan Selesai", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Tabel.getBs().MoveLast();
                tampil();
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btn_new1_Click(object sender, EventArgs e)
        {
            String tanggal = DateTime.Now.ToString("M-d-yyyy");
            string strSQL = "INSERT INTO notabeli(tgl) VALUES('" + tanggal + "')";
            String nomorNotaBaru = Tabel.eksekusisql_getid(strSQL);
            int posisi = Tabel.getBs().Find("nonotabeli", nomorNotaBaru);
            Tabel.getBs().Position = posisi;
            tampil();
        }

        private void txtkdsup_Validated(object sender, EventArgs e)
        {
            if (txtkdsup.Text.Length > 0 || txtkdsup.Text.Length == 4)
            {
                String strSQL, noNotaSekarang = txtnotabeli.Text;
                Tabel supplier = new Tabel("supplier");
                int barisDitemukan = supplier.getBs().Find("kdsupplier", txtkdsup.Text);
                if (barisDitemukan >= 0)
                {
                    strSQL = "UPDATE notabeli SET kdsupplier='{0}' WHERE nonotabeli='{1}'";
                    strSQL = String.Format(strSQL, txtkdsup.Text, noNotaSekarang);
                    txtkdbrg1.Focus();
                }
                else
                {
                    MessageBox.Show("kode : " + txtkdsup.Text + " tidak ditemukan");
                    strSQL = "UPDATE  notabeli SET kdsupplier=NULL WHERE nonotabeli='{0}'";
                    strSQL = String.Format(strSQL, noNotaSekarang);
                    if (txtkdsup.Text.Length != 0)
                        txtkdsup.Focus();
                    else
                        txtkdbrg1.Focus();
                    txtkdsup.Text = "";
                }
                Tabel.eksekusisql(strSQL);
                barisDitemukan = Tabel.getBs().Find("nonotabeli", noNotaSekarang);
                Tabel.getBs().Position = barisDitemukan;
            }
        }

        private void txtkdsup_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtkdsup.Text.Length == 5 || e.KeyCode == Keys.Enter)
                txtkdbrg1.Focus();
        }

        private void btn_edit1_Click(object sender, EventArgs e)
        {
            modeubah();
        }

        private void btn_save1_Click(object sender, EventArgs e)
        {
            modesimpan();
        }

        private void btn_undo1_Click(object sender, EventArgs e)
        {
            modesimpan();
        }

        private void btn_print1_Click(object sender, EventArgs e)
        {

            Laporan_pembelian formLaporanbeli = new Laporan_pembelian();
            formLaporanbeli.ShowDialog();
            formLaporanbeli.Dispose();
        
        }

        private void btn_find1_Click(object sender, EventArgs e)
        {
            filterpembelian formfilterbeli = new filterpembelian();
            formfilterbeli.ShowDialog();
            formfilterbeli.Dispose();
        }

        private void txttotal1_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
