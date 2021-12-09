namespace Restaurant_Silvana
{
    partial class TambahMenu
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.tb_nama_makanan = new System.Windows.Forms.TextBox();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(153, 333);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(172, 38);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Pilih Gambar";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tb_nama_makanan
            // 
            this.tb_nama_makanan.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nama_makanan.Location = new System.Drawing.Point(82, 380);
            this.tb_nama_makanan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_nama_makanan.Name = "tb_nama_makanan";
            this.tb_nama_makanan.Size = new System.Drawing.Size(314, 31);
            this.tb_nama_makanan.TabIndex = 2;
            this.tb_nama_makanan.Text = "Nama Makanan";
            this.tb_nama_makanan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_nama_makanan_MouseClick);
            this.tb_nama_makanan.TextChanged += new System.EventHandler(this.tb_nama_makanan_TextChanged);
            this.tb_nama_makanan.Leave += new System.EventHandler(this.tb_nama_makanan_Leave);
            this.tb_nama_makanan.MouseEnter += new System.EventHandler(this.tb_nama_makanan_MouseEnter);
            this.tb_nama_makanan.MouseLeave += new System.EventHandler(this.tb_nama_makanan_MouseLeave);
            // 
            // tb_harga
            // 
            this.tb_harga.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_harga.Location = new System.Drawing.Point(82, 421);
            this.tb_harga.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(314, 31);
            this.tb_harga.TabIndex = 3;
            this.tb_harga.Text = "Harga";
            this.tb_harga.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_harga_MouseClick);
            this.tb_harga.TextChanged += new System.EventHandler(this.tb_harga_TextChanged);
            this.tb_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_harga_KeyPress);
            this.tb_harga.Leave += new System.EventHandler(this.tb_harga_Leave);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(149, 513);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(180, 55);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 43);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Menu";
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "Makanan",
            "Minuman",
            "Snack"});
            this.cb_category.Location = new System.Drawing.Point(82, 458);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(314, 34);
            this.cb_category.TabIndex = 8;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pb_image
            // 
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_image.Location = new System.Drawing.Point(96, 65);
            this.pb_image.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(286, 262);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 0;
            this.pb_image.TabStop = false;
            this.pb_image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TambahMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 600);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.tb_nama_makanan);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pb_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TambahMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TambahMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tb_nama_makanan;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_category;
    }
}