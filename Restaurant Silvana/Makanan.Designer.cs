namespace Restaurant_Silvana
{
    partial class Makanan
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
            this.lbl_harga = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.pnl_border = new System.Windows.Forms.Panel();
            this.lbl_nomor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.pnl_border.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_harga
            // 
            this.lbl_harga.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_harga.ForeColor = System.Drawing.Color.White;
            this.lbl_harga.Location = new System.Drawing.Point(7, 8);
            this.lbl_harga.Name = "lbl_harga";
            this.lbl_harga.Size = new System.Drawing.Size(101, 22);
            this.lbl_harga.TabIndex = 2;
            this.lbl_harga.Text = "Harga Makanan";
            this.lbl_harga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_harga.Click += new System.EventHandler(this.label2_Click);
            this.lbl_harga.MouseEnter += new System.EventHandler(this.lbl_harga_MouseEnter);
            this.lbl_harga.MouseLeave += new System.EventHandler(this.lbl_harga_MouseLeave);
            // 
            // lbl_nama
            // 
            this.lbl_nama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nama.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_nama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nama.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.ForeColor = System.Drawing.Color.White;
            this.lbl_nama.Location = new System.Drawing.Point(0, 139);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(161, 22);
            this.lbl_nama.TabIndex = 1;
            this.lbl_nama.Text = "Nama Makanan";
            this.lbl_nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nama.Click += new System.EventHandler(this.lbl_nama_Click);
            this.lbl_nama.MouseEnter += new System.EventHandler(this.lbl_nama_MouseEnter);
            this.lbl_nama.MouseLeave += new System.EventHandler(this.lbl_nama_MouseLeave);
            // 
            // pb_icon
            // 
            this.pb_icon.Location = new System.Drawing.Point(3, 3);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(155, 155);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icon.TabIndex = 0;
            this.pb_icon.TabStop = false;
            this.pb_icon.Click += new System.EventHandler(this.pb_icon_Click);
            this.pb_icon.MouseEnter += new System.EventHandler(this.pb_icon_MouseEnter);
            this.pb_icon.MouseLeave += new System.EventHandler(this.pb_icon_MouseLeave);
            this.pb_icon.MouseHover += new System.EventHandler(this.pb_icon_MouseHover);
            // 
            // pnl_border
            // 
            this.pnl_border.BackColor = System.Drawing.Color.Gold;
            this.pnl_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_border.Controls.Add(this.lbl_nomor);
            this.pnl_border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_border.Location = new System.Drawing.Point(0, 0);
            this.pnl_border.Name = "pnl_border";
            this.pnl_border.Size = new System.Drawing.Size(161, 161);
            this.pnl_border.TabIndex = 3;
            // 
            // lbl_nomor
            // 
            this.lbl_nomor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nomor.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomor.ForeColor = System.Drawing.Color.White;
            this.lbl_nomor.Location = new System.Drawing.Point(132, 11);
            this.lbl_nomor.Name = "lbl_nomor";
            this.lbl_nomor.Size = new System.Drawing.Size(31, 26);
            this.lbl_nomor.TabIndex = 4;
            this.lbl_nomor.Text = "1";
            this.lbl_nomor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nomor.Visible = false;
            // 
            // Makanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.lbl_harga);
            this.Controls.Add(this.pb_icon);
            this.Controls.Add(this.pnl_border);
            this.Name = "Makanan";
            this.Size = new System.Drawing.Size(161, 161);
            this.Load += new System.EventHandler(this.Makanan_Load);
            this.MouseEnter += new System.EventHandler(this.Makanan_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Makanan_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.pnl_border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_icon;
        public System.Windows.Forms.Label lbl_harga;
        public System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Panel pnl_border;
        public System.Windows.Forms.Label lbl_nomor;
    }
}
