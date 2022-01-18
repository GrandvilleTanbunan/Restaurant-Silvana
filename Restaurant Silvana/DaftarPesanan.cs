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
    public partial class DaftarPesanan : UserControl
    {
        public DaftarPesanan()
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
                //lbl_hargasatuan.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(value));
                lbl_subtotal.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(value));
                tmpsub = int.Parse(value);
            }

        }

        public int Jumlah
        {
            get { return _jumlah; }
            set { _jumlah = value; lbl_Jumlah.Text = value.ToString(); }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; lbl_subtotal.Text = value.ToString(); }

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
            set { _hargasub = value; lbl_subtotal.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", value); }
        }

        private void DaftarPesanan_Load(object sender, EventArgs e)
        {

        }
    }
}
