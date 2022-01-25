namespace Restaurant_Silvana
{
    partial class Laporan
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_TahunSaja = new System.Windows.Forms.DateTimePicker();
            this.CB_Periode = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_RangkumanBerdasarkanPesanan = new System.Windows.Forms.RadioButton();
            this.RB_DetailPembelian = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_SampaiReport = new System.Windows.Forms.DateTimePicker();
            this.RB_DetailPenjualan = new System.Windows.Forms.RadioButton();
            this.RB_PenjualanPembelian = new System.Windows.Forms.RadioButton();
            this.RB_Pembelian = new System.Windows.Forms.RadioButton();
            this.RB_Penjualan = new System.Windows.Forms.RadioButton();
            this.DTP_DariReport = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(326, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(843, 669);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.Color.White;
            this.btn_Load.Location = new System.Drawing.Point(11, 323);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(272, 31);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "LOAD";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            this.label1.Visible = false;
            // 
            // DTP_TahunSaja
            // 
            this.DTP_TahunSaja.CustomFormat = "yyyy";
            this.DTP_TahunSaja.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_TahunSaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_TahunSaja.Location = new System.Drawing.Point(12, 291);
            this.DTP_TahunSaja.Name = "DTP_TahunSaja";
            this.DTP_TahunSaja.ShowUpDown = true;
            this.DTP_TahunSaja.Size = new System.Drawing.Size(79, 26);
            this.DTP_TahunSaja.TabIndex = 11;
            this.DTP_TahunSaja.Value = new System.DateTime(2022, 1, 2, 0, 0, 0, 0);
            this.DTP_TahunSaja.Visible = false;
            // 
            // CB_Periode
            // 
            this.CB_Periode.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Periode.FormattingEnabled = true;
            this.CB_Periode.Items.AddRange(new object[] {
            "Hari ini",
            "Bulan ini",
            "Tahun ini",
            "Periode Tanggal",
            "Periode Tahun"});
            this.CB_Periode.Location = new System.Drawing.Point(12, 256);
            this.CB_Periode.Name = "CB_Periode";
            this.CB_Periode.Size = new System.Drawing.Size(165, 29);
            this.CB_Periode.TabIndex = 12;
            this.CB_Periode.SelectedIndexChanged += new System.EventHandler(this.CB_Periode_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_RangkumanBerdasarkanPesanan);
            this.groupBox1.Controls.Add(this.RB_DetailPembelian);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DTP_SampaiReport);
            this.groupBox1.Controls.Add(this.RB_DetailPenjualan);
            this.groupBox1.Controls.Add(this.RB_PenjualanPembelian);
            this.groupBox1.Controls.Add(this.RB_Pembelian);
            this.groupBox1.Controls.Add(this.RB_Penjualan);
            this.groupBox1.Controls.Add(this.CB_Periode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DTP_TahunSaja);
            this.groupBox1.Controls.Add(this.btn_Load);
            this.groupBox1.Controls.Add(this.DTP_DariReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 693);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih Laporan";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // RB_RangkumanBerdasarkanPesanan
            // 
            this.RB_RangkumanBerdasarkanPesanan.AutoSize = true;
            this.RB_RangkumanBerdasarkanPesanan.Location = new System.Drawing.Point(11, 116);
            this.RB_RangkumanBerdasarkanPesanan.Name = "RB_RangkumanBerdasarkanPesanan";
            this.RB_RangkumanBerdasarkanPesanan.Size = new System.Drawing.Size(272, 25);
            this.RB_RangkumanBerdasarkanPesanan.TabIndex = 21;
            this.RB_RangkumanBerdasarkanPesanan.TabStop = true;
            this.RB_RangkumanBerdasarkanPesanan.Text = "Rangkuman Berdasarkan Pesanan";
            this.RB_RangkumanBerdasarkanPesanan.UseVisualStyleBackColor = true;
            this.RB_RangkumanBerdasarkanPesanan.CheckedChanged += new System.EventHandler(this.RB_RangkumanBerdasarkanPesanan_CheckedChanged);
            // 
            // RB_DetailPembelian
            // 
            this.RB_DetailPembelian.AutoSize = true;
            this.RB_DetailPembelian.Location = new System.Drawing.Point(11, 193);
            this.RB_DetailPembelian.Name = "RB_DetailPembelian";
            this.RB_DetailPembelian.Size = new System.Drawing.Size(147, 25);
            this.RB_DetailPembelian.TabIndex = 20;
            this.RB_DetailPembelian.TabStop = true;
            this.RB_DetailPembelian.Text = "Detail Pembelian";
            this.RB_DetailPembelian.UseVisualStyleBackColor = true;
            this.RB_DetailPembelian.CheckedChanged += new System.EventHandler(this.RB_DetailPembelian_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pilih Periode";
            // 
            // DTP_SampaiReport
            // 
            this.DTP_SampaiReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_SampaiReport.Location = new System.Drawing.Point(161, 291);
            this.DTP_SampaiReport.Name = "DTP_SampaiReport";
            this.DTP_SampaiReport.Size = new System.Drawing.Size(122, 26);
            this.DTP_SampaiReport.TabIndex = 18;
            // 
            // RB_DetailPenjualan
            // 
            this.RB_DetailPenjualan.AutoSize = true;
            this.RB_DetailPenjualan.Location = new System.Drawing.Point(11, 164);
            this.RB_DetailPenjualan.Name = "RB_DetailPenjualan";
            this.RB_DetailPenjualan.Size = new System.Drawing.Size(143, 25);
            this.RB_DetailPenjualan.TabIndex = 16;
            this.RB_DetailPenjualan.TabStop = true;
            this.RB_DetailPenjualan.Text = "Detail Penjualan";
            this.RB_DetailPenjualan.UseVisualStyleBackColor = true;
            this.RB_DetailPenjualan.CheckedChanged += new System.EventHandler(this.RB_DetailPenjualan_CheckedChanged);
            // 
            // RB_PenjualanPembelian
            // 
            this.RB_PenjualanPembelian.AutoSize = true;
            this.RB_PenjualanPembelian.Location = new System.Drawing.Point(11, 87);
            this.RB_PenjualanPembelian.Name = "RB_PenjualanPembelian";
            this.RB_PenjualanPembelian.Size = new System.Drawing.Size(299, 25);
            this.RB_PenjualanPembelian.TabIndex = 15;
            this.RB_PenjualanPembelian.TabStop = true;
            this.RB_PenjualanPembelian.Text = "Rangkuman Penjualan dan Pembelian";
            this.RB_PenjualanPembelian.UseVisualStyleBackColor = true;
            this.RB_PenjualanPembelian.CheckedChanged += new System.EventHandler(this.RB_PenjualanPembelian_CheckedChanged);
            // 
            // RB_Pembelian
            // 
            this.RB_Pembelian.AutoSize = true;
            this.RB_Pembelian.Location = new System.Drawing.Point(11, 57);
            this.RB_Pembelian.Name = "RB_Pembelian";
            this.RB_Pembelian.Size = new System.Drawing.Size(193, 25);
            this.RB_Pembelian.TabIndex = 14;
            this.RB_Pembelian.TabStop = true;
            this.RB_Pembelian.Text = "Rangkuman Pembelian";
            this.RB_Pembelian.UseVisualStyleBackColor = true;
            this.RB_Pembelian.CheckedChanged += new System.EventHandler(this.RB_Pembelian_CheckedChanged);
            // 
            // RB_Penjualan
            // 
            this.RB_Penjualan.AutoSize = true;
            this.RB_Penjualan.Location = new System.Drawing.Point(11, 26);
            this.RB_Penjualan.Name = "RB_Penjualan";
            this.RB_Penjualan.Size = new System.Drawing.Size(189, 25);
            this.RB_Penjualan.TabIndex = 13;
            this.RB_Penjualan.TabStop = true;
            this.RB_Penjualan.Text = "Rangkuman Penjualan";
            this.RB_Penjualan.UseVisualStyleBackColor = true;
            this.RB_Penjualan.CheckedChanged += new System.EventHandler(this.RB_Penjualan_CheckedChanged);
            // 
            // DTP_DariReport
            // 
            this.DTP_DariReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DariReport.Location = new System.Drawing.Point(12, 291);
            this.DTP_DariReport.Name = "DTP_DariReport";
            this.DTP_DariReport.Size = new System.Drawing.Size(122, 26);
            this.DTP_DariReport.TabIndex = 17;
            // 
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.Laporan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Periode;
        private System.Windows.Forms.DateTimePicker DTP_TahunSaja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_PenjualanPembelian;
        private System.Windows.Forms.RadioButton RB_Pembelian;
        private System.Windows.Forms.RadioButton RB_Penjualan;
        private System.Windows.Forms.RadioButton RB_DetailPenjualan;
        private System.Windows.Forms.DateTimePicker DTP_DariReport;
        private System.Windows.Forms.DateTimePicker DTP_SampaiReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RB_DetailPembelian;
        private System.Windows.Forms.RadioButton RB_RangkumanBerdasarkanPesanan;
    }
}