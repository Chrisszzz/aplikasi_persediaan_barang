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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        Tabel user1 = new Tabel("userr");
        private void login_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
            
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string tgl = DateTime.Now.ToString("M-d-yyyy");
            string sql = "select * from userr where username = '" + txtuser.Text + "' and pass = '" + txtpass.Text + "'";
            user1.eksekusisql_getuser(sql);
            if (user1.username != "")
            {
                MessageBox.Show("Selamat Datang " + user1.username);
                menu frm = new menu(user1.username, user1.pass, user1.hak_akses);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username / Password Tidak Ditemukan");
                txtuser.Text = "";
                txtpass.Text = "";
                txtuser.Focus();
            }
        }

        private void login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string tgl = DateTime.Now.ToString("M-d-yyyy");
                string sql = "select * from userr where username = '" + txtuser.Text + "' and pass = '" + txtpass.Text + "'";
                user1.eksekusisql_getuser(sql);
                if (user1.username != "")
                {
                    MessageBox.Show("Selamat Datang " + user1.username);
                    menu frm = new menu(user1.username, user1.pass, user1.hak_akses);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username / Password Tidak Ditemukan");
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtuser.Focus();
                }
            }
        }




    }
}
