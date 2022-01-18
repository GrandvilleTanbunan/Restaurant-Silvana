using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Silvana
{
    public partial class Meja_Aktif : UserControl
    {
        public Meja_Aktif()
        {
            InitializeComponent();
        }

        private string _Nomormeja;
        private int _InvoiceID;

        public string Nomormeja
        {
            get { return _Nomormeja; }
            set { _Nomormeja = value; lbl_nomormeja.Text = value; }
        }

        public int InvoiceID
        {
            get { return _InvoiceID; }
            set { _InvoiceID = value; lbl_invoiceno.Text = value.ToString(); }
        }

        #region MOUSE HOVER
        private void Meja_Aktif_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(91, 4, 28);
        }

        private void Meja_Aktif_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(178, 8, 55);
        }

        private void lbl_nomormeja_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(91, 4, 28);
        }

        private void lbl_nomormeja_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(178, 8, 55);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(91, 4, 28);

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(178, 8, 55);

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(91, 4, 28);

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(178, 8, 55);

        }

        private void Meja_Aktif_MouseHover(object sender, EventArgs e)
        {

        }

        #endregion

        private void Meja_Aktif_Load(object sender, EventArgs e)
        {
            AddEvent();

        }

        private void AddEvent()
        {
            lbl_nomormeja.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
            lbl_invoiceno.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
            label1.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
        }
    }
}
