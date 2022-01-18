using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Restaurant_Silvana
{
    public partial class Makanan : UserControl
    {
        public Makanan()
        {
            InitializeComponent();
        }

        private Image _icon;
        private string _nama;
        private string _harga;
        private int _ID;
        private int _category;


        public string @nama;
        public string @harga;

        //1 = terklik, 0 = belum terklik
        bool tercentang = false;

        [Category("Custom Props")]

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pb_icon.Image = value; }

        }

        [Category("Custom Props")]

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; lbl_nama.Text = value; }
        }

        [Category("Custom Props")]

        public string Harga
        {
            get { return _harga; }
            set { _harga = value; lbl_harga.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(value)); }

        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; lbl_nomor.Text = value.ToString(); }

        }

        public int Category
        {
            get { return _category; }
            set { _category = value; lbl_nomor.Text = value.ToString(); }
        }

        

        private void Makanan_Load(object sender, EventArgs e)
        {
            AddEvent();
            //label1.Text = enabled.ToString();
            pnl_border.Visible = tercentang;

            lbl_nama.MaximumSize = new Size(150,0);
            lbl_nama.AutoSize = true;

            lbl_harga.MaximumSize = new Size(100, 0);
            lbl_harga.AutoSize = true;
        }

        #region Hover mouse 
        private void Makanan_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(91, 4, 28);
        }

        private void Makanan_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(178, 8, 55);
        }
        private void pb_icon_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(91, 4, 28);

        }

        private void pb_icon_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(178, 8, 55);
        }

        private void lbl_nama_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(91, 4, 28);

        }

        private void lbl_nama_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(178, 8, 55);
        }

        private void lbl_harga_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(91, 4, 28);

        }

        private void lbl_harga_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(178, 8, 55);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        #region Munculkan border kuning
        public void pb_icon_Click(object sender, EventArgs e)
        {
            //if(tercentang == true)
            //{
            //    tercentang = false;

            //    pnl_border.Visible = tercentang;
               
            //}
            //else
            //{
            //    tercentang = true;
            //    pnl_border.Visible = tercentang;

            //}

        }

        private void lbl_nama_Click(object sender, EventArgs e)
        {
            //if (tercentang == true)
            //{
            //    tercentang = false;
            //    pnl_border.Visible = tercentang;

            //}
            //else
            //{
            //    tercentang = true;
            //    pnl_border.Visible = tercentang;

            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //if (tercentang == true)
            //{
            //    tercentang = false;

            //    pnl_border.Visible = tercentang;

            //}
            //else
            //{
            //    tercentang = true;
            //    pnl_border.Visible = tercentang;

            //}
        }

        #endregion

        private void AddEvent()
        {
            pb_icon.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
            lbl_harga.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
            lbl_nama.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));

        }

        private void pb_icon_MouseHover(object sender, EventArgs e)
        {
            
        }

       
    }
}
