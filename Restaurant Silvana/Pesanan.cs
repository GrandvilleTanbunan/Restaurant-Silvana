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
    public partial class Pesanan : UserControl
    {
        public Pesanan()
        {
            InitializeComponent();
        }

        private string _nama;
        private string _harga;
        private int _ID;
        private int _ID_Makanan;
        private int _category;
        private int _jumlah;
        private int _hargasub;

        int tmpsub = 0;

        public bool deleteclicked = false;


        public string Nama
        {
            get { return _nama; }
            set { _nama = value; lbl_pesanan.Text = value; }
        }

        public string Harga
        {
            get { return _harga; }
            //set { _harga = value; lbl_harga.Text = value; }
            set
            {
                _harga = value;
                lbl_hargasatuan.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(value));
                lbl_subtotal.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(value));
                tmpsub = int.Parse(value);
            }

        }

        public int Jumlah
        {
            get { return _jumlah; }
            set { _jumlah = value; NumericJumlah.Value = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; label2.Text = value.ToString(); }

        }

        public int ID_Makanan
        {
            get { return _ID_Makanan; }
            set { _ID_Makanan = value; }
        }

        public int category
        {
            get { return _category; }
            set { _category = value; }
        }

        public int hargasub
        {
            get { return _hargasub; }
            set { _hargasub = value;  lbl_subtotal.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", value); }
        }
        private void Pesanan_Load_1(object sender, EventArgs e)
        {
            AddEvent();
            NumericJumlah.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
        }
        private void DoNothing_MouseWheel(object sender, EventArgs e)
        {
            HandledMouseEventArgs ee = (HandledMouseEventArgs)e;
            ee.Handled = true;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tmpsub = 0;
            tmpsub = int.Parse(Harga) * int.Parse(NumericJumlah.Value.ToString());
            _jumlah = int.Parse(NumericJumlah.Value.ToString());
            lbl_subtotal.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(tmpsub.ToString()));
        }



        private void AddEvent()
        {
            btn_hapus.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
            NumericJumlah.ValueChanged += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            deleteclicked = true;
        }
    }
}
