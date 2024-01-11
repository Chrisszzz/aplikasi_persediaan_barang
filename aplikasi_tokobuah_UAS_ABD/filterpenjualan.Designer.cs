namespace aplikasi_tokobuah_UAS_ABD
{
    partial class filterpenjualan
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
            this.sd1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nof1 = new System.Windows.Forms.Label();
            this.txtjual1 = new System.Windows.Forms.TextBox();
            this.txtjual2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sd1
            // 
            this.sd1.AutoSize = true;
            this.sd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd1.ForeColor = System.Drawing.Color.White;
            this.sd1.Location = new System.Drawing.Point(249, 31);
            this.sd1.Name = "sd1";
            this.sd1.Size = new System.Drawing.Size(28, 13);
            this.sd1.TabIndex = 11;
            this.sd1.Text = "S.D";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nof1
            // 
            this.nof1.AutoSize = true;
            this.nof1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nof1.ForeColor = System.Drawing.Color.White;
            this.nof1.Location = new System.Drawing.Point(28, 31);
            this.nof1.Name = "nof1";
            this.nof1.Size = new System.Drawing.Size(81, 13);
            this.nof1.TabIndex = 7;
            this.nof1.Text = "No Nota Jual";
            // 
            // txtjual1
            // 
            this.txtjual1.Location = new System.Drawing.Point(116, 28);
            this.txtjual1.Name = "txtjual1";
            this.txtjual1.Size = new System.Drawing.Size(100, 20);
            this.txtjual1.TabIndex = 12;
            // 
            // txtjual2
            // 
            this.txtjual2.Location = new System.Drawing.Point(294, 28);
            this.txtjual2.Name = "txtjual2";
            this.txtjual2.Size = new System.Drawing.Size(100, 20);
            this.txtjual2.TabIndex = 13;
            // 
            // filterpenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(460, 158);
            this.Controls.Add(this.txtjual2);
            this.Controls.Add(this.txtjual1);
            this.Controls.Add(this.sd1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nof1);
            this.Name = "filterpenjualan";
            this.Text = "filterpenjualan";
            this.Load += new System.EventHandler(this.filterpenjualan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sd1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nof1;
        private System.Windows.Forms.TextBox txtjual1;
        private System.Windows.Forms.TextBox txtjual2;
    }
}