namespace Restaurant_Silvana
{
    partial class DaftarPesanan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_pesanan = new System.Windows.Forms.Label();
            this.lbl_Jumlah = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_pesanan
            // 
            this.lbl_pesanan.AutoSize = true;
            this.lbl_pesanan.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesanan.Location = new System.Drawing.Point(67, 4);
            this.lbl_pesanan.Name = "lbl_pesanan";
            this.lbl_pesanan.Size = new System.Drawing.Size(123, 21);
            this.lbl_pesanan.TabIndex = 14;
            this.lbl_pesanan.Text = "Nama Makanan";
            // 
            // lbl_Jumlah
            // 
            this.lbl_Jumlah.AutoSize = true;
            this.lbl_Jumlah.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jumlah.Location = new System.Drawing.Point(13, 4);
            this.lbl_Jumlah.Name = "lbl_Jumlah";
            this.lbl_Jumlah.Size = new System.Drawing.Size(19, 21);
            this.lbl_Jumlah.TabIndex = 16;
            this.lbl_Jumlah.Text = "0";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(272, 4);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(75, 21);
            this.lbl_subtotal.TabIndex = 17;
            this.lbl_subtotal.Text = "Sub Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 1);
            this.panel1.TabIndex = 18;
            // 
            // DaftarPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.lbl_Jumlah);
            this.Controls.Add(this.lbl_pesanan);
            this.Name = "DaftarPesanan";
            this.Size = new System.Drawing.Size(400, 33);
            this.Load += new System.EventHandler(this.DaftarPesanan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pesanan;
        private System.Windows.Forms.Label lbl_Jumlah;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Panel panel1;
    }
}
