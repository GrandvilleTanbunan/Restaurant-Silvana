namespace Restaurant_Silvana
{
    partial class Pengeluaran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TP_Tambah = new System.Windows.Forms.TabPage();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_Tanggal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Simpan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nama_Produk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satuan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Harga_Satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_TambahSatuan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Satuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Satuan = new System.Windows.Forms.ComboBox();
            this.BTN_HapusSatuan = new System.Windows.Forms.Button();
            this.TP_History = new System.Windows.Forms.TabPage();
            this.Btn_BatalEdit = new System.Windows.Forms.Button();
            this.lbl_Peringatan2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Peringatan = new System.Windows.Forms.Label();
            this.DGV_DetailHistoryPengeluaran = new System.Windows.Forms.DataGridView();
            this.Nama_Produk_History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah_History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satuan_History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga_Satuan_History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_CariHistory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_Sampai = new System.Windows.Forms.DateTimePicker();
            this.DTP_Dari = new System.Windows.Forms.DateTimePicker();
            this.DGV_HistoryPengeluaran = new System.Windows.Forms.DataGridView();
            this.ID_Pengeluaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal_Pengeluaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grand_Total_History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.BTN_Hapus = new System.Windows.Forms.Button();
            this.Lbl_Err = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TabControl.SuspendLayout();
            this.TP_Tambah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.TP_History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DetailHistoryPengeluaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HistoryPengeluaran)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TP_Tambah);
            this.TabControl.Controls.Add(this.TP_History);
            this.TabControl.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(1, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1151, 664);
            this.TabControl.TabIndex = 13;
            // 
            // TP_Tambah
            // 
            this.TP_Tambah.Controls.Add(this.panel2);
            this.TP_Tambah.Controls.Add(this.Lbl_Total);
            this.TP_Tambah.Controls.Add(this.label2);
            this.TP_Tambah.Controls.Add(this.DTP_Tanggal);
            this.TP_Tambah.Controls.Add(this.label1);
            this.TP_Tambah.Controls.Add(this.Btn_Simpan);
            this.TP_Tambah.Controls.Add(this.dataGridView1);
            this.TP_Tambah.Controls.Add(this.panel1);
            this.TP_Tambah.Location = new System.Drawing.Point(4, 33);
            this.TP_Tambah.Name = "TP_Tambah";
            this.TP_Tambah.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Tambah.Size = new System.Drawing.Size(1143, 627);
            this.TP_Tambah.TabIndex = 0;
            this.TP_Tambah.Text = "Tambah";
            this.TP_Tambah.UseVisualStyleBackColor = true;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(913, 64);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(29, 34);
            this.Lbl_Total.TabIndex = 17;
            this.Lbl_Total.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(795, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Belanja:";
            // 
            // DTP_Tanggal
            // 
            this.DTP_Tanggal.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Tanggal.Location = new System.Drawing.Point(869, 25);
            this.DTP_Tanggal.Name = "DTP_Tanggal";
            this.DTP_Tanggal.Size = new System.Drawing.Size(187, 26);
            this.DTP_Tanggal.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(795, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tanggal";
            // 
            // Btn_Simpan
            // 
            this.Btn_Simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Btn_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Simpan.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Simpan.ForeColor = System.Drawing.Color.White;
            this.Btn_Simpan.Location = new System.Drawing.Point(864, 116);
            this.Btn_Simpan.Name = "Btn_Simpan";
            this.Btn_Simpan.Size = new System.Drawing.Size(202, 39);
            this.Btn_Simpan.TabIndex = 13;
            this.Btn_Simpan.Text = "SIMPAN";
            this.Btn_Simpan.UseVisualStyleBackColor = false;
            this.Btn_Simpan.Click += new System.EventHandler(this.Btn_Simpan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama_Produk,
            this.Jumlah,
            this.Satuan,
            this.Harga_Satuan,
            this.Total});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(777, 618);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGridView1_EditingControlShowing);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataGridView1_KeyPress);
            // 
            // Nama_Produk
            // 
            this.Nama_Produk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nama_Produk.HeaderText = "Nama Produk";
            this.Nama_Produk.Name = "Nama_Produk";
            // 
            // Jumlah
            // 
            this.Jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Width = 85;
            // 
            // Satuan
            // 
            this.Satuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Satuan.HeaderText = "Satuan";
            this.Satuan.Name = "Satuan";
            this.Satuan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Satuan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Harga_Satuan
            // 
            this.Harga_Satuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harga_Satuan.HeaderText = "Harga per Satuan";
            this.Harga_Satuan.Name = "Harga_Satuan";
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BTN_TambahSatuan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_Satuan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CB_Satuan);
            this.panel1.Controls.Add(this.BTN_HapusSatuan);
            this.panel1.Location = new System.Drawing.Point(784, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 195);
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Pengaturan Satuan";
            // 
            // BTN_TambahSatuan
            // 
            this.BTN_TambahSatuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BTN_TambahSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TambahSatuan.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_TambahSatuan.ForeColor = System.Drawing.Color.White;
            this.BTN_TambahSatuan.Location = new System.Drawing.Point(221, 152);
            this.BTN_TambahSatuan.Name = "BTN_TambahSatuan";
            this.BTN_TambahSatuan.Size = new System.Drawing.Size(119, 27);
            this.BTN_TambahSatuan.TabIndex = 23;
            this.BTN_TambahSatuan.Text = "TAMBAH";
            this.BTN_TambahSatuan.UseVisualStyleBackColor = false;
            this.BTN_TambahSatuan.Click += new System.EventHandler(this.BTN_TambahSatuan_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Hapus Satuan";
            // 
            // TB_Satuan
            // 
            this.TB_Satuan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TB_Satuan.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Satuan.Location = new System.Drawing.Point(12, 152);
            this.TB_Satuan.Name = "TB_Satuan";
            this.TB_Satuan.Size = new System.Drawing.Size(196, 26);
            this.TB_Satuan.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tambah Satuan";
            // 
            // CB_Satuan
            // 
            this.CB_Satuan.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Satuan.FormattingEnabled = true;
            this.CB_Satuan.Location = new System.Drawing.Point(12, 75);
            this.CB_Satuan.Name = "CB_Satuan";
            this.CB_Satuan.Size = new System.Drawing.Size(196, 29);
            this.CB_Satuan.TabIndex = 19;
            // 
            // BTN_HapusSatuan
            // 
            this.BTN_HapusSatuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BTN_HapusSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HapusSatuan.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_HapusSatuan.ForeColor = System.Drawing.Color.White;
            this.BTN_HapusSatuan.Location = new System.Drawing.Point(221, 77);
            this.BTN_HapusSatuan.Name = "BTN_HapusSatuan";
            this.BTN_HapusSatuan.Size = new System.Drawing.Size(119, 27);
            this.BTN_HapusSatuan.TabIndex = 21;
            this.BTN_HapusSatuan.Text = "HAPUS";
            this.BTN_HapusSatuan.UseVisualStyleBackColor = false;
            this.BTN_HapusSatuan.Click += new System.EventHandler(this.BTN_HapusSatuan_Click_1);
            // 
            // TP_History
            // 
            this.TP_History.Controls.Add(this.Btn_BatalEdit);
            this.TP_History.Controls.Add(this.lbl_Peringatan2);
            this.TP_History.Controls.Add(this.label8);
            this.TP_History.Controls.Add(this.label7);
            this.TP_History.Controls.Add(this.lbl_Peringatan);
            this.TP_History.Controls.Add(this.DGV_DetailHistoryPengeluaran);
            this.TP_History.Controls.Add(this.Btn_CariHistory);
            this.TP_History.Controls.Add(this.label6);
            this.TP_History.Controls.Add(this.DTP_Sampai);
            this.TP_History.Controls.Add(this.DTP_Dari);
            this.TP_History.Controls.Add(this.DGV_HistoryPengeluaran);
            this.TP_History.Controls.Add(this.Btn_Edit);
            this.TP_History.Controls.Add(this.BTN_Hapus);
            this.TP_History.Location = new System.Drawing.Point(4, 33);
            this.TP_History.Name = "TP_History";
            this.TP_History.Padding = new System.Windows.Forms.Padding(3);
            this.TP_History.Size = new System.Drawing.Size(1143, 627);
            this.TP_History.TabIndex = 1;
            this.TP_History.Text = "History";
            this.TP_History.UseVisualStyleBackColor = true;
            // 
            // Btn_BatalEdit
            // 
            this.Btn_BatalEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Btn_BatalEdit.FlatAppearance.BorderSize = 0;
            this.Btn_BatalEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BatalEdit.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BatalEdit.ForeColor = System.Drawing.Color.White;
            this.Btn_BatalEdit.Image = global::Restaurant_Silvana.Properties.Resources.cancel;
            this.Btn_BatalEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BatalEdit.Location = new System.Drawing.Point(253, 583);
            this.Btn_BatalEdit.Name = "Btn_BatalEdit";
            this.Btn_BatalEdit.Size = new System.Drawing.Size(160, 31);
            this.Btn_BatalEdit.TabIndex = 28;
            this.Btn_BatalEdit.Text = "   BATAL EDIT";
            this.Btn_BatalEdit.UseVisualStyleBackColor = false;
            this.Btn_BatalEdit.Click += new System.EventHandler(this.Btn_BatalEdit_Click_1);
            // 
            // lbl_Peringatan2
            // 
            this.lbl_Peringatan2.AutoSize = true;
            this.lbl_Peringatan2.BackColor = System.Drawing.Color.Yellow;
            this.lbl_Peringatan2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Peringatan2.Location = new System.Drawing.Point(251, 602);
            this.lbl_Peringatan2.Name = "lbl_Peringatan2";
            this.lbl_Peringatan2.Size = new System.Drawing.Size(0, 24);
            this.lbl_Peringatan2.TabIndex = 27;
            this.lbl_Peringatan2.UseCompatibleTextRendering = true;
            this.lbl_Peringatan2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(727, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "DETAIL PEMBELIAN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "DAFTAR PEMBELIAN";
            // 
            // lbl_Peringatan
            // 
            this.lbl_Peringatan.AutoSize = true;
            this.lbl_Peringatan.BackColor = System.Drawing.Color.Yellow;
            this.lbl_Peringatan.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Peringatan.Location = new System.Drawing.Point(419, 588);
            this.lbl_Peringatan.Name = "lbl_Peringatan";
            this.lbl_Peringatan.Size = new System.Drawing.Size(542, 24);
            this.lbl_Peringatan.TabIndex = 24;
            this.lbl_Peringatan.Text = "Tekan tombol EDIT setelah selesai mengedit pada tabel DETAIL PEMBELIAN";
            this.lbl_Peringatan.UseCompatibleTextRendering = true;
            this.lbl_Peringatan.Visible = false;
            // 
            // DGV_DetailHistoryPengeluaran
            // 
            this.DGV_DetailHistoryPengeluaran.AllowUserToAddRows = false;
            this.DGV_DetailHistoryPengeluaran.AllowUserToResizeColumns = false;
            this.DGV_DetailHistoryPengeluaran.AllowUserToResizeRows = false;
            this.DGV_DetailHistoryPengeluaran.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_DetailHistoryPengeluaran.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_DetailHistoryPengeluaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DGV_DetailHistoryPengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DetailHistoryPengeluaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama_Produk_History,
            this.Jumlah_History,
            this.Satuan_History,
            this.Harga_Satuan_History,
            this.Total_History});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_DetailHistoryPengeluaran.DefaultCellStyle = dataGridViewCellStyle23;
            this.DGV_DetailHistoryPengeluaran.EnableHeadersVisualStyles = false;
            this.DGV_DetailHistoryPengeluaran.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_DetailHistoryPengeluaran.Location = new System.Drawing.Point(469, 66);
            this.DGV_DetailHistoryPengeluaran.MultiSelect = false;
            this.DGV_DetailHistoryPengeluaran.Name = "DGV_DetailHistoryPengeluaran";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_DetailHistoryPengeluaran.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.DGV_DetailHistoryPengeluaran.RowHeadersVisible = false;
            this.DGV_DetailHistoryPengeluaran.Size = new System.Drawing.Size(668, 508);
            this.DGV_DetailHistoryPengeluaran.TabIndex = 21;
            this.DGV_DetailHistoryPengeluaran.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DetailHistoryPengeluaran_CellContentClick);
            this.DGV_DetailHistoryPengeluaran.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DetailHistoryPengeluaran_CellEndEdit);
            // 
            // Nama_Produk_History
            // 
            this.Nama_Produk_History.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nama_Produk_History.DataPropertyName = "Nama_Produk";
            this.Nama_Produk_History.HeaderText = "Nama Produk";
            this.Nama_Produk_History.Name = "Nama_Produk_History";
            // 
            // Jumlah_History
            // 
            this.Jumlah_History.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Jumlah_History.DataPropertyName = "Jumlah";
            this.Jumlah_History.HeaderText = "Jumlah";
            this.Jumlah_History.Name = "Jumlah_History";
            this.Jumlah_History.Width = 85;
            // 
            // Satuan_History
            // 
            this.Satuan_History.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Satuan_History.DataPropertyName = "Satuan";
            this.Satuan_History.HeaderText = "Satuan";
            this.Satuan_History.Name = "Satuan_History";
            this.Satuan_History.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Harga_Satuan_History
            // 
            this.Harga_Satuan_History.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Harga_Satuan_History.DataPropertyName = "Harga_Per_Satuan";
            this.Harga_Satuan_History.HeaderText = "Harga per Satuan";
            this.Harga_Satuan_History.Name = "Harga_Satuan_History";
            this.Harga_Satuan_History.Width = 162;
            // 
            // Total_History
            // 
            this.Total_History.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_History.DataPropertyName = "Sub_Total_Pengeluaran";
            this.Total_History.HeaderText = "Total";
            this.Total_History.Name = "Total_History";
            this.Total_History.ReadOnly = true;
            // 
            // Btn_CariHistory
            // 
            this.Btn_CariHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Btn_CariHistory.FlatAppearance.BorderSize = 0;
            this.Btn_CariHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CariHistory.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CariHistory.ForeColor = System.Drawing.Color.White;
            this.Btn_CariHistory.Location = new System.Drawing.Point(343, 3);
            this.Btn_CariHistory.Name = "Btn_CariHistory";
            this.Btn_CariHistory.Size = new System.Drawing.Size(120, 31);
            this.Btn_CariHistory.TabIndex = 20;
            this.Btn_CariHistory.Text = "Cari";
            this.Btn_CariHistory.UseVisualStyleBackColor = false;
            this.Btn_CariHistory.Click += new System.EventHandler(this.Btn_CariHistory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "-";
            // 
            // DTP_Sampai
            // 
            this.DTP_Sampai.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Sampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Sampai.Location = new System.Drawing.Point(185, 6);
            this.DTP_Sampai.Name = "DTP_Sampai";
            this.DTP_Sampai.Size = new System.Drawing.Size(152, 26);
            this.DTP_Sampai.TabIndex = 18;
            // 
            // DTP_Dari
            // 
            this.DTP_Dari.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Dari.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Dari.Location = new System.Drawing.Point(6, 6);
            this.DTP_Dari.Name = "DTP_Dari";
            this.DTP_Dari.Size = new System.Drawing.Size(152, 26);
            this.DTP_Dari.TabIndex = 16;
            // 
            // DGV_HistoryPengeluaran
            // 
            this.DGV_HistoryPengeluaran.AllowUserToAddRows = false;
            this.DGV_HistoryPengeluaran.AllowUserToResizeColumns = false;
            this.DGV_HistoryPengeluaran.AllowUserToResizeRows = false;
            this.DGV_HistoryPengeluaran.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_HistoryPengeluaran.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_HistoryPengeluaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.DGV_HistoryPengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_HistoryPengeluaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Pengeluaran,
            this.Tanggal_Pengeluaran,
            this.Grand_Total_History});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_HistoryPengeluaran.DefaultCellStyle = dataGridViewCellStyle26;
            this.DGV_HistoryPengeluaran.EnableHeadersVisualStyles = false;
            this.DGV_HistoryPengeluaran.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_HistoryPengeluaran.Location = new System.Drawing.Point(3, 66);
            this.DGV_HistoryPengeluaran.MultiSelect = false;
            this.DGV_HistoryPengeluaran.Name = "DGV_HistoryPengeluaran";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_HistoryPengeluaran.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.DGV_HistoryPengeluaran.RowHeadersVisible = false;
            this.DGV_HistoryPengeluaran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_HistoryPengeluaran.Size = new System.Drawing.Size(460, 508);
            this.DGV_HistoryPengeluaran.TabIndex = 2;
            this.DGV_HistoryPengeluaran.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_HistoryPengeluaran_CellClick);
            this.DGV_HistoryPengeluaran.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_HistoryPengeluaran_CellEnter);
            this.DGV_HistoryPengeluaran.SelectionChanged += new System.EventHandler(this.DGV_HistoryPengeluaran_SelectionChanged);
            // 
            // ID_Pengeluaran
            // 
            this.ID_Pengeluaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Pengeluaran.DataPropertyName = "ID_Pengeluaran";
            this.ID_Pengeluaran.HeaderText = "ID";
            this.ID_Pengeluaran.Name = "ID_Pengeluaran";
            this.ID_Pengeluaran.ReadOnly = true;
            this.ID_Pengeluaran.Width = 50;
            // 
            // Tanggal_Pengeluaran
            // 
            this.Tanggal_Pengeluaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tanggal_Pengeluaran.DataPropertyName = "Tanggal_Pengeluaran";
            this.Tanggal_Pengeluaran.HeaderText = "Tanggal";
            this.Tanggal_Pengeluaran.Name = "Tanggal_Pengeluaran";
            // 
            // Grand_Total_History
            // 
            this.Grand_Total_History.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grand_Total_History.DataPropertyName = "Grand_Total_Pengeluaran";
            this.Grand_Total_History.HeaderText = "Grand Total";
            this.Grand_Total_History.Name = "Grand_Total_History";
            this.Grand_Total_History.ReadOnly = true;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Btn_Edit.FlatAppearance.BorderSize = 0;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.ForeColor = System.Drawing.Color.White;
            this.Btn_Edit.Image = global::Restaurant_Silvana.Properties.Resources.update;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Edit.Location = new System.Drawing.Point(127, 583);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(118, 31);
            this.Btn_Edit.TabIndex = 23;
            this.Btn_Edit.Text = " EDIT";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click_1);
            // 
            // BTN_Hapus
            // 
            this.BTN_Hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BTN_Hapus.FlatAppearance.BorderSize = 0;
            this.BTN_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Hapus.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Hapus.ForeColor = System.Drawing.Color.White;
            this.BTN_Hapus.Image = global::Restaurant_Silvana.Properties.Resources.hapus;
            this.BTN_Hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Hapus.Location = new System.Drawing.Point(3, 583);
            this.BTN_Hapus.Name = "BTN_Hapus";
            this.BTN_Hapus.Size = new System.Drawing.Size(118, 31);
            this.BTN_Hapus.TabIndex = 22;
            this.BTN_Hapus.Text = "  HAPUS";
            this.BTN_Hapus.UseVisualStyleBackColor = false;
            this.BTN_Hapus.Click += new System.EventHandler(this.BTN_Hapus_Click);
            // 
            // Lbl_Err
            // 
            this.Lbl_Err.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Err.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Err.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Err.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Err.Name = "Lbl_Err";
            this.Lbl_Err.Size = new System.Drawing.Size(271, 181);
            this.Lbl_Err.TabIndex = 25;
            this.Lbl_Err.Text = "Lengkapi data!";
            this.Lbl_Err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Err.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lbl_Err);
            this.panel2.Location = new System.Drawing.Point(814, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 181);
            this.panel2.TabIndex = 26;
            // 
            // Pengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 678);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pengeluaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pengeluaran";
            this.Load += new System.EventHandler(this.Pengeluaran_Load);
            this.TabControl.ResumeLayout(false);
            this.TP_Tambah.ResumeLayout(false);
            this.TP_Tambah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TP_History.ResumeLayout(false);
            this.TP_History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DetailHistoryPengeluaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HistoryPengeluaran)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TP_Tambah;
        private System.Windows.Forms.Button BTN_TambahSatuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_HapusSatuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Satuan;
        private System.Windows.Forms.TextBox TB_Satuan;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_Tanggal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Simpan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage TP_History;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Produk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewComboBoxColumn Satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga_Satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTP_Sampai;
        private System.Windows.Forms.DateTimePicker DTP_Dari;
        private System.Windows.Forms.DataGridView DGV_HistoryPengeluaran;
        private System.Windows.Forms.Button Btn_CariHistory;
        private System.Windows.Forms.DataGridView DGV_DetailHistoryPengeluaran;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Hapus;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Produk_History;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah_History;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satuan_History;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga_Satuan_History;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_History;
        private System.Windows.Forms.Label lbl_Peringatan;
        private System.Windows.Forms.Label lbl_Peringatan2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_BatalEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pengeluaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal_Pengeluaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grand_Total_History;
        private System.Windows.Forms.Label Lbl_Err;
        private System.Windows.Forms.Panel panel2;
    }
}