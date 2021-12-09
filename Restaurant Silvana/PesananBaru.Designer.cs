namespace Restaurant_Silvana
{
    partial class PesananBaru
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
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabMakanan = new System.Windows.Forms.TabPage();
            this.tabMinuman = new System.Windows.Forms.TabPage();
            this.dgfMinuman = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabView.SuspendLayout();
            this.tabMakanan.SuspendLayout();
            this.tabMinuman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfMinuman)).BeginInit();
            this.SuspendLayout();
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabMakanan);
            this.tabView.Controls.Add(this.tabMinuman);
            this.tabView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabView.Location = new System.Drawing.Point(44, 14);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(801, 664);
            this.tabView.TabIndex = 0;
            // 
            // tabMakanan
            // 
            this.tabMakanan.Controls.Add(this.flowLayoutPanel1);
            this.tabMakanan.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMakanan.Location = new System.Drawing.Point(4, 38);
            this.tabMakanan.Name = "tabMakanan";
            this.tabMakanan.Padding = new System.Windows.Forms.Padding(3);
            this.tabMakanan.Size = new System.Drawing.Size(793, 622);
            this.tabMakanan.TabIndex = 0;
            this.tabMakanan.Text = "Makanan";
            this.tabMakanan.UseVisualStyleBackColor = true;
            // 
            // tabMinuman
            // 
            this.tabMinuman.Controls.Add(this.dgfMinuman);
            this.tabMinuman.Location = new System.Drawing.Point(4, 38);
            this.tabMinuman.Name = "tabMinuman";
            this.tabMinuman.Padding = new System.Windows.Forms.Padding(3);
            this.tabMinuman.Size = new System.Drawing.Size(316, 362);
            this.tabMinuman.TabIndex = 1;
            this.tabMinuman.Text = "Minuman";
            this.tabMinuman.UseVisualStyleBackColor = true;
            // 
            // dgfMinuman
            // 
            this.dgfMinuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfMinuman.Location = new System.Drawing.Point(0, 0);
            this.dgfMinuman.Name = "dgfMinuman";
            this.dgfMinuman.Size = new System.Drawing.Size(304, 350);
            this.dgfMinuman.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(79, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 396);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // PesananBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tabView);
            this.Name = "PesananBaru";
            this.Size = new System.Drawing.Size(1145, 773);
            this.Load += new System.EventHandler(this.PesananBaru_Load);
            this.Enter += new System.EventHandler(this.PesananBaru_Enter);
            this.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.PesananBaru_ChangeUICues);
            this.StyleChanged += new System.EventHandler(this.PesananBaru_StyleChanged);
            this.tabView.ResumeLayout(false);
            this.tabMakanan.ResumeLayout(false);
            this.tabMinuman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgfMinuman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabMakanan;
        private System.Windows.Forms.TabPage tabMinuman;
        private System.Windows.Forms.DataGridView dgfMinuman;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
