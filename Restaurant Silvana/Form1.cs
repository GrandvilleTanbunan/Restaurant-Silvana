using Restaurant_Silvana.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Silvana
{
    public partial class Main : Form
    {
        List<DaftarMakanan> namamakanan = new List<DaftarMakanan>();
        DataTable table = new DataTable("table");
        int idx = 1;
        ArrayList selecteditem = new ArrayList();
        

        public Main()
        {
            InitializeComponent();
            //UpdateBinding();
        }

        private void DynamicUserControl(int category)
        {
            flowLayoutPanel1.Controls.Clear();

            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.GetItems(category);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Makanan[] listItems = new Makanan[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new Makanan();

                            listItems[i].Category = int.Parse(row["category_makanan"].ToString());


                            //Ambil data makanan
                            if (category == 0 && listItems[i].Category == 0)
                            {
                                MemoryStream ms = new MemoryStream((byte[])row["gambar_makanan"]);
                                listItems[i].Icon = new Bitmap(ms);
                                listItems[i].Nama = row["nama_makanan"].ToString();
                                listItems[i].Harga = row["harga_makanan"].ToString();
                                listItems[i].ID = int.Parse(row["ID_makanan"].ToString());

                                flowLayoutPanel1.Controls.Add(listItems[i]);
                            }

                            //Ambil data minuman
                            if(category == 1 && listItems[i].Category == 1)
                            {
                                MemoryStream ms = new MemoryStream((byte[])row["gambar_makanan"]);
                                listItems[i].Icon = new Bitmap(ms);
                                listItems[i].Nama = row["nama_makanan"].ToString();
                                listItems[i].Harga = row["harga_makanan"].ToString();
                                listItems[i].ID = int.Parse(row["ID_makanan"].ToString());

                                flowLayoutPanel1.Controls.Add(listItems[i]);
                            }

                            //Ambil data snack
                            if (category == 2 && listItems[i].Category == 2)
                            {
                                MemoryStream ms = new MemoryStream((byte[])row["gambar_makanan"]);
                                listItems[i].Icon = new Bitmap(ms);
                                listItems[i].Nama = row["nama_makanan"].ToString();
                                listItems[i].Harga = row["harga_makanan"].ToString();
                                listItems[i].ID = int.Parse(row["ID_makanan"].ToString());

                                flowLayoutPanel1.Controls.Add(listItems[i]);
                            }

                            listItems[i].Click += new System.EventHandler(this.UserControl_click);
                            idx++;
                        }

                    }
                }
            }
 

            
        }


        void UserControl_click(object sender, EventArgs e)
        {
            bool sama = false;
            Makanan obj = (Makanan)sender;

            //Isi pesanan saat masih 0
            if (selecteditem.Count == 0)
            {

                Order listItems = new Order();

                listItems.Nama = obj.Nama;
                listItems.Harga = obj.Harga;
                listItems.ID = obj.ID;
                listItems.category = obj.Category;

                selecteditem.Add(listItems.ID);
                listBox1.Items.Add(selecteditem[0].ToString());

                pnl_pesanan.Controls.Add(listItems);
                //listItems[0].Click += new System.EventHandler(this.UserControl_click);


            }

            //isi pesanan saat lebih dari 0
            else if(selecteditem.Count > 0)
            {
                for (int i = 0; i < selecteditem.Count; i++)
                {
                    if (int.Parse(selecteditem[i].ToString()) == obj.ID)
                    {
                        sama = true;
                        
                    }
                }
                if(sama == false)
                {
                    Order listItems = new Order();

                    listItems.Nama = obj.Nama;
                    listItems.Harga = obj.Harga;
                    listItems.ID = obj.ID;
                    listItems.category = obj.Category;

                    listBox1.Items.Clear();
                    selecteditem.Add(listItems.ID);
                    for (int i = 0; i < selecteditem.Count; i++)
                    {
                        listBox1.Items.Add(selecteditem[i].ToString());

                    }

                    pnl_pesanan.Controls.Add(listItems);



                }
            }

        }

        private void UpdateBinding()
        {
            DataAccess db = new DataAccess();
            //namamakanan = db.GetDaftarMenus();


            //listBox1.DataSource = namamakanan;
            //listBox1.DisplayMember = "listdaftarmenu";

            //dataGridView1.DataSource = namamakanan;


        }

        private void BtnPesananBaru_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnPesananBaru.Height;
            SidePanel.Top = BtnPesananBaru.Top;

            DataAccess db = new DataAccess();

            gb_PesananBaru.Visible = true;
            //namamakanan = db.GetDaftarMenus();
            UpdateBinding();
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnCetak.Height;
            SidePanel.Top = BtnCetak.Top;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnMenu.Height;
            SidePanel.Top = BtnMenu.Top;

            TambahMenu tb = new TambahMenu();
            tb.Show();

            gb_PesananBaru.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load daftar menu
            DynamicUserControl(0);


            CultureInfo culture = CultureInfo.CreateSpecificCulture("id");
            DateTime.Now.ToString(culture.DateTimeFormat.LongDatePattern, culture);
            lbl_tanggal.Text = DateTime.Now.ToString(culture.DateTimeFormat.LongDatePattern, culture);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            //db.InsertMakanan(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text);
        }

        #region Ganti Category
        private void btnMakanan_Click(object sender, EventArgs e)
        {
            idx = 1;
            lbl_category.Text = "MAKANAN";
            DynamicUserControl(0);
        }

        private void btnMinuman_Click(object sender, EventArgs e)
        {
            lbl_category.Text = "MINUMAN";
            DynamicUserControl(1);
        }

        private void btn_snack_Click(object sender, EventArgs e)
        {
            lbl_category.Text = "SNACK";
            DynamicUserControl(2);
        }

        #endregion

        #region Tombol Cari Trigger
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_cari.Text == "Cari Menu")
            {
                tb_cari.Text = "";
            }

            tb_cari.ForeColor = Color.Black;
        }

        
        private void tb_cari_Leave(object sender, EventArgs e)
        {
            if (tb_cari.Text == "")
            {
                tb_cari.Text = "Cari Menu";
            }
            tb_cari.ForeColor = Color.FromArgb(172, 172, 172);

        }

        #endregion

        private void tb_cari_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lbl_tanggal_Click(object sender, EventArgs e)
        {

        }

        private void tb_cari_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
