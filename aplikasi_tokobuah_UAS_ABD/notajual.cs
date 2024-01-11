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
    public partial class notajual : Form
    {
        public notajual()
        {
            InitializeComponent();
        }

        Tabel Tabel = new Tabel("View_Nota_Jual");
        Tabel detail = new Tabel("View_Detail_Jual");
        private void notajual_Load(object sender, EventArgs e)
        {
            ikat();
            tampil();   
        }

        void hapus()
        {
            txtkdbrg2.Text = "";
            txtnmbrg2.Text = " ";
            txtqty2.Text = "0";
            txthrg2.Text = "0";
            txtjmlh2.Text = "0";
            txtkdbrg2.Focus();
        }
        private void modesimpan()
        {
            btn_next2.Enabled = true;
            btn_top2.Enabled = true;
            btn_back2.Enabled = true;
            btn_last2.Enabled = true;
            btn_undo2.Visible = false;
            btn_save2.Visible = false;
            btn_new2.Enabled = true;
            btn_close2.Enabled = true;
            btn_del2.Enabled = true;
            btn_edit2.Enabled = true;
            btn_print2.Enabled = true;
            dgvdetailjual.Enabled = false;
        }
        void total()
        {
            int baris, total = 0;
            for (baris = 0; baris < dgvdetailjual.Rows.Count - 1; baris++)
                total += int.Parse(dgvdetailjual.Rows[baris].Cells[6].Value.ToString());
            txttotal2.Text = total.ToString("#,###");
        }
        private void modeubah()
        {

            btn_undo2.Visible = true;
            btn_save2.Visible = true;
            btn_new2.Enabled = false;
            btn_top2.Enabled = false;
            btn_back2.Enabled = false;
            btn_del2.Enabled = false;
            btn_edit2.Enabled = false;
            btn_last2.Enabled = false;
            btn_next2.Enabled = false;
            btn_print2.Enabled = false;
            dgvdetailjual.Enabled = true;
            txtkdbrg2.Focus();
        }
        void ikat()
        {
            txtnotajual.DataBindings.Add("Text", Tabel.getBs(), "nonotajual");
            txttgl2.DataBindings.Add("Text", Tabel.getBs(), "tgl");
            txtkdcus.DataBindings.Add("Text", Tabel.getBs(), "kdcustomer");
            txtnmcus.DataBindings.Add("Text", Tabel.getBs(), "nmcustomer");
            txtalamat2.DataBindings.Add("Text", Tabel.getBs(), "alamat");
            txttelpon2.DataBindings.Add("Text", Tabel.getBs(), "telpon");
            dgvdetailjual.DataSource = detail.getBs();
        }
        void tampil()
        {
            detail.getBs().Filter = "nonotajual= " + txtnotajual.Text;
            total();
        }

        private void btn_top2_Click(object sender, EventArgs e)
        {
            Tabel.getBs().MoveFirst();
            tampil();
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            Tabel.getBs().MovePrevious();
            tampil();
        }

        private void btn_next2_Click(object sender, EventArgs e)
        {
            Tabel.getBs().MoveNext();
            tampil();
        }

        private void btn_last2_Click(object sender, EventArgs e)
        {
            Tabel.getBs().MoveLast();
            tampil();
        }

        private void btn_close2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtkdbrg2_Validated(object sender, EventArgs e)
        {
            if (txtkdbrg2.Text.Length > 0)
            {
                Tabel Tabel = new Tabel("buah");
                int barisDitemukan = Tabel.getBs().Find("kdbuah", txtkdbrg2.Text);
                if (barisDitemukan >= 0)
                {
                    Tabel.getBs().Position = barisDitemukan;
                    txtnmbrg2.Text = ((DataRowView)Tabel.getBs().Current).Row["nmbuah"].ToString();
                    txthrg2.Text = ((DataRowView)Tabel.getBs().Current).Row["hrg"].ToString();
                }
                else
                {
                    MessageBox.Show("Kode : " + txtkdbrg2.Text + "Tidak Ditemukan");
                    hapus();
                }
            }
        }

        private void txtkdbrg2_Leave(object sender, EventArgs e)
        {
            if (txtkdbrg2.Text.Length == 5)
                txtqty2.Focus();
        }

        private void txtkdbrg2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtkdbrg2.Text.Length == 5)
                txtqty2.Focus();
        }

        private void txtqty2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txthrg2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtqty2_Validated(object sender, EventArgs e)
        {
            txtjmlh2.Text = (int.Parse(txtqty2.Text) * int.Parse(txthrg2.Text)).ToString();
        }

        private void txthrg2_Validated(object sender, EventArgs e)
        {
            txtjmlh2.Text = (int.Parse(txtqty2.Text) * int.Parse(txthrg2.Text)).ToString();
        }

        private void txthrg2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtqty2.Text.Length > 0)
                if (e.KeyData == Keys.Enter && int.Parse(txtqty2.Text) > 0)
                    txtjmlh2.Focus();
        }

        private void txtqty2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtqty2.Text.Length > 0)
                if (e.KeyData == Keys.Enter && int.Parse(txtqty2.Text) > 0)
                    txthrg2.Focus();
        }

        private void txtjmlh2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtjmlh2.Text.Length > 0)
                if (e.KeyData == Keys.Enter && int.Parse(txtjmlh2.Text) > 0)
                {
                    String strSQL, noNotaJual, kdbuah, qty, harga;
                    noNotaJual = txtnotajual.Text;
                    kdbuah = txtkdbrg2.Text;
                    qty = txtqty2.Text;
                    harga = txthrg2.Text;

                    strSQL = "INSERT INTO itemnotajual (nonotajual, kdbuah, " + "qty, harga) VALUES('{0}','{1}','{2}','{3}')";
                    strSQL = String.Format(strSQL, noNotaJual, kdbuah, qty, harga);
                    detail.eksekusisql(strSQL);
                    hapus();
                    total();
                }
        }

        private void dgvdetailjual_KeyDown(object sender, KeyEventArgs e)
        {
            int baris = dgvdetailjual.SelectedCells[0].RowIndex;
            if (e.KeyData == Keys.Back)
            {
                txtkdbrg2.Text = dgvdetailjual.Rows[baris].Cells[2].Value.ToString();
                txtnmbrg2.Text = dgvdetailjual.Rows[baris].Cells[3].Value.ToString();
                txtqty2.Text = dgvdetailjual.Rows[baris].Cells[4].Value.ToString();
                txthrg2.Text = dgvdetailjual.Rows[baris].Cells[5].Value.ToString();
                txtjmlh2.Text = dgvdetailjual.Rows[baris].Cells[6].Value.ToString();
                txtkdbrg2.Focus();
            }
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                String idNotaJual = dgvdetailjual.Rows[baris].Cells[0].Value.ToString();
                String strSQL = "DELETE FROM itemnotajual where idnotajual=" + idNotaJual;
                detail.eksekusisql(strSQL);
            }
            total();

        }

        private void btn_del2_Click(object sender, EventArgs e)
        {
            DialogResult jawab;
            jawab = MessageBox.Show("hapus Nota No. " + txtnotajual.Text + " ? ",
            "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                String nomorNota = txtnotajual.Text;
                String strSQL = "DELETE FROM itemnotajual WHERE nonotajual = " + nomorNota + " ";
                detail.eksekusisql(strSQL);

                //hapus master kemudian
                strSQL = "DELETE FROM notajual WHERE nonotajual = " + nomorNota + " ";
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

        private void btn_new2_Click(object sender, EventArgs e)
        {
            String tanggal = DateTime.Now.ToString("M-d-yyyy");
            string strSQL = "INSERT INTO notajual (tgl) VALUES('" + tanggal + "')";
            String nomorNotaBaru = Tabel.eksekusisql_getid(strSQL);
            int posisi = Tabel.getBs().Find("nonotajual", nomorNotaBaru);
            Tabel.getBs().Position = posisi;
            tampil();
        }

        private void txtkdcus_Validated(object sender, EventArgs e)
        {
            if (txtkdcus.Text.Length > 0 || txtkdcus.Text.Length == 4)
            {
                String strSQL, noNotaSekarang = txtnotajual.Text;
                Tabel supplier = new Tabel("customer");
                int barisDitemukan = supplier.getBs().Find("kdcustomer", txtkdcus.Text);
                if (barisDitemukan >= 0)
                {
                    strSQL = "UPDATE notajual SET kdcustomer='{0}' WHERE nonotajual='{1}'";
                    strSQL = String.Format(strSQL, txtkdcus.Text, noNotaSekarang);
                    txtkdbrg2.Focus();
                }
                else
                {
                    MessageBox.Show("kode : " + txtkdcus.Text + " tidak ditemukan");
                    strSQL = "UPDATE  notajual SET kdcustomer=NULL WHERE nonotajual='{0}'";
                    strSQL = String.Format(strSQL, noNotaSekarang);
                    if (txtkdcus.Text.Length != 0)
                        txtkdcus.Focus();
                    else
                        txtkdbrg2.Focus();
                    txtkdcus.Text = "";
                }
                Tabel.eksekusisql(strSQL);
                barisDitemukan = Tabel.getBs().Find("nonotajual", noNotaSekarang);
                Tabel.getBs().Position = barisDitemukan;
            }
        }

        private void txtkdcus_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtkdcus.Text.Length == 5 || e.KeyCode == Keys.Enter)
                txtkdbrg2.Focus();
        }

        private void btn_edit2_Click(object sender, EventArgs e)
        {
            modeubah();
        }

        private void btn_save2_Click(object sender, EventArgs e)
        {
            modesimpan();
        }

        private void btn_undo2_Click(object sender, EventArgs e)
        {
            modesimpan();
        }

        private void btn_print2_Click(object sender, EventArgs e)
        {
            laporanpenjualan formLaporanjual = new laporanpenjualan();
            formLaporanjual.ShowDialog();
            formLaporanjual.Dispose();
        }

        private void btn_find2_Click(object sender, EventArgs e)
        {
            filterpenjualan formfilterjual = new filterpenjualan();
            formfilterjual.ShowDialog();
            formfilterjual.Dispose();
        }




    }
}
