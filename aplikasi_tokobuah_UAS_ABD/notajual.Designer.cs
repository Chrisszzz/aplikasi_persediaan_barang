namespace aplikasi_tokobuah_UAS_ABD
{
    partial class notajual
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
            this.lbltotal2 = new System.Windows.Forms.Label();
            this.txttotal2 = new System.Windows.Forms.TextBox();
            this.dgvdetailjual = new System.Windows.Forms.DataGridView();
            this.idnotajual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonotabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdbuah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbuah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_undo2 = new System.Windows.Forms.Button();
            this.btn_save2 = new System.Windows.Forms.Button();
            this.btn_close2 = new System.Windows.Forms.Button();
            this.btn_del2 = new System.Windows.Forms.Button();
            this.btn_edit2 = new System.Windows.Forms.Button();
            this.btn_new2 = new System.Windows.Forms.Button();
            this.btn_find2 = new System.Windows.Forms.Button();
            this.btn_print2 = new System.Windows.Forms.Button();
            this.btn_last2 = new System.Windows.Forms.Button();
            this.btn_next2 = new System.Windows.Forms.Button();
            this.btn_back2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttelpon2 = new System.Windows.Forms.TextBox();
            this.lbltlp2 = new System.Windows.Forms.Label();
            this.txtalamat2 = new System.Windows.Forms.TextBox();
            this.lblalamat2 = new System.Windows.Forms.Label();
            this.txtnmcus = new System.Windows.Forms.TextBox();
            this.lblnama2 = new System.Windows.Forms.Label();
            this.txtkdcus = new System.Windows.Forms.TextBox();
            this.lblkode2 = new System.Windows.Forms.Label();
            this.txtnotajual = new System.Windows.Forms.TextBox();
            this.lblnota2 = new System.Windows.Forms.Label();
            this.txttgl2 = new System.Windows.Forms.TextBox();
            this.lbltgl2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtjmlh2 = new System.Windows.Forms.TextBox();
            this.lbljmlh2 = new System.Windows.Forms.Label();
            this.txthrg2 = new System.Windows.Forms.TextBox();
            this.lblhrg2 = new System.Windows.Forms.Label();
            this.txtqty2 = new System.Windows.Forms.TextBox();
            this.lblqty2 = new System.Windows.Forms.Label();
            this.txtnmbrg2 = new System.Windows.Forms.TextBox();
            this.lblnm2 = new System.Windows.Forms.Label();
            this.txtkdbrg2 = new System.Windows.Forms.TextBox();
            this.lblkd2 = new System.Windows.Forms.Label();
            this.btn_top2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailjual)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltotal2
            // 
            this.lbltotal2.AutoSize = true;
            this.lbltotal2.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal2.ForeColor = System.Drawing.Color.White;
            this.lbltotal2.Location = new System.Drawing.Point(539, 611);
            this.lbltotal2.Name = "lbltotal2";
            this.lbltotal2.Size = new System.Drawing.Size(57, 13);
            this.lbltotal2.TabIndex = 79;
            this.lbltotal2.Text = "Total (Rp)";
            // 
            // txttotal2
            // 
            this.txttotal2.AcceptsReturn = true;
            this.txttotal2.BackColor = System.Drawing.Color.SteelBlue;
            this.txttotal2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal2.ForeColor = System.Drawing.Color.White;
            this.txttotal2.Location = new System.Drawing.Point(601, 606);
            this.txttotal2.Name = "txttotal2";
            this.txttotal2.Size = new System.Drawing.Size(101, 25);
            this.txttotal2.TabIndex = 80;
            this.txttotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvdetailjual
            // 
            this.dgvdetailjual.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvdetailjual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetailjual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnotajual,
            this.nonotabeli,
            this.kdbuah,
            this.nmbuah,
            this.qty,
            this.harga,
            this.jumlahk});
            this.dgvdetailjual.GridColor = System.Drawing.Color.White;
            this.dgvdetailjual.Location = new System.Drawing.Point(59, 282);
            this.dgvdetailjual.Name = "dgvdetailjual";
            this.dgvdetailjual.Size = new System.Drawing.Size(642, 298);
            this.dgvdetailjual.TabIndex = 66;
            this.dgvdetailjual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvdetailjual_KeyDown);
            // 
            // idnotajual
            // 
            this.idnotajual.DataPropertyName = "idnotajual";
            this.idnotajual.HeaderText = "id nota jual";
            this.idnotajual.Name = "idnotajual";
            this.idnotajual.Visible = false;
            // 
            // nonotabeli
            // 
            this.nonotabeli.DataPropertyName = "nonotajual";
            this.nonotabeli.HeaderText = "no nota jual";
            this.nonotabeli.Name = "nonotabeli";
            this.nonotabeli.Visible = false;
            // 
            // kdbuah
            // 
            this.kdbuah.DataPropertyName = "kdbuah";
            this.kdbuah.HeaderText = "kode buah";
            this.kdbuah.Name = "kdbuah";
            // 
            // nmbuah
            // 
            this.nmbuah.DataPropertyName = "nmbuah";
            this.nmbuah.HeaderText = "nama buah";
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
            this.harga.HeaderText = "harga";
            this.harga.Name = "harga";
            // 
            // jumlahk
            // 
            this.jumlahk.DataPropertyName = "jumlah";
            this.jumlahk.HeaderText = "jumlah";
            this.jumlahk.Name = "jumlahk";
            this.jumlahk.ReadOnly = true;
            // 
            // btn_undo2
            // 
            this.btn_undo2.BackColor = System.Drawing.Color.Transparent;
            this.btn_undo2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.undo_FILL0_wght400_GRAD0_opsz48;
            this.btn_undo2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_undo2.Location = new System.Drawing.Point(432, 606);
            this.btn_undo2.Name = "btn_undo2";
            this.btn_undo2.Size = new System.Drawing.Size(48, 45);
            this.btn_undo2.TabIndex = 78;
            this.btn_undo2.UseVisualStyleBackColor = false;
            this.btn_undo2.Click += new System.EventHandler(this.btn_undo2_Click);
            // 
            // btn_save2
            // 
            this.btn_save2.BackColor = System.Drawing.Color.Transparent;
            this.btn_save2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.save_FILL0_wght400_GRAD0_opsz48;
            this.btn_save2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save2.Location = new System.Drawing.Point(375, 606);
            this.btn_save2.Name = "btn_save2";
            this.btn_save2.Size = new System.Drawing.Size(48, 45);
            this.btn_save2.TabIndex = 77;
            this.btn_save2.UseVisualStyleBackColor = false;
            this.btn_save2.Click += new System.EventHandler(this.btn_save2_Click);
            // 
            // btn_close2
            // 
            this.btn_close2.BackColor = System.Drawing.Color.Transparent;
            this.btn_close2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.close_FILL0_wght400_GRAD0_opsz48;
            this.btn_close2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close2.Location = new System.Drawing.Point(727, 535);
            this.btn_close2.Name = "btn_close2";
            this.btn_close2.Size = new System.Drawing.Size(48, 45);
            this.btn_close2.TabIndex = 76;
            this.btn_close2.UseVisualStyleBackColor = false;
            this.btn_close2.Click += new System.EventHandler(this.btn_close2_Click);
            // 
            // btn_del2
            // 
            this.btn_del2.BackColor = System.Drawing.Color.Transparent;
            this.btn_del2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz48;
            this.btn_del2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_del2.Location = new System.Drawing.Point(727, 382);
            this.btn_del2.Name = "btn_del2";
            this.btn_del2.Size = new System.Drawing.Size(48, 45);
            this.btn_del2.TabIndex = 75;
            this.btn_del2.UseVisualStyleBackColor = false;
            this.btn_del2.Click += new System.EventHandler(this.btn_del2_Click);
            // 
            // btn_edit2
            // 
            this.btn_edit2.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz48;
            this.btn_edit2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_edit2.Location = new System.Drawing.Point(727, 333);
            this.btn_edit2.Name = "btn_edit2";
            this.btn_edit2.Size = new System.Drawing.Size(48, 45);
            this.btn_edit2.TabIndex = 74;
            this.btn_edit2.UseVisualStyleBackColor = false;
            this.btn_edit2.Click += new System.EventHandler(this.btn_edit2_Click);
            // 
            // btn_new2
            // 
            this.btn_new2.BackColor = System.Drawing.Color.Transparent;
            this.btn_new2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.add_FILL0_wght400_GRAD0_opsz48;
            this.btn_new2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_new2.Location = new System.Drawing.Point(727, 282);
            this.btn_new2.Name = "btn_new2";
            this.btn_new2.Size = new System.Drawing.Size(48, 45);
            this.btn_new2.TabIndex = 73;
            this.btn_new2.UseVisualStyleBackColor = false;
            this.btn_new2.Click += new System.EventHandler(this.btn_new2_Click);
            // 
            // btn_find2
            // 
            this.btn_find2.BackColor = System.Drawing.Color.Transparent;
            this.btn_find2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48;
            this.btn_find2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find2.Location = new System.Drawing.Point(727, 484);
            this.btn_find2.Name = "btn_find2";
            this.btn_find2.Size = new System.Drawing.Size(48, 45);
            this.btn_find2.TabIndex = 72;
            this.btn_find2.UseVisualStyleBackColor = false;
            this.btn_find2.Click += new System.EventHandler(this.btn_find2_Click);
            // 
            // btn_print2
            // 
            this.btn_print2.BackColor = System.Drawing.Color.Transparent;
            this.btn_print2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            this.btn_print2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_print2.Location = new System.Drawing.Point(727, 433);
            this.btn_print2.Name = "btn_print2";
            this.btn_print2.Size = new System.Drawing.Size(48, 45);
            this.btn_print2.TabIndex = 71;
            this.btn_print2.UseVisualStyleBackColor = false;
            this.btn_print2.Click += new System.EventHandler(this.btn_print2_Click);
            // 
            // btn_last2
            // 
            this.btn_last2.BackColor = System.Drawing.Color.Transparent;
            this.btn_last2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.last_page_FILL0_wght400_GRAD0_opsz48;
            this.btn_last2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_last2.Location = new System.Drawing.Point(227, 606);
            this.btn_last2.Name = "btn_last2";
            this.btn_last2.Size = new System.Drawing.Size(48, 45);
            this.btn_last2.TabIndex = 70;
            this.btn_last2.UseVisualStyleBackColor = false;
            this.btn_last2.Click += new System.EventHandler(this.btn_last2_Click);
            // 
            // btn_next2
            // 
            this.btn_next2.BackColor = System.Drawing.Color.Transparent;
            this.btn_next2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.navigate_next_FILL0_wght400_GRAD0_opsz48;
            this.btn_next2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_next2.Location = new System.Drawing.Point(173, 606);
            this.btn_next2.Name = "btn_next2";
            this.btn_next2.Size = new System.Drawing.Size(48, 45);
            this.btn_next2.TabIndex = 69;
            this.btn_next2.UseVisualStyleBackColor = false;
            this.btn_next2.Click += new System.EventHandler(this.btn_next2_Click);
            // 
            // btn_back2
            // 
            this.btn_back2.BackColor = System.Drawing.Color.Transparent;
            this.btn_back2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.navigate_before_FILL0_wght400_GRAD0_opsz48;
            this.btn_back2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back2.Location = new System.Drawing.Point(117, 606);
            this.btn_back2.Name = "btn_back2";
            this.btn_back2.Size = new System.Drawing.Size(48, 45);
            this.btn_back2.TabIndex = 68;
            this.btn_back2.UseVisualStyleBackColor = false;
            this.btn_back2.Click += new System.EventHandler(this.btn_back2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.test2_removebg_preview;
            this.groupBox1.Controls.Add(this.txttelpon2);
            this.groupBox1.Controls.Add(this.lbltlp2);
            this.groupBox1.Controls.Add(this.txtalamat2);
            this.groupBox1.Controls.Add(this.lblalamat2);
            this.groupBox1.Controls.Add(this.txtnmcus);
            this.groupBox1.Controls.Add(this.lblnama2);
            this.groupBox1.Controls.Add(this.txtkdcus);
            this.groupBox1.Controls.Add(this.lblkode2);
            this.groupBox1.Controls.Add(this.txtnotajual);
            this.groupBox1.Controls.Add(this.lblnota2);
            this.groupBox1.Controls.Add(this.txttgl2);
            this.groupBox1.Controls.Add(this.lbltgl2);
            this.groupBox1.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(59, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 130);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUSTOMER";
            // 
            // txttelpon2
            // 
            this.txttelpon2.AcceptsReturn = true;
            this.txttelpon2.BackColor = System.Drawing.Color.SteelBlue;
            this.txttelpon2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelpon2.ForeColor = System.Drawing.Color.White;
            this.txttelpon2.Location = new System.Drawing.Point(420, 87);
            this.txttelpon2.Name = "txttelpon2";
            this.txttelpon2.Size = new System.Drawing.Size(101, 25);
            this.txttelpon2.TabIndex = 13;
            this.txttelpon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltlp2
            // 
            this.lbltlp2.AutoSize = true;
            this.lbltlp2.BackColor = System.Drawing.Color.CadetBlue;
            this.lbltlp2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltlp2.ForeColor = System.Drawing.Color.White;
            this.lbltlp2.Location = new System.Drawing.Point(417, 69);
            this.lbltlp2.Name = "lbltlp2";
            this.lbltlp2.Size = new System.Drawing.Size(48, 13);
            this.lbltlp2.TabIndex = 12;
            this.lbltlp2.Text = "Telepon";
            // 
            // txtalamat2
            // 
            this.txtalamat2.AcceptsReturn = true;
            this.txtalamat2.BackColor = System.Drawing.Color.SteelBlue;
            this.txtalamat2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalamat2.ForeColor = System.Drawing.Color.White;
            this.txtalamat2.Location = new System.Drawing.Point(284, 88);
            this.txtalamat2.Name = "txtalamat2";
            this.txtalamat2.Size = new System.Drawing.Size(101, 25);
            this.txtalamat2.TabIndex = 9;
            this.txtalamat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblalamat2
            // 
            this.lblalamat2.AutoSize = true;
            this.lblalamat2.BackColor = System.Drawing.Color.CadetBlue;
            this.lblalamat2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalamat2.ForeColor = System.Drawing.Color.White;
            this.lblalamat2.Location = new System.Drawing.Point(281, 70);
            this.lblalamat2.Name = "lblalamat2";
            this.lblalamat2.Size = new System.Drawing.Size(44, 13);
            this.lblalamat2.TabIndex = 8;
            this.lblalamat2.Text = "Alamat";
            // 
            // txtnmcus
            // 
            this.txtnmcus.AcceptsReturn = true;
            this.txtnmcus.BackColor = System.Drawing.Color.SteelBlue;
            this.txtnmcus.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmcus.ForeColor = System.Drawing.Color.White;
            this.txtnmcus.Location = new System.Drawing.Point(149, 89);
            this.txtnmcus.Name = "txtnmcus";
            this.txtnmcus.Size = new System.Drawing.Size(101, 25);
            this.txtnmcus.TabIndex = 7;
            this.txtnmcus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnama2
            // 
            this.lblnama2.AutoSize = true;
            this.lblnama2.BackColor = System.Drawing.Color.CadetBlue;
            this.lblnama2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnama2.ForeColor = System.Drawing.Color.White;
            this.lblnama2.Location = new System.Drawing.Point(146, 73);
            this.lblnama2.Name = "lblnama2";
            this.lblnama2.Size = new System.Drawing.Size(91, 13);
            this.lblnama2.TabIndex = 6;
            this.lblnama2.Text = "Nama Customer";
            // 
            // txtkdcus
            // 
            this.txtkdcus.AcceptsReturn = true;
            this.txtkdcus.BackColor = System.Drawing.Color.SteelBlue;
            this.txtkdcus.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkdcus.ForeColor = System.Drawing.Color.White;
            this.txtkdcus.Location = new System.Drawing.Point(19, 90);
            this.txtkdcus.Name = "txtkdcus";
            this.txtkdcus.Size = new System.Drawing.Size(101, 25);
            this.txtkdcus.TabIndex = 5;
            this.txtkdcus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtkdcus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtkdcus_KeyUp);
            this.txtkdcus.Validated += new System.EventHandler(this.txtkdcus_Validated);
            // 
            // lblkode2
            // 
            this.lblkode2.AutoSize = true;
            this.lblkode2.BackColor = System.Drawing.Color.CadetBlue;
            this.lblkode2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkode2.ForeColor = System.Drawing.Color.White;
            this.lblkode2.Location = new System.Drawing.Point(16, 74);
            this.lblkode2.Name = "lblkode2";
            this.lblkode2.Size = new System.Drawing.Size(87, 13);
            this.lblkode2.TabIndex = 4;
            this.lblkode2.Text = "Kode Customer";
            // 
            // txtnotajual
            // 
            this.txtnotajual.AcceptsReturn = true;
            this.txtnotajual.BackColor = System.Drawing.Color.SteelBlue;
            this.txtnotajual.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotajual.ForeColor = System.Drawing.Color.White;
            this.txtnotajual.Location = new System.Drawing.Point(19, 35);
            this.txtnotajual.Name = "txtnotajual";
            this.txtnotajual.Size = new System.Drawing.Size(102, 25);
            this.txtnotajual.TabIndex = 3;
            this.txtnotajual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnota2
            // 
            this.lblnota2.AutoSize = true;
            this.lblnota2.BackColor = System.Drawing.Color.CadetBlue;
            this.lblnota2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota2.ForeColor = System.Drawing.Color.White;
            this.lblnota2.Location = new System.Drawing.Point(17, 18);
            this.lblnota2.Name = "lblnota2";
            this.lblnota2.Size = new System.Drawing.Size(79, 13);
            this.lblnota2.TabIndex = 2;
            this.lblnota2.Text = "No. Nota Jual";
            // 
            // txttgl2
            // 
            this.txttgl2.AcceptsReturn = true;
            this.txttgl2.BackColor = System.Drawing.Color.SteelBlue;
            this.txttgl2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttgl2.ForeColor = System.Drawing.Color.White;
            this.txttgl2.Location = new System.Drawing.Point(149, 35);
            this.txttgl2.Name = "txttgl2";
            this.txttgl2.Size = new System.Drawing.Size(236, 25);
            this.txttgl2.TabIndex = 1;
            // 
            // lbltgl2
            // 
            this.lbltgl2.AutoSize = true;
            this.lbltgl2.BackColor = System.Drawing.Color.CadetBlue;
            this.lbltgl2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltgl2.ForeColor = System.Drawing.Color.White;
            this.lbltgl2.Location = new System.Drawing.Point(147, 19);
            this.lbltgl2.Name = "lbltgl2";
            this.lbltgl2.Size = new System.Drawing.Size(48, 13);
            this.lbltgl2.TabIndex = 0;
            this.lbltgl2.Text = "Tanggal";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.buah_back_1_removebg_preview;
            this.groupBox2.Controls.Add(this.txtjmlh2);
            this.groupBox2.Controls.Add(this.lbljmlh2);
            this.groupBox2.Controls.Add(this.txthrg2);
            this.groupBox2.Controls.Add(this.lblhrg2);
            this.groupBox2.Controls.Add(this.txtqty2);
            this.groupBox2.Controls.Add(this.lblqty2);
            this.groupBox2.Controls.Add(this.txtnmbrg2);
            this.groupBox2.Controls.Add(this.lblnm2);
            this.groupBox2.Controls.Add(this.txtkdbrg2);
            this.groupBox2.Controls.Add(this.lblkd2);
            this.groupBox2.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(61, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 76);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENTRY DATA ";
            // 
            // txtjmlh2
            // 
            this.txtjmlh2.AcceptsReturn = true;
            this.txtjmlh2.BackColor = System.Drawing.Color.SteelBlue;
            this.txtjmlh2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjmlh2.ForeColor = System.Drawing.Color.White;
            this.txtjmlh2.Location = new System.Drawing.Point(484, 35);
            this.txtjmlh2.Name = "txtjmlh2";
            this.txtjmlh2.Size = new System.Drawing.Size(102, 25);
            this.txtjmlh2.TabIndex = 47;
            this.txtjmlh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtjmlh2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtjmlh2_KeyDown);
            // 
            // lbljmlh2
            // 
            this.lbljmlh2.AutoSize = true;
            this.lbljmlh2.BackColor = System.Drawing.Color.CadetBlue;
            this.lbljmlh2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljmlh2.ForeColor = System.Drawing.Color.White;
            this.lbljmlh2.Location = new System.Drawing.Point(482, 18);
            this.lbljmlh2.Name = "lbljmlh2";
            this.lbljmlh2.Size = new System.Drawing.Size(43, 13);
            this.lbljmlh2.TabIndex = 46;
            this.lbljmlh2.Text = "jumlah";
            // 
            // txthrg2
            // 
            this.txthrg2.AcceptsReturn = true;
            this.txthrg2.BackColor = System.Drawing.Color.SteelBlue;
            this.txthrg2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthrg2.ForeColor = System.Drawing.Color.White;
            this.txthrg2.Location = new System.Drawing.Point(367, 35);
            this.txthrg2.Name = "txthrg2";
            this.txthrg2.Size = new System.Drawing.Size(102, 25);
            this.txthrg2.TabIndex = 45;
            this.txthrg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txthrg2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txthrg2_KeyDown);
            this.txthrg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthrg2_KeyPress);
            this.txthrg2.Validated += new System.EventHandler(this.txthrg2_Validated);
            // 
            // lblhrg2
            // 
            this.lblhrg2.AutoSize = true;
            this.lblhrg2.BackColor = System.Drawing.Color.CadetBlue;
            this.lblhrg2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrg2.ForeColor = System.Drawing.Color.White;
            this.lblhrg2.Location = new System.Drawing.Point(365, 18);
            this.lblhrg2.Name = "lblhrg2";
            this.lblhrg2.Size = new System.Drawing.Size(37, 13);
            this.lblhrg2.TabIndex = 44;
            this.lblhrg2.Text = "harga";
            // 
            // txtqty2
            // 
            this.txtqty2.AcceptsReturn = true;
            this.txtqty2.BackColor = System.Drawing.Color.SteelBlue;
            this.txtqty2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty2.ForeColor = System.Drawing.Color.White;
            this.txtqty2.Location = new System.Drawing.Point(306, 35);
            this.txtqty2.Name = "txtqty2";
            this.txtqty2.Size = new System.Drawing.Size(44, 25);
            this.txtqty2.TabIndex = 43;
            this.txtqty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty2_KeyDown);
            this.txtqty2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty2_KeyPress);
            this.txtqty2.Validated += new System.EventHandler(this.txtqty2_Validated);
            // 
            // lblqty2
            // 
            this.lblqty2.AutoSize = true;
            this.lblqty2.BackColor = System.Drawing.Color.CadetBlue;
            this.lblqty2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty2.ForeColor = System.Drawing.Color.White;
            this.lblqty2.Location = new System.Drawing.Point(304, 18);
            this.lblqty2.Name = "lblqty2";
            this.lblqty2.Size = new System.Drawing.Size(24, 13);
            this.lblqty2.TabIndex = 42;
            this.lblqty2.Text = "qty";
            // 
            // txtnmbrg2
            // 
            this.txtnmbrg2.AcceptsReturn = true;
            this.txtnmbrg2.BackColor = System.Drawing.Color.SteelBlue;
            this.txtnmbrg2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmbrg2.ForeColor = System.Drawing.Color.White;
            this.txtnmbrg2.Location = new System.Drawing.Point(112, 36);
            this.txtnmbrg2.Name = "txtnmbrg2";
            this.txtnmbrg2.Size = new System.Drawing.Size(178, 25);
            this.txtnmbrg2.TabIndex = 41;
            this.txtnmbrg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnm2
            // 
            this.lblnm2.AutoSize = true;
            this.lblnm2.BackColor = System.Drawing.Color.CadetBlue;
            this.lblnm2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnm2.ForeColor = System.Drawing.Color.White;
            this.lblnm2.Location = new System.Drawing.Point(110, 19);
            this.lblnm2.Name = "lblnm2";
            this.lblnm2.Size = new System.Drawing.Size(76, 13);
            this.lblnm2.TabIndex = 40;
            this.lblnm2.Text = "nama barang";
            // 
            // txtkdbrg2
            // 
            this.txtkdbrg2.AcceptsReturn = true;
            this.txtkdbrg2.BackColor = System.Drawing.Color.SteelBlue;
            this.txtkdbrg2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkdbrg2.ForeColor = System.Drawing.Color.White;
            this.txtkdbrg2.Location = new System.Drawing.Point(16, 36);
            this.txtkdbrg2.Name = "txtkdbrg2";
            this.txtkdbrg2.Size = new System.Drawing.Size(80, 25);
            this.txtkdbrg2.TabIndex = 15;
            this.txtkdbrg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtkdbrg2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtkdbrg2_KeyUp);
            this.txtkdbrg2.Leave += new System.EventHandler(this.txtkdbrg2_Leave);
            this.txtkdbrg2.Validated += new System.EventHandler(this.txtkdbrg2_Validated);
            // 
            // lblkd2
            // 
            this.lblkd2.AutoSize = true;
            this.lblkd2.BackColor = System.Drawing.Color.CadetBlue;
            this.lblkd2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkd2.ForeColor = System.Drawing.Color.White;
            this.lblkd2.Location = new System.Drawing.Point(14, 19);
            this.lblkd2.Name = "lblkd2";
            this.lblkd2.Size = new System.Drawing.Size(73, 13);
            this.lblkd2.TabIndex = 14;
            this.lblkd2.Text = "kode barang";
            // 
            // btn_top2
            // 
            this.btn_top2.BackColor = System.Drawing.Color.Transparent;
            this.btn_top2.BackgroundImage = global::aplikasi_tokobuah_UAS_ABD.Properties.Resources.first_page_FILL0_wght400_GRAD0_opsz48;
            this.btn_top2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_top2.Location = new System.Drawing.Point(59, 606);
            this.btn_top2.Name = "btn_top2";
            this.btn_top2.Size = new System.Drawing.Size(48, 45);
            this.btn_top2.TabIndex = 67;
            this.btn_top2.UseVisualStyleBackColor = false;
            this.btn_top2.Click += new System.EventHandler(this.btn_top2_Click);
            // 
            // notajual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(834, 671);
            this.Controls.Add(this.lbltotal2);
            this.Controls.Add(this.btn_undo2);
            this.Controls.Add(this.btn_save2);
            this.Controls.Add(this.btn_close2);
            this.Controls.Add(this.txttotal2);
            this.Controls.Add(this.btn_del2);
            this.Controls.Add(this.btn_edit2);
            this.Controls.Add(this.btn_new2);
            this.Controls.Add(this.btn_find2);
            this.Controls.Add(this.btn_print2);
            this.Controls.Add(this.btn_last2);
            this.Controls.Add(this.btn_next2);
            this.Controls.Add(this.btn_back2);
            this.Controls.Add(this.dgvdetailjual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_top2);
            this.Name = "notajual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notajual";
            this.Load += new System.EventHandler(this.notajual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailjual)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotal2;
        private System.Windows.Forms.Button btn_undo2;
        private System.Windows.Forms.Button btn_save2;
        private System.Windows.Forms.Button btn_close2;
        private System.Windows.Forms.TextBox txtjmlh2;
        private System.Windows.Forms.TextBox txttotal2;
        private System.Windows.Forms.Label lblnota2;
        private System.Windows.Forms.Button btn_del2;
        private System.Windows.Forms.Button btn_edit2;
        private System.Windows.Forms.TextBox txthrg2;
        private System.Windows.Forms.Label lbljmlh2;
        private System.Windows.Forms.Label lblhrg2;
        private System.Windows.Forms.Button btn_new2;
        private System.Windows.Forms.Button btn_find2;
        private System.Windows.Forms.Button btn_print2;
        private System.Windows.Forms.Button btn_last2;
        private System.Windows.Forms.Button btn_next2;
        private System.Windows.Forms.TextBox txtqty2;
        private System.Windows.Forms.Button btn_back2;
        private System.Windows.Forms.DataGridView dgvdetailjual;
        private System.Windows.Forms.Label lblqty2;
        private System.Windows.Forms.TextBox txttelpon2;
        private System.Windows.Forms.TextBox txtnmbrg2;
        private System.Windows.Forms.Label lbltlp2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtalamat2;
        private System.Windows.Forms.Label lblalamat2;
        private System.Windows.Forms.TextBox txtnmcus;
        private System.Windows.Forms.Label lblnama2;
        private System.Windows.Forms.TextBox txtkdcus;
        private System.Windows.Forms.Label lblkode2;
        private System.Windows.Forms.TextBox txtnotajual;
        private System.Windows.Forms.TextBox txttgl2;
        private System.Windows.Forms.Label lbltgl2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblnm2;
        private System.Windows.Forms.TextBox txtkdbrg2;
        private System.Windows.Forms.Label lblkd2;
        private System.Windows.Forms.Button btn_top2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnotajual;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonotabeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdbuah;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmbuah;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahk;
    }
}