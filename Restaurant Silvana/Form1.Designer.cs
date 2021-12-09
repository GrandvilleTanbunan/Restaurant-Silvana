namespace Restaurant_Silvana
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.BtnCetak = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnPesananBaru = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_cari = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tanggal = new System.Windows.Forms.Label();
            this.btnMakanan = new System.Windows.Forms.Button();
            this.btnMinuman = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gb_PesananBaru = new System.Windows.Forms.GroupBox();
            this.pnl_pesanan = new System.Windows.Forms.FlowLayoutPanel();
            this.dgf_neworder = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_snack = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_PesananBaru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgf_neworder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.BtnCetak);
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.BtnPesananBaru);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 915);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 94);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(14, 63);
            this.SidePanel.TabIndex = 3;
            // 
            // BtnCetak
            // 
            this.BtnCetak.FlatAppearance.BorderSize = 0;
            this.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCetak.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCetak.ForeColor = System.Drawing.Color.White;
            this.BtnCetak.Image = ((System.Drawing.Image)(resources.GetObject("BtnCetak.Image")));
            this.BtnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCetak.Location = new System.Drawing.Point(20, 163);
            this.BtnCetak.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCetak.Name = "BtnCetak";
            this.BtnCetak.Size = new System.Drawing.Size(213, 63);
            this.BtnCetak.TabIndex = 2;
            this.BtnCetak.Text = "Cetak";
            this.BtnCetak.UseVisualStyleBackColor = true;
            this.BtnCetak.Click += new System.EventHandler(this.BtnCetak_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.Location = new System.Drawing.Point(20, 232);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(213, 63);
            this.BtnMenu.TabIndex = 1;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnPesananBaru
            // 
            this.BtnPesananBaru.FlatAppearance.BorderSize = 0;
            this.BtnPesananBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesananBaru.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesananBaru.ForeColor = System.Drawing.Color.White;
            this.BtnPesananBaru.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesananBaru.Image")));
            this.BtnPesananBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesananBaru.Location = new System.Drawing.Point(20, 94);
            this.BtnPesananBaru.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnPesananBaru.Name = "BtnPesananBaru";
            this.BtnPesananBaru.Size = new System.Drawing.Size(213, 63);
            this.BtnPesananBaru.TabIndex = 0;
            this.BtnPesananBaru.Text = "Pesanan Baru";
            this.BtnPesananBaru.UseVisualStyleBackColor = true;
            this.BtnPesananBaru.Click += new System.EventHandler(this.BtnPesananBaru_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tb_cari);
            this.panel2.Controls.Add(this.lbl_category);
            this.panel2.Location = new System.Drawing.Point(264, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 70);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Beautiful Vibes", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Silvana";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(333, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tb_cari
            // 
            this.tb_cari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_cari.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.tb_cari.Location = new System.Drawing.Point(370, 23);
            this.tb_cari.Name = "tb_cari";
            this.tb_cari.Size = new System.Drawing.Size(385, 24);
            this.tb_cari.TabIndex = 3;
            this.tb_cari.Text = "Cari Menu";
            this.tb_cari.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.tb_cari.TextChanged += new System.EventHandler(this.tb_cari_TextChanged);
            this.tb_cari.Leave += new System.EventHandler(this.tb_cari_Leave);
            this.tb_cari.MouseLeave += new System.EventHandler(this.tb_cari_MouseLeave);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.White;
            this.lbl_category.Location = new System.Drawing.Point(6, 6);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(127, 37);
            this.lbl_category.TabIndex = 0;
            this.lbl_category.Text = "MAKANAN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_tanggal);
            this.panel3.Location = new System.Drawing.Point(866, 71);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 59);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 422);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // lbl_tanggal
            // 
            this.lbl_tanggal.AutoSize = true;
            this.lbl_tanggal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tanggal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_tanggal.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tanggal.ForeColor = System.Drawing.Color.White;
            this.lbl_tanggal.Location = new System.Drawing.Point(369, 0);
            this.lbl_tanggal.Name = "lbl_tanggal";
            this.lbl_tanggal.Size = new System.Drawing.Size(82, 30);
            this.lbl_tanggal.TabIndex = 2;
            this.lbl_tanggal.Text = "Tanggal";
            this.lbl_tanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_tanggal.Click += new System.EventHandler(this.lbl_tanggal_Click);
            // 
            // btnMakanan
            // 
            this.btnMakanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnMakanan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakanan.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakanan.ForeColor = System.Drawing.Color.White;
            this.btnMakanan.Location = new System.Drawing.Point(9, 19);
            this.btnMakanan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMakanan.Name = "btnMakanan";
            this.btnMakanan.Size = new System.Drawing.Size(128, 44);
            this.btnMakanan.TabIndex = 6;
            this.btnMakanan.Text = "Makanan";
            this.btnMakanan.UseVisualStyleBackColor = false;
            this.btnMakanan.Click += new System.EventHandler(this.btnMakanan_Click);
            // 
            // btnMinuman
            // 
            this.btnMinuman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnMinuman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinuman.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinuman.ForeColor = System.Drawing.Color.White;
            this.btnMinuman.Location = new System.Drawing.Point(141, 19);
            this.btnMinuman.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMinuman.Name = "btnMinuman";
            this.btnMinuman.Size = new System.Drawing.Size(128, 44);
            this.btnMinuman.TabIndex = 7;
            this.btnMinuman.Text = "Minuman";
            this.btnMinuman.UseVisualStyleBackColor = false;
            this.btnMinuman.Click += new System.EventHandler(this.btnMinuman_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 69);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(852, 717);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // gb_PesananBaru
            // 
            this.gb_PesananBaru.Controls.Add(this.pnl_pesanan);
            this.gb_PesananBaru.Controls.Add(this.dgf_neworder);
            this.gb_PesananBaru.Controls.Add(this.panel3);
            this.gb_PesananBaru.Controls.Add(this.btn_snack);
            this.gb_PesananBaru.Controls.Add(this.flowLayoutPanel1);
            this.gb_PesananBaru.Controls.Add(this.btnMinuman);
            this.gb_PesananBaru.Controls.Add(this.btnMakanan);
            this.gb_PesananBaru.Location = new System.Drawing.Point(264, 111);
            this.gb_PesananBaru.Name = "gb_PesananBaru";
            this.gb_PesananBaru.Size = new System.Drawing.Size(1332, 798);
            this.gb_PesananBaru.TabIndex = 8;
            this.gb_PesananBaru.TabStop = false;
            // 
            // pnl_pesanan
            // 
            this.pnl_pesanan.AutoScroll = true;
            this.pnl_pesanan.Location = new System.Drawing.Point(867, 330);
            this.pnl_pesanan.Name = "pnl_pesanan";
            this.pnl_pesanan.Size = new System.Drawing.Size(459, 456);
            this.pnl_pesanan.TabIndex = 10;
            // 
            // dgf_neworder
            // 
            this.dgf_neworder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgf_neworder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgf_neworder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgf_neworder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.pesanan,
            this.jumlah,
            this.harga,
            this.total_harga});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgf_neworder.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgf_neworder.Location = new System.Drawing.Point(866, 130);
            this.dgf_neworder.Name = "dgf_neworder";
            this.dgf_neworder.RowHeadersVisible = false;
            this.dgf_neworder.Size = new System.Drawing.Size(451, 187);
            this.dgf_neworder.TabIndex = 9;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle8;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 53;
            // 
            // pesanan
            // 
            this.pesanan.HeaderText = "Pesanan";
            this.pesanan.Name = "pesanan";
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Qty";
            this.jumlah.Name = "jumlah";
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            // 
            // total_harga
            // 
            this.total_harga.HeaderText = "Total";
            this.total_harga.Name = "total_harga";
            // 
            // btn_snack
            // 
            this.btn_snack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn_snack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_snack.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_snack.ForeColor = System.Drawing.Color.White;
            this.btn_snack.Location = new System.Drawing.Point(273, 19);
            this.btn_snack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_snack.Name = "btn_snack";
            this.btn_snack.Size = new System.Drawing.Size(128, 44);
            this.btn_snack.TabIndex = 8;
            this.btn_snack.Text = "Snack";
            this.btn_snack.UseVisualStyleBackColor = false;
            this.btn_snack.Click += new System.EventHandler(this.btn_snack_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(64, 348);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1600, 915);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_PesananBaru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gb_PesananBaru.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgf_neworder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCetak;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnPesananBaru;
        private System.Windows.Forms.Panel SidePanel;
        private PesananBaru pesananBaru1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMakanan;
        private System.Windows.Forms.Button btnMinuman;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gb_PesananBaru;
        private System.Windows.Forms.Button btn_snack;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_tanggal;
        private System.Windows.Forms.TextBox tb_cari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgf_neworder;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_harga;
        private System.Windows.Forms.FlowLayoutPanel pnl_pesanan;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

