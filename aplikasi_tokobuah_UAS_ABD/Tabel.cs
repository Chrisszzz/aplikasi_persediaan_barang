using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aplikasi_tokobuah_UAS_ABD
{
    class Tabel
    {
        private string namatabel;
        private DataTable dt;
        private BindingSource bs;

        private string _username;
        public string username
        {
            get
            {
                return _username;
            }
        }
        private string _pass;
        public string pass
        {
            get
            {
                return _pass;
            }
        }
        private string _hak_akses;
        public string hak_akses
        {
            get
            {
                return _hak_akses;
            }
        }

        public Tabel(string namatabel)
        {
            this.namatabel = namatabel;
            this.dt = new DataTable();
            this.bs = new BindingSource();
            this.isidatatable();
            this.bs.DataSource = this.dt;

        }

        private void isidatatable()
        {
            string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=tokobuah;integrated security = true";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from " + this.namatabel, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            this.dt.Clear();
            da.Fill(this.dt);
            con.Close();
        }

        public void eksekusisql(string sql)
        {
            string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=tokobuah;integrated security = true";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            isidatatable();
        }
        public string eksekusisql_getid(string sql)
        {
            string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=tokobuah;integrated security = true";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select @@identity", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string nobaru = dr.GetValue(0).ToString();
            con.Close();
            isidatatable();
            return nobaru;
        }
        public void eksekusisql_getuser(string sql)
        {
            string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=tokobuah;integrated security = true";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this._username = dr.GetValue(0).ToString();
                this._pass = dr.GetValue(1).ToString();
                this._hak_akses = dr.GetValue(2).ToString();
            }
            else
            {
                this._username = "";
                this._pass = "";
                this._hak_akses = "";
            }

            con.Close();
        }
        public BindingSource getBs()
        {
            return this.bs;
        }
    }
}
