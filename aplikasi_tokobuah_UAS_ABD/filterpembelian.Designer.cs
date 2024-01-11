namespace aplikasi_tokobuah_UAS_ABD
{
    partial class filterpembelian
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
            this.txtbeli2 = new System.Windows.Forms.TextBox();
            this.txtbeli1 = new System.Windows.Forms.TextBox();
            this.sd2 = new System.Windows.Forms.Label();
            this.closef1 = new System.Windows.Forms.Button();
            this.filter1 = new System.Windows.Forms.Button();
            this.nof2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbeli2
            // 
            this.txtbeli2.Location = new System.Drawing.Point(311, 34);
            this.txtbeli2.Name = "txtbeli2";
            this.txtbeli2.Size = new System.Drawing.Size(100, 20);
            this.txtbeli2.TabIndex = 19;
            // 
            // txtbeli1
            // 
            this.txtbeli1.Location = new System.Drawing.Point(133, 34);
            this.txtbeli1.Name = "txtbeli1";
            this.txtbeli1.Size = new System.Drawing.Size(100, 20);
            this.txtbeli1.TabIndex = 18;
            // 
            // sd2
            // 
            this.sd2.AutoSize = true;
            this.sd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd2.ForeColor = System.Drawing.Color.White;
            this.sd2.Location = new System.Drawing.Point(266, 37);
            this.sd2.Name = "sd2";
            this.sd2.Size = new System.Drawing.Size(28, 13);
            this.sd2.TabIndex = 17;
            this.sd2.Text = "S.D";
            // 
            // closef1
            // 
            this.closef1.Location = new System.Drawing.Point(245, 119);
            this.closef1.Name = "closef1";
            this.closef1.Size = new System.Drawing.Size(175, 23);
            this.closef1.TabIndex = 16;
            this.closef1.Text = "close";
            this.closef1.UseVisualStyleBackColor = true;
            this.closef1.Click += new System.EventHandler(this.closef1_Click);
            // 
            // filter1
            // 
            this.filter1.Location = new System.Drawing.Point(245, 90);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(175, 23);
            this.filter1.TabIndex = 15;
            this.filter1.Text = "Filter";
            this.filter1.UseVisualStyleBackColor = true;
            this.filter1.Click += new System.EventHandler(this.filter1_Click);
            // 
            // nof2
            // 
            this.nof2.AutoSize = true;
            this.nof2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nof2.ForeColor = System.Drawing.Color.White;
            this.nof2.Location = new System.Drawing.Point(45, 37);
            this.nof2.Name = "nof2";
            this.nof2.Size = new System.Drawing.Size(79, 13);
            this.nof2.TabIndex = 14;
            this.nof2.Text = "No Nota Beli";
            // 
            // filterpembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(483, 177);
            this.Controls.Add(this.txtbeli2);
            this.Controls.Add(this.txtbeli1);
            this.Controls.Add(this.sd2);
            this.Controls.Add(this.closef1);
            this.Controls.Add(this.filter1);
            this.Controls.Add(this.nof2);
            this.Name = "filterpembelian";
            this.Text = "filterpembelian";
            this.Load += new System.EventHandler(this.filterpembelian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbeli2;
        private System.Windows.Forms.TextBox txtbeli1;
        private System.Windows.Forms.Label sd2;
        private System.Windows.Forms.Button closef1;
        private System.Windows.Forms.Button filter1;
        private System.Windows.Forms.Label nof2;
    }
}