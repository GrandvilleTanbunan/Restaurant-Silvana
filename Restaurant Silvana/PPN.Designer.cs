namespace Restaurant_Silvana
{
    partial class PPN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dismiss = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_err = new System.Windows.Forms.Label();
            this.tb_PPN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tetapkan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_PPN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.btn_dismiss);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 129);
            this.panel1.TabIndex = 20;
            // 
            // btn_dismiss
            // 
            this.btn_dismiss.BackColor = System.Drawing.Color.Red;
            this.btn_dismiss.FlatAppearance.BorderSize = 0;
            this.btn_dismiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dismiss.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dismiss.ForeColor = System.Drawing.Color.White;
            this.btn_dismiss.Location = new System.Drawing.Point(344, 0);
            this.btn_dismiss.Name = "btn_dismiss";
            this.btn_dismiss.Size = new System.Drawing.Size(25, 25);
            this.btn_dismiss.TabIndex = 17;
            this.btn_dismiss.Text = "X";
            this.btn_dismiss.UseVisualStyleBackColor = false;
            this.btn_dismiss.Click += new System.EventHandler(this.Btn_dismiss_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Restaurant_Silvana.Properties.Resources.Silvana;
            this.pictureBox3.Location = new System.Drawing.Point(66, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(233, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_err
            // 
            this.lbl_err.AutoSize = true;
            this.lbl_err.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err.ForeColor = System.Drawing.Color.Red;
            this.lbl_err.Location = new System.Drawing.Point(63, 266);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(48, 24);
            this.lbl_err.TabIndex = 29;
            this.lbl_err.Text = "Error";
            this.lbl_err.Visible = false;
            // 
            // tb_PPN
            // 
            this.tb_PPN.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PPN.ForeColor = System.Drawing.Color.Silver;
            this.tb_PPN.Location = new System.Drawing.Point(67, 228);
            this.tb_PPN.Name = "tb_PPN";
            this.tb_PPN.Size = new System.Drawing.Size(233, 35);
            this.tb_PPN.TabIndex = 23;
            this.tb_PPN.Text = "PPN Baru";
            this.tb_PPN.Enter += new System.EventHandler(this.Tb_PPN_Enter);
            this.tb_PPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_PPN_KeyPress);
            this.tb_PPN.Leave += new System.EventHandler(this.Tb_PPN_Leave);
            this.tb_PPN.MouseEnter += new System.EventHandler(this.tb_PPN_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tetapkan PPN baru";
            // 
            // btn_tetapkan
            // 
            this.btn_tetapkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn_tetapkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tetapkan.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tetapkan.ForeColor = System.Drawing.Color.White;
            this.btn_tetapkan.Location = new System.Drawing.Point(116, 296);
            this.btn_tetapkan.Name = "btn_tetapkan";
            this.btn_tetapkan.Size = new System.Drawing.Size(147, 43);
            this.btn_tetapkan.TabIndex = 21;
            this.btn_tetapkan.Text = "Tetapkan";
            this.btn_tetapkan.UseVisualStyleBackColor = false;
            this.btn_tetapkan.Click += new System.EventHandler(this.Btn_tetapkan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = "PPN Saat ini";
            // 
            // lbl_PPN
            // 
            this.lbl_PPN.AutoSize = true;
            this.lbl_PPN.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PPN.Location = new System.Drawing.Point(233, 132);
            this.lbl_PPN.Name = "lbl_PPN";
            this.lbl_PPN.Size = new System.Drawing.Size(67, 37);
            this.lbl_PPN.TabIndex = 31;
            this.lbl_PPN.Text = "PPN";
            // 
            // PPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 364);
            this.Controls.Add(this.lbl_PPN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_err);
            this.Controls.Add(this.tb_PPN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tetapkan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPN";
            this.Load += new System.EventHandler(this.PPN_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dismiss;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_err;
        private System.Windows.Forms.TextBox tb_PPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tetapkan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_PPN;
    }
}