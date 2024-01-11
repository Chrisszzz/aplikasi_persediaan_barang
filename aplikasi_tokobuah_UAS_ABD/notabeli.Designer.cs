namespace aplikasi_tokobuah_UAS_ABD
{
    partial class notabeli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttotal1 = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dgvdetailbeli = new System.Windows.Forms.DataGridView();
            this.idnotabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonotabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdbuah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbuah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttelpon1 = new System.Windows.Forms.TextBox();
            this.lbltlp1 = new System.Windows.Forms.Label();
            this.txtkota1 = new System.Windows.Forms.TextBox();
            this.lblkota1 = new System.Windows.Forms.Label();
            this.txtalamat1 = new System.Windows.Forms.TextBox();
            this.lblalamat1 = new System.Windows.Forms.Label();
            this.txtnmsup = new System.Windows.Forms.TextBox();
            this.lblnama1 = new System.Windows.Forms.Label();
            this.txtkdsup = new System.Windows.Forms.TextBox();
            this.lblkode1 = new System.Windows.Forms.Label();
            this.txtnotabeli = new System.Windows.Forms.TextBox();
            this.lblnota1 = new System.Windows.Forms.Label();
            this.txttgl1 = new System.Windows.Forms.TextBox();
            this.lbltgl1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtjmlh1 = new System.Windows.Forms.TextBox();
            this.lbljmlh1 = new System.Windows.Forms.Label();
            this.txthrg1 = new System.Windows.Forms.TextBox();
            this.lblhrg1 = new System.Windows.Forms.Label();
            this.txtqty1 = new System.Windows.Forms.TextBox();
            this.lblqty1 = new System.Windows.Forms.Label();
            this.txtnmbrg1 = new System.Windows.Forms.TextBox();
            this.lblnm1 = new System.Windows.Forms.Label();
            this.txtkdbrg1 = new System.Windows.Forms.TextBox();
            this.lblkd1 = new System.Windows.Forms.Label();
            this.btn_undo1 = new System.Windows.Forms.Button();
            this.btn_save1 = new System.Windows.Forms.Button();
            this.btn_close1 = new System.Windows.Forms.Button();
            this.btn_del1 = new System.Windows.Forms.Button();
            this.btn_edit1 = new System.Windows.Forms.Button();
            this.btn_new1 = new System.Windows.Forms.Button();
            this.btn_find1 = new System.Windows.Forms.Button();
            this.btn_print1 = new System.Windows.Forms.Button();
            this.btn_last1 = new System.Windows.Forms.Button();
            this.btn_next1 = new System.Windows.Forms.Button();
            this.btn_back1 = new System.Windows.Forms.Button();
            this.btn_top1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailbeli)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttotal1
            // 
            this.txttotal1.AcceptsReturn = true;
            this.txttotal1.BackColor = System.Drawing.Color.SteelBlue;
            this.txttotal1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal1.ForeColor = System.Drawing.Color.White;
            this.txttotal1.Location = new System.Drawing.Point(599, 609);
            this.txttotal1.Name = "txttotal1";
            this.txttotal1.Size = new System.Drawing.Size(101, 25);
            this.txttotal1.TabIndex = 63;
            this.txttotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotal1.TextChanged += new System.EventHandler(this.txttotal1_TextChanged);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(537, 614);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(57, 13);
            this.lbltotal.TabIndex = 62;
            this.lbltotal.Text = "Total (Rp)";
            // 
            // dgvdetailbeli
            // 
            this.dgvdetailbeli.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvdetailbeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetailbeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnotabeli,
            this.nonotabeli,
            this.kdbuah,
            this.nmbuah,
            this.qty,
            this.harga,
            this.jumlah});
            this.dgvdetailbeli.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvdetailbeli.Location = new System.Drawing.Point(59, 285);
            this.dgvdetailbeli.Name = "dgvdetailbeli";
            this.dgvdetailbeli.Size = new System.Drawing.Size(641, 298);
            this.dgvdetailbeli.TabIndex = 49;
            this.dgvdetailbeli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvdetailbeli_KeyDown);
            // 
            // idnotabeli
            // 
            this.idnotabeli.DataPropertyName = "idnotabeli";
            this.idnotabeli.HeaderText = "id nota beli";
            this.idnotabeli.Name = "idnotabeli";
            this.idnotabeli.Visible = false;
            // 
            // nonotabeli
            // 
            this.nonotabeli.DataPropertyName = "nonotabeli";
            this.nonotabeli.HeaderText = "no nota beli";
            this.nonotabeli.Name = "nonotabeli";
            this.nonotabeli.Visible = false;
            // 
            // kdbuah
            // 
            this.kdbuah.DataPropertyName = "kdbuah";
            this.kdbuah.HeaderText = "Kode Buah";
            this.kdbuah.Name = "kdbuah";
            // 
            // nmbuah
            // 
            this.nmbuah.DataPropertyName = "nmbuah";
            this.nmbuah.HeaderText = "Nama Buah";
            this.nmbuah.Name = "nmbuah";
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "qty";
            this.qty.Name = "qty";
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga";
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            // 
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah";
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.test2_removebg_preview;
            this.groupBox1.Controls.Add(this.txttelpon1);
            this.groupBox1.Controls.Add(this.lbltlp1);
            this.groupBox1.Controls.Add(this.txtkota1);
            this.groupBox1.Controls.Add(this.lblkota1);
            this.groupBox1.Controls.Add(this.txtalamat1);
            this.groupBox1.Controls.Add(this.lblalamat1);
            this.groupBox1.Controls.Add(this.txtnmsup);
            this.groupBox1.Controls.Add(this.lblnama1);
            this.groupBox1.Controls.Add(this.txtkdsup);
            this.groupBox1.Controls.Add(this.lblkode1);
            this.groupBox1.Controls.Add(this.txtnotabeli);
            this.groupBox1.Controls.Add(this.lblnota1);
            this.groupBox1.Controls.Add(this.txttgl1);
            this.groupBox1.Controls.Add(this.lbltgl1);
            this.groupBox1.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(57, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 130);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUPPLIER";
            // 
            // txttelpon1
            // 
            this.txttelpon1.AcceptsReturn = true;
            this.txttelpon1.BackColor = System.Drawing.Color.SteelBlue;
            this.txttelpon1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelpon1.ForeColor = System.Drawing.Color.White;
            this.txttelpon1.Location = new System.Drawing.Point(576, 87);
            this.txttelpon1.Name = "txttelpon1";
            this.txttelpon1.Size = new System.Drawing.Size(101, 25);
            this.txttelpon1.TabIndex = 13;
            this.txttelpon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltlp1
            // 
            this.lbltlp1.AutoSize = true;
            this.lbltlp1.BackColor = System.Drawing.Color.CadetBlue;
            this.lbltlp1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltlp1.ForeColor = System.Drawing.Color.White;
            this.lbltlp1.Location = new System.Drawing.Point(573, 69);
            this.lbltlp1.Name = "lbltlp1";
            this.lbltlp1.Size = new System.Drawing.Size(48, 13);
            this.lbltlp1.TabIndex = 12;
            this.lbltlp1.Text = "Telepon";
            // 
            // txtkota1
            // 
            this.txtkota1.AcceptsReturn = true;
            this.txtkota1.BackColor = System.Drawing.Color.SteelBlue;
            this.txtkota1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkota1.ForeColor = System.Drawing.Color.White;
            this.txtkota1.Location = new System.Drawing.Point(437, 87);
            this.txtkota1.Name = "txtkota1";
            this.txtkota1.Size = new System.Drawing.Size(101, 25);
            this.txtkota1.TabIndex = 11;
            this.txtkota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblkota1
            // 
            this.lblkota1.AutoSize = true;
            this.lblkota1.BackColor = System.Drawing.Color.CadetBlue;
            this.lblkota1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkota1.ForeColor = System.Drawing.Color.White;
            this.lblkota1.Location = new System.Drawing.Point(435, 69);
            this.lblkota1.Name = "lblkota1";
            this.lblkota1.Size = new System.Drawing.Size(31, 13);
            this.lblkota1.TabIndex = 10;
            this.lblkota1.Text = "Kota";
            // 
            // txtalamat1
            // 
            this.txtalamat1.AcceptsReturn = true;
            this.txtalamat1.BackColor = System.Drawing.Color.SteelBlue;
            this.txtalamat1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalamat1.ForeColor = System.Drawing.Color.White;
            this.txtalamat1.Location = new System.Drawing.Point(298, 88);
            this.txtalamat1.Name = "txtalamat1";
            this.txtalamat1.Size = new System.Drawing.Size(101, 25);
            this.txtalamat1.TabIndex = 9;
            this.txtalamat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblalamat1
            // 
            this.lblalamat1.AutoSize = true;
            this.lblalamat1.BackColor = System.Drawing.Color.CadetBlue;
            this.lblalamat1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalamat1.ForeColor = System.Drawing.Color.White;
            this.lblalamat1.Location = new System.Drawing.Point(295, 70);
            this.lblalamat1.Name = "lblalamat1";
            this.lblalamat1.Size = new System.Drawing.Size(44, 13);
            this.lblalamat1.TabIndex = 8;
            this.lblalamat1.Text = "Alamat";
            // 
            // txtnmsup
            // 
            this.txtnmsup.AcceptsReturn = true;
            this.txtnmsup.BackColor = System.Drawing.Color.SteelBlue;
            this.txtnmsup.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmsup.ForeColor = System.Drawing.Color.White;
            this.txtnmsup.Location = new System.Drawing.Point(163, 89);
            this.txtnmsup.Name = "txtnmsup";
            this.txtnmsup.Size = new System.Drawing.Size(101, 25);
            this.txtnmsup.TabIndex = 7;
            this.txtnmsup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnama1
            // 
            this.lblnama1.AutoSize = true;
            this.lblnama1.BackColor = System.Drawing.Color.CadetBlue;
            this.lblnama1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnama1.ForeColor = System.Drawing.Color.White;
            this.lblnama1.Location = new System.Drawing.Point(160, 73);
            this.lblnama1.Name = "lblnama1";
            this.lblnama1.Size = new System.Drawing.Size(84, 13);
            this.lblnama1.TabIndex = 6;
            this.lblnama1.Text = "Nama Supplier";
            // 
            // txtkdsup
            // 
            this.txtkdsup.AcceptsReturn = true;
            this.txtkdsup.BackColor = System.Drawing.Color.SteelBlue;
            this.txtkdsup.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkdsup.ForeColor = System.Drawing.Color.White;
            this.txtkdsup.Location = new System.Drawing.Point(33, 90);
            this.txtkdsup.Name = "txtkdsup";
            this.txtkdsup.Size = new System.Drawing.Size(101, 25);
            this.txtkdsup.TabIndex = 5;
            this.txtkdsup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtkdsup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtkdsup_KeyUp);
            this.txtkdsup.Validated += new System.EventHandler(this.txtkdsup_Validated);
            // 
            // lblkode1
            // 
            this.lblkode1.AutoSize = true;
            this.lblkode1.BackColor = System.Drawing.Color.CadetBlue;
            this.lblkode1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkode1.ForeColor = System.Drawing.Color.White;
            this.lblkode1.Location = new System.Drawing.Point(30, 74);
            this.lblkode1.Name = "lblkode1";
            this.lblkode1.Size = new System.Drawing.Size(80, 13);
            this.lblkode1.TabIndex = 4;
            this.lblkode1.Text = "Kode Supplier";
            // 
            // txtnotabeli
            // 
            this.txtnotabeli.AcceptsReturn = true;
            this.txtnotabeli.BackColor = System.Drawing.Color.SteelBlue;
            this.txtnotabeli.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotabeli.ForeColor = System.Drawing.Color.White;
            this.txtnotabeli.Location = new System.Drawing.Point(33, 35);
            this.txtnotabeli.Name = "txtnotabeli";
            this.txtnotabeli.Size = new System.Drawing.Size(102, 25);
            this.txtnotabeli.TabIndex = 3;
            this.txtnotabeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnota1
            // 
            this.lblnota1.AutoSize = true;
            this.lblnota1.BackColor = System.Drawing.Color.CadetBlue;
            this.lblnota1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota1.ForeColor = System.Drawing.Color.White;
            this.lblnota1.Location = new System.Drawing.Point(31, 18);
            this.lblnota1.Name = "lblnota1";
            this.lblnota1.Size = new System.Drawing.Size(77, 13);
            this.lblnota1.TabIndex = 2;
            this.lblnota1.Text = "No. Nota Beli";
            // 
            // txttgl1
            // 
            this.txttgl1.AcceptsReturn = true;
            this.txttgl1.BackColor = System.Drawing.Color.SteelBlue;
            this.txttgl1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttgl1.ForeColor = System.Drawing.Color.White;
            this.txttgl1.Location = new System.Drawing.Point(163, 35);
            this.txttgl1.Name = "txttgl1";
            this.txttgl1.Size = new System.Drawing.Size(236, 25);
            this.txttgl1.TabIndex = 1;
            // 
            // lbltgl1
            // 
            this.lbltgl1.AutoSize = true;
            this.lbltgl1.BackColor = System.Drawing.Color.CadetBlue;
            this.lbltgl1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltgl1.ForeColor = System.Drawing.Color.White;
            this.lbltgl1.Location = new System.Drawing.Point(161, 19);
            this.lbltgl1.Name = "lbltgl1";
            this.lbltgl1.Size = new System.Drawing.Size(48, 13);
            this.lbltgl1.TabIndex = 0;
            this.lbltgl1.Text = "Tanggal";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.buah_back_1_removebg_preview;
            this.groupBox2.Controls.Add(this.txtjmlh1);
            this.groupBox2.Controls.Add(this.lbljmlh1);
            this.groupBox2.Controls.Add(this.txthrg1);
            this.groupBox2.Controls.Add(this.lblhrg1);
            this.groupBox2.Controls.Add(this.txtqty1);
            this.groupBox2.Controls.Add(this.lblqty1);
            this.groupBox2.Controls.Add(this.txtnmbrg1);
            this.groupBox2.Controls.Add(this.lblnm1);
            this.groupBox2.Controls.Add(this.txtkdbrg1);
            this.groupBox2.Controls.Add(this.lblkd1);
            this.groupBox2.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(59, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 76);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENTRY DATA ";
            // 
            // txtjmlh1
            // 
            this.txtjmlh1.AcceptsReturn = true;
            this.txtjmlh1.BackColor = System.Drawing.Color.SteelBlue;
            this.txtjmlh1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjmlh1.ForeColor = System.Drawing.Color.White;
            this.txtjmlh1.Location = new System.Drawing.Point(498, 35);
            this.txtjmlh1.Name = "txtjmlh1";
            this.txtjmlh1.Size = new System.Drawing.Size(102, 25);
            this.txtjmlh1.TabIndex = 47;
            this.txtjmlh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtjmlh1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtjmlh1_KeyDown);
            // 
            // lbljmlh1
            // 
            this.lbljmlh1.AutoSize = true;
            this.lbljmlh1.BackColor = System.Drawing.Color.CadetBlue;
            this.lbljmlh1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljmlh1.ForeColor = System.Drawing.Color.White;
            this.lbljmlh1.Location = new System.Drawing.Point(496, 18);
            this.lbljmlh1.Name = "lbljmlh1";
            this.lbljmlh1.Size = new System.Drawing.Size(43, 13);
            this.lbljmlh1.TabIndex = 46;
            this.lbljmlh1.Text = "jumlah";
            // 
            // txthrg1
            // 
            this.txthrg1.AcceptsReturn = true;
            this.txthrg1.BackColor = System.Drawing.Color.SteelBlue;
            this.txthrg1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthrg1.ForeColor = System.Drawing.Color.White;
            this.txthrg1.Location = new System.Drawing.Point(381, 35);
            this.txthrg1.Name = "txthrg1";
            this.txthrg1.Size = new System.Drawing.Size(102, 25);
            this.txthrg1.TabIndex = 45;
            this.txthrg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txthrg1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txthrg1_KeyDown);
            this.txthrg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthrg1_KeyPress);
            this.txthrg1.Validated += new System.EventHandler(this.txthrg1_Validated);
            // 
            // lblhrg1
            // 
            this.lblhrg1.AutoSize = true;
            this.lblhrg1.BackColor = System.Drawing.Color.CadetBlue;
            this.lblhrg1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrg1.ForeColor = System.Drawing.Color.White;
            this.lblhrg1.Location = new System.Drawing.Point(379, 18);
            this.lblhrg1.Name = "lblhrg1";
            this.lblhrg1.Size = new System.Drawing.Size(37, 13);
            this.lblhrg1.TabIndex = 44;
            this.lblhrg1.Text = "harga";
            // 
            // txtqty1
            // 
            this.txtqty1.AcceptsReturn = true;
            this.txtqty1.BackColor = System.Drawing.Color.SteelBlue;
            this.txtqty1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty1.ForeColor = System.Drawing.Color.White;
            this.txtqty1.Location = new System.Drawing.Point(320, 35);
            this.txtqty1.Name = "txtqty1";
            this.txtqty1.Size = new System.Drawing.Size(44, 25);
            this.txtqty1.TabIndex = 43;
            this.txtqty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty1_KeyDown);
            this.txtqty1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty1_KeyPress);
            this.txtqty1.Validated += new System.EventHandler(this.txtqty1_Validated);
            // 
            // lblqty1
            // 
            this.lblqty1.AutoSize = true;
            this.lblqty1.BackColor = System.Drawing.Color.CadetBlue;
            this.lblqty1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty1.ForeColor = System.Drawing.Color.White;
            this.lblqty1.Location = new System.Drawing.Point(318, 18);
            this.lblqty1.Name = "lblqty1";
            this.lblqty1.Size = new System.Drawing.Size(24, 13);
            this.lblqty1.TabIndex = 42;
            this.lblqty1.Text = "qty";
            // 
            // txtnmbrg1
            // 
            this.txtnmbrg1.AcceptsReturn = true;
            this.txtnmbrg1.BackColor = System.Drawing.Color.SteelBlue;
            this.txtnmbrg1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmbrg1.ForeColor = System.Drawing.Color.White;
            this.txtnmbrg1.Location = new System.Drawing.Point(126, 36);
            this.txtnmbrg1.Name = "txtnmbrg1";
            this.txtnmbrg1.Size = new System.Drawing.Size(178, 25);
            this.txtnmbrg1.TabIndex = 41;
            this.txtnmbrg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnm1
            // 
            this.lblnm1.AutoSize = true;
            this.lblnm1.BackColor = System.Drawing.Color.CadetBlue;
            this.lblnm1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnm1.ForeColor = System.Drawing.Color.White;
            this.lblnm1.Location = new System.Drawing.Point(124, 19);
            this.lblnm1.Name = "lblnm1";
            this.lblnm1.Size = new System.Drawing.Size(76, 13);
            this.lblnm1.TabIndex = 40;
            this.lblnm1.Text = "nama barang";
            // 
            // txtkdbrg1
            // 
            this.txtkdbrg1.AcceptsReturn = true;
            this.txtkdbrg1.BackColor = System.Drawing.Color.SteelBlue;
            this.txtkdbrg1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkdbrg1.ForeColor = System.Drawing.Color.White;
            this.txtkdbrg1.Location = new System.Drawing.Point(30, 36);
            this.txtkdbrg1.Name = "txtkdbrg1";
            this.txtkdbrg1.Size = new System.Drawing.Size(80, 25);
            this.txtkdbrg1.TabIndex = 15;
            this.txtkdbrg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtkdbrg1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtkdbrg1_KeyUp);
            this.txtkdbrg1.Leave += new System.EventHandler(this.txtkdbrg1_Leave);
            this.txtkdbrg1.Validated += new System.EventHandler(this.txtkdbrg1_Validated);
            // 
            // lblkd1
            // 
            this.lblkd1.AutoSize = true;
            this.lblkd1.BackColor = System.Drawing.Color.CadetBlue;
            this.lblkd1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkd1.ForeColor = System.Drawing.Color.White;
            this.lblkd1.Location = new System.Drawing.Point(28, 19);
            this.lblkd1.Name = "lblkd1";
            this.lblkd1.Size = new System.Drawing.Size(33, 13);
            this.lblkd1.TabIndex = 14;
            this.lblkd1.Text = "kode";
            // 
            // btn_undo1
            // 
            this.btn_undo1.BackColor = System.Drawing.Color.Transparent;
            this.btn_undo1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.undo_FILL0_wght400_GRAD0_opsz48;
            this.btn_undo1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_undo1.Location = new System.Drawing.Point(430, 609);
            this.btn_undo1.Name = "btn_undo1";
            this.btn_undo1.Size = new System.Drawing.Size(48, 45);
            this.btn_undo1.TabIndex = 61;
            this.btn_undo1.UseVisualStyleBackColor = false;
            this.btn_undo1.Click += new System.EventHandler(this.btn_undo1_Click);
            // 
            // btn_save1
            // 
            this.btn_save1.BackColor = System.Drawing.Color.Transparent;
            this.btn_save1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.save_FILL0_wght400_GRAD0_opsz48;
            this.btn_save1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save1.Location = new System.Drawing.Point(373, 609);
            this.btn_save1.Name = "btn_save1";
            this.btn_save1.Size = new System.Drawing.Size(48, 45);
            this.btn_save1.TabIndex = 60;
            this.btn_save1.UseVisualStyleBackColor = false;
            this.btn_save1.Click += new System.EventHandler(this.btn_save1_Click);
            // 
            // btn_close1
            // 
            this.btn_close1.BackColor = System.Drawing.Color.Transparent;
            this.btn_close1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.close_FILL0_wght400_GRAD0_opsz48;
            this.btn_close1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close1.Location = new System.Drawing.Point(725, 538);
            this.btn_close1.Name = "btn_close1";
            this.btn_close1.Size = new System.Drawing.Size(48, 45);
            this.btn_close1.TabIndex = 59;
            this.btn_close1.UseVisualStyleBackColor = false;
            this.btn_close1.Click += new System.EventHandler(this.btn_close1_Click);
            // 
            // btn_del1
            // 
            this.btn_del1.BackColor = System.Drawing.Color.Transparent;
            this.btn_del1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz48;
            this.btn_del1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_del1.Location = new System.Drawing.Point(725, 385);
            this.btn_del1.Name = "btn_del1";
            this.btn_del1.Size = new System.Drawing.Size(48, 45);
            this.btn_del1.TabIndex = 58;
            this.btn_del1.UseVisualStyleBackColor = false;
            this.btn_del1.Click += new System.EventHandler(this.btn_del1_Click);
            // 
            // btn_edit1
            // 
            this.btn_edit1.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz48;
            this.btn_edit1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_edit1.Location = new System.Drawing.Point(725, 336);
            this.btn_edit1.Name = "btn_edit1";
            this.btn_edit1.Size = new System.Drawing.Size(48, 45);
            this.btn_edit1.TabIndex = 57;
            this.btn_edit1.UseVisualStyleBackColor = false;
            this.btn_edit1.Click += new System.EventHandler(this.btn_edit1_Click);
            // 
            // btn_new1
            // 
            this.btn_new1.BackColor = System.Drawing.Color.Transparent;
            this.btn_new1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.add_FILL0_wght400_GRAD0_opsz48;
            this.btn_new1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_new1.Location = new System.Drawing.Point(725, 285);
            this.btn_new1.Name = "btn_new1";
            this.btn_new1.Size = new System.Drawing.Size(48, 45);
            this.btn_new1.TabIndex = 56;
            this.btn_new1.UseVisualStyleBackColor = false;
            this.btn_new1.Click += new System.EventHandler(this.btn_new1_Click);
            // 
            // btn_find1
            // 
            this.btn_find1.BackColor = System.Drawing.Color.Transparent;
            this.btn_find1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48;
            this.btn_find1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find1.Location = new System.Drawing.Point(725, 487);
            this.btn_find1.Name = "btn_find1";
            this.btn_find1.Size = new System.Drawing.Size(48, 45);
            this.btn_find1.TabIndex = 55;
            this.btn_find1.UseVisualStyleBackColor = false;
            this.btn_find1.Click += new System.EventHandler(this.btn_find1_Click);
            // 
            // btn_print1
            // 
            this.btn_print1.BackColor = System.Drawing.Color.Transparent;
            this.btn_print1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            this.btn_print1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_print1.Location = new System.Drawing.Point(725, 436);
            this.btn_print1.Name = "btn_print1";
            this.btn_print1.Size = new System.Drawing.Size(48, 45);
            this.btn_print1.TabIndex = 54;
            this.btn_print1.UseVisualStyleBackColor = false;
            this.btn_print1.Click += new System.EventHandler(this.btn_print1_Click);
            // 
            // btn_last1
            // 
            this.btn_last1.BackColor = System.Drawing.Color.Transparent;
            this.btn_last1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.last_page_FILL0_wght400_GRAD0_opsz48;
            this.btn_last1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_last1.Location = new System.Drawing.Point(225, 609);
            this.btn_last1.Name = "btn_last1";
            this.btn_last1.Size = new System.Drawing.Size(48, 45);
            this.btn_last1.TabIndex = 53;
            this.btn_last1.UseVisualStyleBackColor = false;
            this.btn_last1.Click += new System.EventHandler(this.btn_last1_Click);
            // 
            // btn_next1
            // 
            this.btn_next1.BackColor = System.Drawing.Color.Transparent;
            this.btn_next1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.navigate_next_FILL0_wght400_GRAD0_opsz48;
            this.btn_next1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_next1.Location = new System.Drawing.Point(171, 609);
            this.btn_next1.Name = "btn_next1";
            this.btn_next1.Size = new System.Drawing.Size(48, 45);
            this.btn_next1.TabIndex = 52;
            this.btn_next1.UseVisualStyleBackColor = false;
            this.btn_next1.Click += new System.EventHandler(this.btn_next1_Click);
            // 
            // btn_back1
            // 
            this.btn_back1.BackColor = System.Drawing.Color.Transparent;
            this.btn_back1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.navigate_before_FILL0_wght400_GRAD0_opsz48;
            this.btn_back1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back1.Location = new System.Drawing.Point(115, 609);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Size = new System.Drawing.Size(48, 45);
            this.btn_back1.TabIndex = 51;
            this.btn_back1.UseVisualStyleBackColor = false;
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // btn_top1
            // 
            this.btn_top1.BackColor = System.Drawing.Color.Transparent;
            this.btn_top1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.first_page_FILL0_wght400_GRAD0_opsz48;
            this.btn_top1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_top1.Location = new System.Drawing.Point(57, 609);
            this.btn_top1.Name = "btn_top1";
            this.btn_top1.Size = new System.Drawing.Size(48, 45);
            this.btn_top1.TabIndex = 50;
            this.btn_top1.UseVisualStyleBackColor = false;
            this.btn_top1.Click += new System.EventHandler(this.btn_top1_Click);
            // 
            // notabeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(834, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txttotal1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btn_undo1);
            this.Controls.Add(this.btn_save1);
            this.Controls.Add(this.btn_close1);
            this.Controls.Add(this.btn_del1);
            this.Controls.Add(this.btn_edit1);
            this.Controls.Add(this.btn_new1);
            this.Controls.Add(this.btn_find1);
            this.Controls.Add(this.btn_print1);
            this.Controls.Add(this.btn_last1);
            this.Controls.Add(this.btn_next1);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.dgvdetailbeli);
            this.Controls.Add(this.btn_top1);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "notabeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notabeli";
            this.Load += new System.EventHandler(this.notabeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailbeli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtjmlh1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttelpon1;
        private System.Windows.Forms.Label lbltlp1;
        private System.Windows.Forms.TextBox txtkota1;
        private System.Windows.Forms.Label lblkota1;
        private System.Windows.Forms.TextBox txtalamat1;
        private System.Windows.Forms.Label lblalamat1;
        private System.Windows.Forms.TextBox txtnmsup;
        private System.Windows.Forms.Label lblnama1;
        private System.Windows.Forms.TextBox txtkdsup;
        private System.Windows.Forms.Label lblkode1;
        private System.Windows.Forms.TextBox txtnotabeli;
        private System.Windows.Forms.Label lblnota1;
        private System.Windows.Forms.TextBox txttgl1;
        private System.Windows.Forms.Label lbltgl1;
        private System.Windows.Forms.Label lbljmlh1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txthrg1;
        private System.Windows.Forms.Label lblhrg1;
        private System.Windows.Forms.TextBox txtqty1;
        private System.Windows.Forms.Label lblqty1;
        private System.Windows.Forms.TextBox txtnmbrg1;
        private System.Windows.Forms.Label lblnm1;
        private System.Windows.Forms.TextBox txtkdbrg1;
        private System.Windows.Forms.Label lblkd1;
        private System.Windows.Forms.TextBox txttotal1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btn_undo1;
        private System.Windows.Forms.Button btn_save1;
        private System.Windows.Forms.Button btn_close1;
        private System.Windows.Forms.Button btn_del1;
        private System.Windows.Forms.Button btn_edit1;
        private System.Windows.Forms.Button btn_new1;
        private System.Windows.Forms.Button btn_find1;
        private System.Windows.Forms.Button btn_print1;
        private System.Windows.Forms.Button btn_last1;
        private System.Windows.Forms.Button btn_next1;
        private System.Windows.Forms.Button btn_back1;
        private System.Windows.Forms.DataGridView dgvdetailbeli;
        private System.Windows.Forms.Button btn_top1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnotabeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonotabeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdbuah;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmbuah;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
    }
}