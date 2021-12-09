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
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        private string _nama;
        private string _harga;
        private int _ID;
        private int _category;


        public string Nama
        {
            get { return _nama; }
            set { _nama = value; lbl_pesanan.Text = value; }
        }

        [Category("Custom Props")]

        public string Harga
        {
            get { return _harga; }
            //set { _harga = value; lbl_harga.Text = value; }
            set { _harga = value; lbl_hargasatuan.Text = value; }

        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; lbl_nomor.Text = value.ToString(); }

        }

        public int category
        {
            get { return _category; }
            set { _category = value; lbl_category.Text = value.ToString(); }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            AddEvent();
            numericUpDown1.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
        }
        private void DoNothing_MouseWheel(object sender, EventArgs e)
        {
            HandledMouseEventArgs ee = (HandledMouseEventArgs)e;
            ee.Handled = true;
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            
        }

        private void AddEvent()
        {
            btn_hapus.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
        }
    }
}
