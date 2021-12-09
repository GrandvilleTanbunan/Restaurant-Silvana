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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.lbl_nomor = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.InterceptArrowKeys = false;
            this.numericUpDown1.Location = new System.Drawing.Point(220, 9);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 26);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_pesanan
            // 
            this.lbl_pesanan.AutoSize = true;
            this.lbl_pesanan.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesanan.Location = new System.Drawing.Point(44, 3);
            this.lbl_pesanan.Name = "lbl_pesanan";
            this.lbl_pesanan.Size = new System.Drawing.Size(123, 21);
            this.lbl_pesanan.TabIndex = 2;
            this.lbl_pesanan.Text = "Nama Makanan";
            // 
            // lbl_hargasatuan
            // 
            this.lbl_hargasatuan.AutoSize = true;
            this.lbl_hargasatuan.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hargasatuan.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_hargasatuan.Location = new System.Drawing.Point(44, 22);
            this.lbl_hargasatuan.Name = "lbl_hargasatuan";
            this.lbl_hargasatuan.Size = new System.Drawing.Size(105, 21);
            this.lbl_hargasatuan.TabIndex = 3;
            this.lbl_hargasatuan.Text = "Harga Satuan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rp";
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.Transparent;
            this.btn_hapus.BackgroundImage = global::Restaurant_Silvana.Properties.Resources.Trash;
            this.btn_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hapus.Enabled = false;
            this.btn_hapus.FlatAppearance.BorderSize = 0;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.ForeColor = System.Drawing.Color.Transparent;
            this.btn_hapus.Location = new System.Drawing.Point(10, 10);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(23, 23);
            this.btn_hapus.TabIndex = 5;
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // lbl_nomor
            // 
            this.lbl_nomor.AutoSize = true;
            this.lbl_nomor.Location = new System.Drawing.Point(326, 15);
            this.lbl_nomor.Name = "lbl_nomor";
            this.lbl_nomor.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomor.TabIndex = 6;
            this.lbl_nomor.Text = "label2";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(376, 15);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(35, 13);
            this.lbl_category.TabIndex = 7;
            this.lbl_category.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 2);
            this.panel1.TabIndex = 8;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_nomor);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_hargasatuan);
            this.Controls.Add(this.lbl_pesanan);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(436, 50);
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_pesanan;
        private System.Windows.Forms.Label lbl_hargasatuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Label lbl_nomor;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Panel panel1;
    }
}
