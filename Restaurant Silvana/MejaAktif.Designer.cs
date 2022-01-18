namespace Restaurant_Silvana
{
    partial class Meja_Aktif
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
            this.lbl_nomormeja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_invoiceno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nomormeja
            // 
            this.lbl_nomormeja.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomormeja.ForeColor = System.Drawing.Color.White;
            this.lbl_nomormeja.Location = new System.Drawing.Point(12, 0);
            this.lbl_nomormeja.Name = "lbl_nomormeja";
            this.lbl_nomormeja.Size = new System.Drawing.Size(103, 36);
            this.lbl_nomormeja.TabIndex = 0;
            this.lbl_nomormeja.Text = "label1";
            this.lbl_nomormeja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nomormeja.MouseEnter += new System.EventHandler(this.lbl_nomormeja_MouseEnter);
            this.lbl_nomormeja.MouseLeave += new System.EventHandler(this.lbl_nomormeja_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Invoice:";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lbl_invoiceno
            // 
            this.lbl_invoiceno.AutoSize = true;
            this.lbl_invoiceno.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceno.ForeColor = System.Drawing.Color.White;
            this.lbl_invoiceno.Location = new System.Drawing.Point(67, 39);
            this.lbl_invoiceno.Name = "lbl_invoiceno";
            this.lbl_invoiceno.Size = new System.Drawing.Size(23, 17);
            this.lbl_invoiceno.TabIndex = 2;
            this.lbl_invoiceno.Text = "No";
            this.lbl_invoiceno.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.lbl_invoiceno.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // Meja_Aktif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.lbl_invoiceno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_nomormeja);
            this.Name = "Meja_Aktif";
            this.Size = new System.Drawing.Size(127, 59);
            this.Load += new System.EventHandler(this.Meja_Aktif_Load);
            this.MouseEnter += new System.EventHandler(this.Meja_Aktif_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Meja_Aktif_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Meja_Aktif_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomormeja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_invoiceno;
    }
}
