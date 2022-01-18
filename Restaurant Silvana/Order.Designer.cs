namespace Restaurant_Silvana
{
    partial class Order
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_pesanan = new System.Windows.Forms.Label();
            this.lbl_hargasatuan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.InterceptArrowKeys = false;
            this.numericUpDown1.Location = new System.Drawing.Point(244, 12);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_pesanan
            // 
            this.lbl_pesanan.AutoSize = true;
            this.lbl_pesanan.BackColor = System.Drawing.Color.White;
            this.lbl_pesanan.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesanan.Location = new System.Drawing.Point(43, 1);
            this.lbl_pesanan.Name = "lbl_pesanan";
            this.lbl_pesanan.Size = new System.Drawing.Size(123, 21);
            this.lbl_pesanan.TabIndex = 2;
            this.lbl_pesanan.Text = "Nama Makanan";
            // 
            // lbl_hargasatuan
            // 
            this.lbl_hargasatuan.AutoSize = true;
            this.lbl_hargasatuan.BackColor = System.Drawing.Color.White;
            this.lbl_hargasatuan.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hargasatuan.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_hargasatuan.Location = new System.Drawing.Point(43, 22);
            this.lbl_hargasatuan.Name = "lbl_hargasatuan";
            this.lbl_hargasatuan.Size = new System.Drawing.Size(98, 20);
            this.lbl_hargasatuan.TabIndex = 3;
            this.lbl_hargasatuan.Text = "Harga Satuan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 2);
            this.panel1.TabIndex = 8;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.BackColor = System.Drawing.Color.White;
            this.lbl_subtotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(307, 12);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(70, 20);
            this.lbl_subtotal.TabIndex = 10;
            this.lbl_subtotal.Text = "Sub Total";
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.White;
            this.btn_hapus.BackgroundImage = global::Restaurant_Silvana.Properties.Resources.Trash;
            this.btn_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hapus.FlatAppearance.BorderSize = 0;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.ForeColor = System.Drawing.Color.Transparent;
            this.btn_hapus.Location = new System.Drawing.Point(12, 11);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(20, 20);
            this.btn_hapus.TabIndex = 5;
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 44);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_hargasatuan);
            this.Controls.Add(this.lbl_pesanan);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(426, 45);
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pesanan;
        private System.Windows.Forms.Label lbl_hargasatuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_subtotal;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Button btn_hapus;
    }
}
