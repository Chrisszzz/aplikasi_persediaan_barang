namespace aplikasi_tokobuah_UAS_ABD
{
    partial class filterbuah
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
            this.txtbuahf2 = new System.Windows.Forms.TextBox();
            this.txtbuahf1 = new System.Windows.Forms.TextBox();
            this.sd3 = new System.Windows.Forms.Label();
            this.closef3 = new System.Windows.Forms.Button();
            this.filter3 = new System.Windows.Forms.Button();
            this.nof3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbuahf2
            // 
            this.txtbuahf2.Location = new System.Drawing.Point(315, 37);
            this.txtbuahf2.Name = "txtbuahf2";
            this.txtbuahf2.Size = new System.Drawing.Size(100, 20);
            this.txtbuahf2.TabIndex = 25;
            // 
            // txtbuahf1
            // 
            this.txtbuahf1.Location = new System.Drawing.Point(137, 37);
            this.txtbuahf1.Name = "txtbuahf1";
            this.txtbuahf1.Size = new System.Drawing.Size(100, 20);
            this.txtbuahf1.TabIndex = 24;
            // 
            // sd3
            // 
            this.sd3.AutoSize = true;
            this.sd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd3.ForeColor = System.Drawing.Color.White;
            this.sd3.Location = new System.Drawing.Point(270, 40);
            this.sd3.Name = "sd3";
            this.sd3.Size = new System.Drawing.Size(28, 13);
            this.sd3.TabIndex = 23;
            this.sd3.Text = "S.D";
            // 
            // closef3
            // 
            this.closef3.Location = new System.Drawing.Point(249, 122);
            this.closef3.Name = "closef3";
            this.closef3.Size = new System.Drawing.Size(175, 23);
            this.closef3.TabIndex = 22;
            this.closef3.Text = "close";
            this.closef3.UseVisualStyleBackColor = true;
            this.closef3.Click += new System.EventHandler(this.closef3_Click);
            // 
            // filter3
            // 
            this.filter3.Location = new System.Drawing.Point(249, 93);
            this.filter3.Name = "filter3";
            this.filter3.Size = new System.Drawing.Size(175, 23);
            this.filter3.TabIndex = 21;
            this.filter3.Text = "Filter";
            this.filter3.UseVisualStyleBackColor = true;
            this.filter3.Click += new System.EventHandler(this.filter3_Click);
            // 
            // nof3
            // 
            this.nof3.AutoSize = true;
            this.nof3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nof3.ForeColor = System.Drawing.Color.White;
            this.nof3.Location = new System.Drawing.Point(49, 40);
            this.nof3.Name = "nof3";
            this.nof3.Size = new System.Drawing.Size(69, 13);
            this.nof3.TabIndex = 20;
            this.nof3.Text = "Kode Buah";
            // 
            // filterbuah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(514, 188);
            this.Controls.Add(this.txtbuahf2);
            this.Controls.Add(this.txtbuahf1);
            this.Controls.Add(this.sd3);
            this.Controls.Add(this.closef3);
            this.Controls.Add(this.filter3);
            this.Controls.Add(this.nof3);
            this.Name = "filterbuah";
            this.Text = "filterbuah";
            this.Load += new System.EventHandler(this.filterbuah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuahf2;
        private System.Windows.Forms.TextBox txtbuahf1;
        private System.Windows.Forms.Label sd3;
        private System.Windows.Forms.Button closef3;
        private System.Windows.Forms.Button filter3;
        private System.Windows.Forms.Label nof3;
    }
}