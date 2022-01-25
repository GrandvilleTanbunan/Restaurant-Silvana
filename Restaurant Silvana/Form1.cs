using Microsoft.Reporting.WinForms;
using Restaurant_Silvana.BLL;
using Restaurant_Silvana.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Silvana
{
    public partial class Main : Form
    {
        List<DaftarMakanan> namamakanan = new List<DaftarMakanan>();
        DataTable table = new DataTable("table");
        int idx = 1;
        ArrayList ID_selecteditem = new ArrayList();
        ArrayList tmp_namamakanan = new ArrayList();
        ArrayList tmp_hargayangdipesan = new ArrayList();
        ArrayList tmp_TOTALhargayangdipesan = new ArrayList();
        ArrayList tmp_jumlah = new ArrayList();
        ArrayList tmp_MejaAktif = new ArrayList();
        ArrayList tmp_ID_Makanan = new ArrayList();
        ArrayList tmp_ID_Dtrans = new ArrayList();
        ArrayList tmp_Nama_Makanan = new ArrayList();

        ArrayList ID_Dtrans_MejaAktif = new ArrayList();
        ArrayList ID_selecteditem_MejaAktif = new ArrayList();
        ArrayList tmp_namamakanan_MejaAktif = new ArrayList();
        ArrayList tmp_hargayangdipesan_MejaAktif = new ArrayList();
        ArrayList tmp_jumlah_MejaAktif = new ArrayList();
        ArrayList tmp_TOTALhargayangdipesan_MejaAktif = new ArrayList();

        int tmp_grandtotal_Htrans;
        int tmp_grandtotal_Htrans_SUDAHPPN;
        int tmp_grandtotal_Htrans_SUDAHPPN_BUNGKUS;
        int tmp_Quantity;
        int totalhargabaru;
        int tmp_ID_Dtrans_Pernahdipesan;
        string tmp_Nama_Makanan_Pernahdipesan;
        string tmp_KasirMejaAktif;
        string tmp_TanggalMejaAktif;
        int tmp_NomorMejaAktif;
        bool pernahdipesan = true;

        int totalquantitybaru;
        int PPN;
        int kembalian;
        int kembalianBungkus;
        int tmp_grandtotal;
        int tbbayar;
        int tbbayarBungkus;

        int tmp_LastInvoiceID;
        int tmp_InvoiceIDMejaAktif;

        bool apakahmejaaktif = false;

        string tanggal;
        string loggeduser;

        int grandtotal = 0;
        bool sisasatu = false;
        bool sisasatu_MejaAktif = false;
        int tmpmakanbungkus;
        int tmpIDUpdate;

        System.Windows.Forms.Timer t = null;

        int ctrprintdapurdanmeja = 1;
        bool nomormejaclick = false;

        int pilihReport;
        string tanggalReport;
        DateTime tmp_dariReport;
        string dari;
        DateTime tmp_sampaiReport;
        string sampai;
        string tahun;
        string bulan;

        int pesananataumenu = 0;

        public Main()
        {
            InitializeComponent();
            //UpdateBinding();
        }

        public void DynamicUserControl(int category)
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

        public void DynamicUserControlMenu(int category)
        {
            flyoutpanel_menu.Controls.Clear();

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

                                flyoutpanel_menu.Controls.Add(listItems[i]);
                            }

                            //Ambil data minuman
                            if (category == 1 && listItems[i].Category == 1)
                            {
                                MemoryStream ms = new MemoryStream((byte[])row["gambar_makanan"]);
                                listItems[i].Icon = new Bitmap(ms);
                                listItems[i].Nama = row["nama_makanan"].ToString();
                                listItems[i].Harga = row["harga_makanan"].ToString();
                                listItems[i].ID = int.Parse(row["ID_makanan"].ToString());

                                flyoutpanel_menu.Controls.Add(listItems[i]);
                            }

                            //Ambil data snack
                            if (category == 2 && listItems[i].Category == 2)
                            {
                                MemoryStream ms = new MemoryStream((byte[])row["gambar_makanan"]);
                                listItems[i].Icon = new Bitmap(ms);
                                listItems[i].Nama = row["nama_makanan"].ToString();
                                listItems[i].Harga = row["harga_makanan"].ToString();
                                listItems[i].ID = int.Parse(row["ID_makanan"].ToString());

                                flyoutpanel_menu.Controls.Add(listItems[i]);
                            }

                            listItems[i].Click += new System.EventHandler(this.UserControlMenu_click);
                            idx++;
                        }

                    }
                }
            }



        }


        //ini ambil semua meja yg aktif
        private void MejaAktif()
        {
            flowLayoutMejaAktif.Controls.Clear();

            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.GetMejaAktif();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Meja_Aktif[] ListMejaAktif = new Meja_Aktif[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ListMejaAktif[i] = new Meja_Aktif();
                            ListMejaAktif[i].Nomormeja = row["Nomor_Meja"].ToString();
                            ListMejaAktif[i].InvoiceID = int.Parse(row["InvoiceID"].ToString());

                            flowLayoutMejaAktif.Controls.Add(ListMejaAktif[i]);
                            ListMejaAktif[i].Click += new System.EventHandler(this.Nomor_Meja_click);

                        }

                    }
                }
            }



        }

        //ini klik meja yang sedang aktif
        void Nomor_Meja_click(object sender, EventArgs e)
        {
            lbl_Peringatan.Visible = false;
            flowLayoutDaftarPesanan.Controls.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            tb_Bayar.Clear();
            lbl_Kembalian.Text = "0";

            ID_Dtrans_MejaAktif.Clear();
            ID_selecteditem_MejaAktif.Clear();
            tmp_namamakanan_MejaAktif.Clear();
            tmp_hargayangdipesan_MejaAktif.Clear();
            tmp_jumlah_MejaAktif.Clear();
            tmp_TOTALhargayangdipesan_MejaAktif.Clear();


            Meja_Aktif obj = (Meja_Aktif)sender;

            //Pesanan DaftarPesanan = new Pesanan();
            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.GetDtrans(obj.InvoiceID);
            lbl_NomormejaAktif.Text = obj.Nomormeja.ToString();
            tmp_NomorMejaAktif = int.Parse(obj.Nomormeja.ToString());
            lbl_invoiceIDAktif.Text = obj.InvoiceID.ToString();
            tmp_InvoiceIDMejaAktif = obj.InvoiceID;

            nomormejaclick = true;
            //hitunggrandtotalMejaAktif();
            getGrandTotalHTrans(obj.InvoiceID);


            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Pesanan[] ListPesananDetail = new Pesanan[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ListPesananDetail[i] = new Pesanan();
                            ListPesananDetail[i].ID = int.Parse(row["ID_Dtrans"].ToString());
                            ListPesananDetail[i].ID_Makanan = int.Parse(row["ID_Makanan"].ToString());
                            ListPesananDetail[i].Nama = row["nama_makanan"].ToString();
                            ListPesananDetail[i].Harga = row["harga_makanan"].ToString();
                            ListPesananDetail[i].hargasub = int.Parse(row["Total_Amount"].ToString());
                            ListPesananDetail[i].Jumlah = int.Parse(row["Quantity"].ToString());


                            flowLayoutDaftarPesanan.Controls.Add(ListPesananDetail[i]);
                            //ListPesananDetail[i].Click += new System.EventHandler(this.Nomor_Meja_click);

                            ID_Dtrans_MejaAktif.Add(ListPesananDetail[i].ID);
                            ID_selecteditem_MejaAktif.Add(int.Parse(row["ID_Makanan"].ToString()));
                            tmp_namamakanan_MejaAktif.Add(row["nama_makanan"].ToString());
                            tmp_hargayangdipesan_MejaAktif.Add(row["harga_makanan"].ToString());
                            tmp_jumlah_MejaAktif.Add(int.Parse(row["Quantity"].ToString()));
                            tmp_TOTALhargayangdipesan_MejaAktif.Add(row["Total_Amount"].ToString());

                            ListPesananDetail[i].Click += new System.EventHandler(this.Pesanan_MejaAktif_Click);

                        }

                    }


                }
            }



            for (int i = 0; i < ID_selecteditem_MejaAktif.Count; i++)
            {
                listBox1.Items.Add(ID_selecteditem_MejaAktif[i].ToString());
                listBox2.Items.Add(tmp_hargayangdipesan_MejaAktif[i].ToString());
                listBox3.Items.Add(tmp_jumlah_MejaAktif[i].ToString());
                listBox4.Items.Add(tmp_TOTALhargayangdipesan_MejaAktif[i].ToString());
            }

            

        }


        //Ini pilih makanan yang mau dipesan
        void UserControl_click(object sender, EventArgs e)
        {
            bool sama = false;
            Makanan obj = (Makanan)sender;
            
            for (int i = 0; i < ID_selecteditem.Count; i++)
            {
                if (int.Parse(ID_selecteditem[i].ToString()) == obj.ID)
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
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();

                ID_selecteditem.Add(listItems.ID);
                tmp_namamakanan.Add(listItems.Nama);
                tmp_hargayangdipesan.Add(listItems.Harga);
                tmp_jumlah.Add(1);
                tmp_TOTALhargayangdipesan.Add(listItems.Harga);

                for (int i = 0; i < ID_selecteditem.Count; i++)
                {
                    listBox1.Items.Add(ID_selecteditem[i].ToString());
                    listBox2.Items.Add(tmp_hargayangdipesan[i].ToString());
                    listBox3.Items.Add(tmp_jumlah[i].ToString());
                    listBox4.Items.Add(tmp_TOTALhargayangdipesan[i].ToString());

                }

                listItems.Click += new System.EventHandler(this.Pesanan_Click);
                
                //label4.Text = listItems.numericUpDown1.Value.ToString();

                pnl_pesanan.Controls.Add(listItems);
            }

            hitunggrandtotal();
            hitungkembalianBUNGKUS();
        }

        //ini edit" pesanan yg belum dimasukan ke meja aktif
        void Pesanan_Click(object sender, EventArgs e)
        {
            sisasatu = false;
            Order pesanan = (Order)sender;
            label1.Text = pesanan.Nama;
            label5.Text = pesanan.ID.ToString();
            label4.Text = pesanan.Jumlah.ToString();

            if(pesanan.deleteclicked == true) //HAPUS ITEM BELANJAAN
            {
                pnl_pesanan.Controls.Remove(pesanan);

                if (ID_selecteditem.Count == 1)
                {
                    sisasatu = true;
                }

                for (int i = 0; i < ID_selecteditem.Count; i++)
                {
                    if (ID_selecteditem[i].ToString() == pesanan.ID.ToString())
                    {
                        ID_selecteditem.RemoveAt(i);
                        tmp_hargayangdipesan.RemoveAt(i);
                        tmp_jumlah.RemoveAt(i);
                        tmp_TOTALhargayangdipesan.RemoveAt(i);
                        tmp_namamakanan.RemoveAt(i);
                    }
                }

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();

                for (int i = 0; i < ID_selecteditem.Count; i++)
                {
                    listBox1.Items.Add(ID_selecteditem[i].ToString());
                    listBox2.Items.Add(tmp_hargayangdipesan[i].ToString());
                    listBox3.Items.Add(tmp_jumlah[i].ToString());
                    listBox4.Items.Add(tmp_TOTALhargayangdipesan[i].ToString());
                }
            }
            else //UBAH JUMLAH ITEM
            {
                for (int i = 0; i < ID_selecteditem.Count; i++)
                {
                    if(ID_selecteditem[i].ToString() == pesanan.ID.ToString())
                    {
                        tmp_jumlah[i] = pesanan.Jumlah;
                        hitungsubtotalperitem(i);

                    }
                }


                listBox3.Items.Clear();
                for (int i = 0; i < ID_selecteditem.Count; i++)
                {
                    listBox3.Items.Add(tmp_jumlah[i].ToString());

                }
            }

            hitunggrandtotal();
            hitungkembalianBUNGKUS();
        }


        // ini edit" pesanan yg sudah dimasukan ke meja aktif
        void Pesanan_MejaAktif_Click(object sender, EventArgs e)
        {
            sisasatu_MejaAktif = false;
            Pesanan pesanan = (Pesanan)sender;
            //label1.Text = pesanan.Nama;
            //label5.Text = pesanan.ID.ToString();
            //label4.Text = pesanan.Jumlah.ToString();

            if (pesanan.deleteclicked == true) //HAPUS ITEM BELANJAAN
            {
                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan menghapus " + pesanan.Nama + "?", "KONFIRMASI", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    flowLayoutDaftarPesanan.Controls.Remove(pesanan);

                    if (ID_selecteditem_MejaAktif.Count == 1)
                    {
                        sisasatu_MejaAktif = true;
                    }

                    for (int i = 0; i < ID_selecteditem_MejaAktif.Count; i++)
                    {
                        if (ID_selecteditem_MejaAktif[i].ToString() == pesanan.ID_Makanan.ToString())
                        {
                            
                            HapusPesananMejaAktif(int.Parse(ID_Dtrans_MejaAktif[i].ToString()));
                            label1.Text = tmp_InvoiceIDMejaAktif + " " + tmp_grandtotal_Htrans.ToString();
                            label5.Text = "ID Dtrans " + ID_Dtrans_MejaAktif[i].ToString();
                            

                            ID_Dtrans_MejaAktif.RemoveAt(i);
                            ID_selecteditem_MejaAktif.RemoveAt(i);
                            tmp_hargayangdipesan_MejaAktif.RemoveAt(i);
                            tmp_jumlah_MejaAktif.RemoveAt(i);
                            tmp_TOTALhargayangdipesan_MejaAktif.RemoveAt(i);
                            tmp_namamakanan_MejaAktif.RemoveAt(i);

                            hitunggrandtotalMejaAktif();
                            UpdateGrandTotalHtrans();
                        }
                    }

                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    listBox4.Items.Clear();

                    for (int i = 0; i < ID_selecteditem_MejaAktif.Count; i++)
                    {
                        listBox1.Items.Add(ID_selecteditem_MejaAktif[i].ToString());
                        listBox2.Items.Add(tmp_hargayangdipesan_MejaAktif[i].ToString());
                        listBox3.Items.Add(tmp_jumlah_MejaAktif[i].ToString());
                        listBox4.Items.Add(tmp_TOTALhargayangdipesan_MejaAktif[i].ToString());
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

                

            }
            else //UBAH JUMLAH ITEM
            {
                lbl_Peringatan.Visible = true;
                for (int i = 0; i < ID_selecteditem_MejaAktif.Count; i++)
                {
                    if (ID_selecteditem_MejaAktif[i].ToString() == pesanan.ID_Makanan.ToString())
                    {
                        tmp_jumlah_MejaAktif[i] = pesanan.Jumlah;
                        hitungsubtotalperitemMejaAktif(i);

                    }
                }


                listBox3.Items.Clear();
                for (int i = 0; i < ID_selecteditem_MejaAktif.Count; i++)
                {
                    listBox3.Items.Add(tmp_jumlah_MejaAktif[i].ToString());

                }
            }

            hitunggrandtotalMejaAktif();
            hitungkembalian();
        }


        void hitunggrandtotal()
        {
            grandtotal = 0;

            if (sisasatu == true)
            {
                grandtotal = 0;
                lbl_grandtotal.Text = grandtotal.ToString();
            }

            for (int i = 0; i < tmp_TOTALhargayangdipesan.Count; i++)
            {
                grandtotal += int.Parse(tmp_TOTALhargayangdipesan[i].ToString());

            }
            //grandtotal = grandtotal * PPN;
            if (tmpmakanbungkus == 1)
            {
                tmp_grandtotal_Htrans_SUDAHPPN_BUNGKUS = grandtotal + (grandtotal * PPN / 100);
                lbl_grandtotal.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(grandtotal.ToString()));
                lbl_grandtotalSUDAHPPN.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(tmp_grandtotal_Htrans_SUDAHPPN_BUNGKUS.ToString()));


            }
            else
            {
                lbl_grandtotal.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(grandtotal.ToString()));
            }


        }

        void hitunggrandtotalMejaAktif()
        {
            tmp_grandtotal_Htrans = 0;

            if (sisasatu_MejaAktif == true)
            {
                tmp_grandtotal_Htrans = 0;
                lbl_grandtotal_Htrans.Text = tmp_grandtotal_Htrans.ToString();
            }

            for (int i = 0; i < tmp_TOTALhargayangdipesan_MejaAktif.Count; i++)
            {
                tmp_grandtotal_Htrans += int.Parse(tmp_TOTALhargayangdipesan_MejaAktif[i].ToString());

            }
            //tmp_grandtotal_Htrans = tmp_grandtotal_Htrans + (tmp_grandtotal_Htrans * PPN / 100);
            lbl_grandtotal_Htrans.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(tmp_grandtotal_Htrans.ToString()));
            tmp_grandtotal_Htrans_SUDAHPPN = tmp_grandtotal_Htrans + (tmp_grandtotal_Htrans * PPN / 100);
            lbl_grandtotal_Htrans_SUDAHPPN.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(tmp_grandtotal_Htrans_SUDAHPPN.ToString()));
        }

        void hitungsubtotalperitem(int idx)
        {
            tmp_TOTALhargayangdipesan[idx] = int.Parse(tmp_jumlah[idx].ToString()) * int.Parse(tmp_hargayangdipesan[idx].ToString());

            listBox4.Items.Clear();
            for (int i = 0; i < ID_selecteditem.Count; i++)
            {
                listBox4.Items.Add(tmp_TOTALhargayangdipesan[i].ToString());

            }
        }

        void hitungsubtotalperitemMejaAktif(int idx)
        {
            tmp_TOTALhargayangdipesan_MejaAktif[idx] = int.Parse(tmp_jumlah_MejaAktif[idx].ToString()) * int.Parse(tmp_hargayangdipesan_MejaAktif[idx].ToString());

            listBox4.Items.Clear();
            for (int i = 0; i < ID_selecteditem_MejaAktif.Count; i++)
            {
                listBox4.Items.Add(tmp_TOTALhargayangdipesan_MejaAktif[i].ToString());
            }
        }

        void HapusPesananMejaAktif(int ID_Dtrans)
        {
            ClassDAL objDAL = new ClassDAL();
            objDAL.HapusDtrans(ID_Dtrans);
            
        }

        void UpdateGrandTotalHtrans()
        {
            ClassDAL objDAL = new ClassDAL();
            objDAL.UpdateGrandTotalHTrans(tmp_InvoiceIDMejaAktif, tmp_grandtotal_Htrans);
        }

        void UpdateDtrans()
        {
            ClassBLL objBLL = new ClassBLL();
            for (int i = 0; i < ID_Dtrans_MejaAktif.Count; i++)
            {
                if (objBLL.UpdateDtrans(int.Parse(ID_Dtrans_MejaAktif[i].ToString()), tmp_InvoiceIDMejaAktif, int.Parse(tmp_jumlah_MejaAktif[i].ToString()), int.Parse(tmp_TOTALhargayangdipesan_MejaAktif[i].ToString())))
                {
                    
                }
            }
            
        }

        void UserControlMenu_click(object sender, EventArgs e)
        {
            Makanan obj = (Makanan)sender;

            pb_menu.Image = obj.Icon;
            tmpIDUpdate = obj.ID;
            tb_nama_update.Text = obj.Nama;
            tb_harga_update.Text = obj.Harga;
            cb_kategori_update.SelectedIndex = obj.Category;
        }

        private void getGrandTotalHTrans(int invoiceID)
        {
            ClassBLL objbll = new ClassBLL();
            DataTable dt = objbll.GetHtrans(invoiceID);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            tmp_grandtotal_Htrans = int.Parse(row["Grand_Total"].ToString());
                            tmp_KasirMejaAktif = row["Nama_Kasir"].ToString();
                            tmp_TanggalMejaAktif = row["InvoiceDate"].ToString();

                        }

                    }
                }
            }

            //if (tmpmakanbungkus == 1 || nomormejaclick == true)
            //{
            //    tmp_grandtotal_Htrans = tmp_grandtotal_Htrans + (tmp_grandtotal_Htrans * PPN / 100);
            //    nomormejaclick = false;
            //}
            
            lbl_grandtotal_Htrans.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(tmp_grandtotal_Htrans.ToString()));
            tmp_grandtotal_Htrans_SUDAHPPN = tmp_grandtotal_Htrans + (tmp_grandtotal_Htrans * PPN / 100);
            lbl_grandtotal_Htrans_SUDAHPPN.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(tmp_grandtotal_Htrans_SUDAHPPN.ToString()));

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
            pesananataumenu = 0;
            DynamicUserControl(0);

            SidePanel.Height = BtnPesananBaru.Height;
            SidePanel.Top = BtnPesananBaru.Top;

            DataAccess db = new DataAccess();

            gb_PesananBaru.Visible = true;
            gb_menu.Visible = false;
            gb_mejaaktif.Visible = false;
            gb_History.Visible = false;

            tb_CaridiPesanan.Visible = true;
            btn_Cari.Visible = true;

            //namamakanan = db.GetDaftarMenus();
            UpdateBinding();
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
        }

        private void Btn_mejaaktiClick(object sender, EventArgs e)
        {
            SidePanel.Height = Btn_mejaaktif.Height;
            SidePanel.Top = Btn_mejaaktif.Top;

            CB_BayarMenggunakan.SelectedIndex = 0;
            gb_mejaaktif.Visible = true;
            gb_menu.Visible = false;
            gb_PesananBaru.Visible = false;
            gb_History.Visible = false;

            tb_CaridiPesanan.Visible = false;
            btn_Cari.Visible = false;

            MejaAktif();
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            pesananataumenu = 1;
            SidePanel.Height = BtnMenu.Height;
            SidePanel.Top = BtnMenu.Top;

            DynamicUserControlMenu(0);

            gb_PesananBaru.Visible = false;
            gb_menu.Visible = true;
            gb_mejaaktif.Visible = false;
            gb_History.Visible = false;

            tb_CaridiPesanan.Visible = true;
            btn_Cari.Visible = true;

            if (ActiveMdiChild != null) ActiveMdiChild.Close();

            //Laporan newMDIChildXXX = new Laporan();
            //newMDIChildXXX.MdiParent = this;
            //newMDIChildXXX.Show();
        }

        private void Btn_History_Click(object sender, EventArgs e)
        {

            SidePanel.Height = Btn_History.Height;
            SidePanel.Top = Btn_History.Top;

            gb_PesananBaru.Visible = false;
            gb_menu.Visible = false;
            gb_mejaaktif.Visible = false;
            gb_History.Visible = true;

            tb_CaridiPesanan.Visible = false;
            btn_Cari.Visible = false;

            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            //ClassDAL objdal = new ClassDAL();

            ////dgv_History.DataSource = objdal.ReadHtransALL();
            //dgv_History.Columns[7].Visible = false;
            //dgv_History.Columns[9].Visible = false;
            //dgv_History.Columns[10].Visible = false;

            //dgv_History.Columns[4].DefaultCellStyle.Format = "C0";
            //dgv_History.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");
            //dgv_History.Columns[8].DefaultCellStyle.Format = "C0";
            //dgv_History.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");
        }

        private void Btn_Laporan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Btn_Laporan.Height;
            SidePanel.Top = Btn_Laporan.Top;

            gb_PesananBaru.Visible = false;
            gb_menu.Visible = false;
            gb_mejaaktif.Visible = false;
            gb_History.Visible = false;

            tb_CaridiPesanan.Visible = false;
            btn_Cari.Visible = false;

            if (Application.OpenForms.OfType<Laporan>().Any())
            {
                Application.OpenForms.OfType<Laporan>().First().BringToFront();
            }
            else
            {
                Laporan f = new Laporan();
                f.MdiParent = this;
                f.Show();
                f.Location = new Point(0, 75);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                }
            }
            StartTimer();
            DTP_Dari.Value = DateTime.Now;
            DTP_Sampai.Value = DateTime.Now;

            DTP_Dari.Format = DateTimePickerFormat.Custom;
            DTP_Dari.CustomFormat = "dd-MM-yyyy";
            DTP_Sampai.Format = DateTimePickerFormat.Custom;
            DTP_Sampai.CustomFormat = "dd-MM-yyyy";
            //Load daftar menu
            DynamicUserControl(0);
            rb_makanditempat.Checked = true;
            loggeduser = Login.loggeduser;

            lbl_login.Text = loggeduser;
            if (Login.loggeduser != "admin")
            {
                BtnMenu.Visible = false;
                Btn_Laporan.Visible = false;
                Btn_TambahUserMenuStrip.Visible = false;
            }

            lbl_kasir.Text = Login.loggeduser;

            CultureInfo culture = CultureInfo.CreateSpecificCulture("id");
            //tanggal = DateTime.Now.ToString(culture.DateTimeFormat.LongDatePattern, culture);
            DateTime theDate = DateTime.Now;
            tanggal = theDate.ToString("yyyy-MM-dd H:mm:ss");

            //tanggal = DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss");
            //Lbl_Jam.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_tanggal.Text = DateTime.Now.ToString(culture.DateTimeFormat.LongDatePattern, culture);
            //label29.Text = tanggal.ToString();
            getPPN();
            cekMejaAktif();
        }

        public void getPPN()
        {
            ClassDAL objDAL = new ClassDAL();
            objDAL.getPPN();
            PPN = objDAL.ppn;
            if(tmpmakanbungkus == 1)
            {
                lbl_PPN1.Visible = true;
                lbl_PPN1.Text = "+PPN " + PPN.ToString() + "%";
                lbl_grandtotalSUDAHPPN.Visible = true;
            }
            else
            {
                lbl_grandtotalSUDAHPPN.Visible = false;
                lbl_PPN1.Visible = false;
            }
            lbl_PPN2.Text = PPN.ToString() + "%";
        }

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            Lbl_Jam.Text = DateTime.Now.ToString("HH:mm:ss");
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
            DynamicUserControl(0);
        }

        private void btnMinuman_Click(object sender, EventArgs e)
        {
            DynamicUserControl(1);
        }

        private void btn_snack_Click(object sender, EventArgs e)
        {
            DynamicUserControl(2);
        }

        #endregion

        #region Tombol Cari Trigger
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_CaridiPesanan.Text == "Cari Menu")
            {
                tb_CaridiPesanan.Text = "";
            }

            tb_CaridiPesanan.ForeColor = Color.Black;
        }

        
        private void tb_cari_Leave(object sender, EventArgs e)
        {
            
            tb_CaridiPesanan.Text = "Cari Menu";
            
            tb_CaridiPesanan.ForeColor = Color.FromArgb(172, 172, 172);

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

        private void rb_makanditempat_CheckedChanged(object sender, EventArgs e)
        {
            tmpmakanbungkus = 0; // makan ditempat
            //label9.Text = tmpmakanbungkus.ToString();
            tb_nomormeja.Enabled = true;
            btn_simpan.Enabled = true;
            Btn_CetakLangsung.Enabled = false;
            pnl_Bayar.Visible = false;
            getPPN();
            hitunggrandtotal();
        }

        private void rb_bungkus_CheckedChanged(object sender, EventArgs e)
        {
            tmpmakanbungkus = 1; // bungkus
            //label9.Text = tmpmakanbungkus.ToString();
            tb_nomormeja.Enabled = false;
            btn_simpan.Enabled = false;
            Btn_CetakLangsung.Enabled = true;
            tb_nomormeja.Text = "";
            pnl_Bayar.Visible = true;
            CB_BayarMenggunakanBungkus.SelectedIndex = 0;
            TB_BayarBungkus.Text = "";
            lbl_KembaliBungkus.Text = "0";
            getPPN();
            hitunggrandtotal();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_makanan_menu_Click(object sender, EventArgs e)
        {
            DynamicUserControlMenu(0);

        }

        private void btn_minuman_menu_Click(object sender, EventArgs e)
        {
            DynamicUserControlMenu(1);

        }

        private void btn_snack_menu_Click(object sender, EventArgs e)
        {
            DynamicUserControlMenu(2);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TambahMenu tb = new TambahMenu();
            tb.Show();
        }

        private void btn_gantigambar_Click(object sender, EventArgs e)
        {
            if(pb_menu.Image == null)
            {
                MessageBox.Show("Pilih Menu Terlebih Dahulu");
            }
            else
            {
                OpenFileDialog opendlg = new OpenFileDialog();
                if (opendlg.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(opendlg.FileName);
                    pb_menu.Image = image;
                }
            }
            
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            pb_menu.Image = null;
            tb_nama_update.Text = "";
            tb_harga_update.Text = "";
            cb_kategori_update.SelectedItem = null; 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_dismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ClassBLL objbll = new ClassBLL();

            if (objbll.UpdateItems(tb_nama_update.Text, tb_harga_update.Text, pb_menu.Image, cb_kategori_update.SelectedIndex, tmpIDUpdate))
            {
                MessageBox.Show("Berhasil Update!");
            }
            else
            {
                MessageBox.Show("Gagal Update!");
            }

            #region refresh otomatis
            if (cb_kategori_update.SelectedIndex == 0)
            {
                DynamicUserControlMenu(0);
                DynamicUserControl(0);
            }
            else if (cb_kategori_update.SelectedIndex == 1)
            {
                DynamicUserControlMenu(1);
                DynamicUserControl(1);

            }
            else
            {
                DynamicUserControlMenu(2);
                DynamicUserControl(2);
            }
            #endregion

        }

        private void btn_Hapus_Click(object sender, EventArgs e)
        {
            ClassBLL objbll = new ClassBLL();


            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan menghapus menu?", "KONFIRMASI", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (objbll.DeleteItems(tmpIDUpdate))
                {
                    MessageBox.Show("Berhasil Menghapus!");
                    #region refresh otomatis
                    if (cb_kategori_update.SelectedIndex == 0)
                    {
                        DynamicUserControlMenu(0);
                        DynamicUserControl(0);
                    }
                    else if (cb_kategori_update.SelectedIndex == 1)
                    {
                        DynamicUserControlMenu(1);
                        DynamicUserControl(1);

                    }
                    else
                    {
                        DynamicUserControlMenu(2);
                        DynamicUserControl(2);
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("Gagal Menghapus!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


            
        }

        private void tb_nama_update_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_nama_update_Enter(object sender, EventArgs e)
        {

        }

        private void tb_nama_update_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_update_Click(this, new EventArgs());
            }
        }

        private void tb_harga_update_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void tb_harga_update_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_update_Click(this, new EventArgs());
            }
        }

        private void BtnMenu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            bersihkan();
            hitungkembalianBUNGKUS();
        }

        private void bersihkan()
        {
            ID_selecteditem.Clear();
            tmp_hargayangdipesan.Clear();
            tmp_jumlah.Clear();
            tmp_TOTALhargayangdipesan.Clear();
            pnl_pesanan.Controls.Clear();
            tmp_namamakanan.Clear();
            lbl_NomormejaAktif.Text = "";
            lbl_invoiceIDAktif.Text = "";
            tb_nomormeja.Text = "";
            hitunggrandtotal();
            lbl_grandtotal.Text = "0";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cekMejaAktif()
        {
            listBox5.Items.Clear();
            tmp_MejaAktif.Clear();
            apakahmejaaktif = false;
            ClassBLL objbll = new ClassBLL();
            DataTable dt = objbll.GetMejaAktif();

            foreach (DataRow row in dt.Rows)
            {
                tmp_MejaAktif.Add(row["Nomor_Meja"].ToString());
            }

            //cek apakah meja yang dipilih aktif atau tidak
            for (int i = 0; i < tmp_MejaAktif.Count; i++)
            {
                listBox5.Items.Add(tmp_MejaAktif[i]);
                if (tmp_MejaAktif[i].ToString() == tb_nomormeja.Text)
                {
                    apakahmejaaktif = true;
                }

            }

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            apakahmejaaktif = false;
            DateTime theDate = DateTime.Now;
            tanggal = theDate.ToString("yyyy-MM-dd H:mm:ss");

            ClassBLL objbll = new ClassBLL();
            ClassDAL objDAL = new ClassDAL();

            DataTable dt = objbll.GetMejaAktif();
            
            if (tb_nomormeja.Text == "")
            {
                MessageBox.Show("Masukkan nomor meja!");
            }
            else
            {
                cekMejaAktif();

                if (apakahmejaaktif == true)
                {
                    listBox6.Items.Clear();

                    getinvoiceIDMejaAktif(int.Parse(tb_nomormeja.Text));

                    for (int i = 0; i < ID_selecteditem.Count; i++)
                    {
                        CekPesananSudahDipesanSebelumnya(int.Parse(ID_selecteditem[i].ToString()), tmp_InvoiceIDMejaAktif);
                        if(pernahdipesan == false)
                        {
                            if (objbll.TambahPesananDTRANS(tmp_InvoiceIDMejaAktif, int.Parse(tb_nomormeja.Text), int.Parse(ID_selecteditem[i].ToString()), tmp_namamakanan[i].ToString(), int.Parse(tmp_jumlah[i].ToString()), int.Parse(tmp_hargayangdipesan[i].ToString()), 0, int.Parse(tmp_TOTALhargayangdipesan[i].ToString())))
                            {
                                flowLayoutDaftarPesanan.Controls.Clear();
                                TambahGrandTotal(int.Parse(tmp_TOTALhargayangdipesan[i].ToString()));
                                //bersihkan();
                            }
                        }
                        else
                        {
                            objDAL.getQuantity(int.Parse(tmp_ID_Dtrans_Pernahdipesan.ToString()));
                            tmp_Quantity = objDAL.tmp_Quantity;
                            hitungsemua(tmp_Quantity, int.Parse(tmp_jumlah[i].ToString()), int.Parse(tmp_hargayangdipesan[i].ToString()));

                            MessageBox.Show(int.Parse(tmp_jumlah[i].ToString()) + " porsi " + tmp_namamakanan[i].ToString() + " ditambahkan. Jumlah sebelumnya: " + tmp_Quantity.ToString() + ". Jumlah sekarang: " + totalquantitybaru.ToString());
                            objDAL.UpdatePesanan(totalquantitybaru, tmp_ID_Dtrans_Pernahdipesan, totalhargabaru);

                            //MessageBox.Show(tmp_TOTALhargayangdipesan[i].ToString());
                            TambahGrandTotal(int.Parse(tmp_TOTALhargayangdipesan[i].ToString()));
                            //bersihkan();
                        }
                        
                    }  
                    if(pernahdipesan == false)
                    {
                        MessageBox.Show("Pesanan ditambahkan ke meja: " + tb_nomormeja.Text);
                    }
                }
                else
                {
                    if (objbll.TambahPesananHTRANS(tanggal, "cash", 0, grandtotal, 0, loggeduser, int.Parse(tb_nomormeja.Text), 1, 0))
                    {
                        generateinvoiceID();

                        //objbll.TambahkanMejaAktif(tmp_LastInvoiceID, int.Parse(tb_nomormeja.Text));

                        cekMejaAktif();

                        for (int i = 0; i < ID_selecteditem.Count; i++)
                        {                                  //Invoice ID          //nomor meja              //ID Makanan                              //nama makanan                  //quantity                           //harga satuan                  //discountper                 //total harga 
                            if (objbll.TambahPesananDTRANS(tmp_LastInvoiceID, int.Parse(tb_nomormeja.Text), int.Parse(ID_selecteditem[i].ToString()), tmp_namamakanan[i].ToString(), int.Parse(tmp_jumlah[i].ToString()), int.Parse(tmp_hargayangdipesan[i].ToString()), 0, int.Parse(tmp_TOTALhargayangdipesan[i].ToString())))
                            {

                            }
                        }
                        generateinvoiceID();
                        try
                        {
                            generateinvoiceID();
                            PrintDocument pd = new PrintDocument();
                            PrinterSettings ps = new PrinterSettings();
                            for (int i = 0; i < 2; i++)
                            {
                                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPageMejaBaru);
                                ctrprintdapurdanmeja = i;
                                pd.PrinterSettings.PrinterName = "POS-58";
                                pd.Print();
                                Thread.Sleep(8000);
                            }



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        MessageBox.Show("Pesanan Baru Telah Ditambahkan! Meja Aktif: " + tb_nomormeja.Text);
                        bersihkan();

                    }
                    else
                    {
                        MessageBox.Show("Gagal Menyimpan!");
                    }
                    
                    

                }
            }



            bersihkan();
        }

        private void Btn_CetakLangsung_Click(object sender, EventArgs e)
        {
            ClassBLL objbll = new ClassBLL();
            ClassDAL objDAL = new ClassDAL();
            DateTime theDate = DateTime.Now;
            tanggal = theDate.ToString("yyyy-MM-dd H:mm:ss");
            tmpmakanbungkus = 1;
            ctrprintdapurdanmeja = 0;
            if(TB_BayarBungkus.Text == "")
            {
                MessageBox.Show("Masukkan jumlah pembayaran!");
            }
            else
            {
                if (tbbayarBungkus >= grandtotal)
                {
                    if (objbll.TambahPesananHTRANS(tanggal, CB_BayarMenggunakanBungkus.SelectedItem.ToString(), 0, grandtotal, tmp_grandtotal_Htrans_SUDAHPPN_BUNGKUS, loggeduser, 999, 0, int.Parse(TB_BayarBungkus.Text)))
                    {
                        generateinvoiceID();

                        for (int i = 0; i < ID_selecteditem.Count; i++)
                        {                                  //Invoice ID    //nomor meja              //ID Makanan                              //nama makanan                  //quantity                           //harga satuan                  //discountper                 //total harga 
                            if (objbll.TambahPesananDTRANS(tmp_LastInvoiceID, 999, int.Parse(ID_selecteditem[i].ToString()), tmp_namamakanan[i].ToString(), int.Parse(tmp_jumlah[i].ToString()), int.Parse(tmp_hargayangdipesan[i].ToString()), 0, int.Parse(tmp_TOTALhargayangdipesan[i].ToString())))
                            {
                                TB_BayarBungkus.Clear();
                                lbl_KembaliBungkus.Text = "0";
                            }
                        }
                        generateinvoiceID();
                        try
                        {
                            generateinvoiceID();
                            PrintDocument pd = new PrintDocument();
                            PrintDocument pd2 = new PrintDocument();

                            PrinterSettings ps = new PrinterSettings();

                            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPageMejaBaru);
                            pd.PrinterSettings.PrinterName = "POS-58";
                            pd.Print();

                            pd2.PrintPage += new PrintPageEventHandler(this.pd_PrintPageBungkus);
                            pd2.PrinterSettings.PrinterName = "POS-80";
                            pd2.Print();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        MessageBox.Show("Pesanan Baru Telah Ditambahkan!" + tb_nomormeja.Text);
                        bersihkan();

                    }
                    else
                    {
                        MessageBox.Show("Gagal Menyimpan!");
                    }
                }
                else
                {
                    MessageBox.Show("Pembayaran belum mencukupi!");
                }
            }
            
            
        }

        void TambahGrandTotal(int TOTALhargayangdipesan)
        {
            tmp_grandtotal_Htrans += TOTALhargayangdipesan;
            ClassDAL objDAL = new ClassDAL();
            objDAL.UpdateGrandTotalHTrans(tmp_InvoiceIDMejaAktif, tmp_grandtotal_Htrans);
        }

        private void CekPesananSudahDipesanSebelumnya(int ID_SelectedItem, int tmp_InvoiceIDMejaAktif)
        {
            ClassBLL objbll = new ClassBLL();
            label18.Text = tmp_InvoiceIDMejaAktif.ToString();
            tmp_ID_Makanan.Clear(); tmp_ID_Dtrans.Clear();
            pernahdipesan = false;
            DataTable dt = objbll.GetDtrans(tmp_InvoiceIDMejaAktif);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            tmp_ID_Makanan.Add(int.Parse(row["ID_Makanan"].ToString()));
                            tmp_ID_Dtrans.Add(int.Parse(row["ID_Dtrans"].ToString()));
                        }
                    }
                    
                    for (int i = 0; i < tmp_ID_Makanan.Count; i++)
                    {
                        if(int.Parse(tmp_ID_Makanan[i].ToString()) == ID_SelectedItem)
                        {
                            label25.Text = ID_SelectedItem.ToString();
                            listBox6.Items.Add("Pernah dipesan");
                            pernahdipesan = true;
                            tmp_ID_Dtrans_Pernahdipesan = int.Parse(tmp_ID_Dtrans[i].ToString());
                            break;
                        }
                        else
                        {
                            label25.Text = ID_SelectedItem.ToString();
                            listBox6.Items.Add("Belum pernah dipesan");
                            
                            pernahdipesan = false;
                        }
                    }
                }
            }

        }

        public void hitungsemua(int quantitysebelumnya, int quantitytambahan, int hargasatuan)
        {
            totalquantitybaru = quantitysebelumnya + quantitytambahan;
            totalhargabaru = totalquantitybaru * hargasatuan;
            flowLayoutDaftarPesanan.Controls.Clear();
        }

        public void generateinvoiceID()
        {
            ClassDAL objdal = new ClassDAL();
            objdal.getInvoiceID();
            tmp_LastInvoiceID = objdal.lastinsertedid;
            label26.Text = tmp_LastInvoiceID.ToString();
        }

        public void getinvoiceIDMejaAktif(int nomor_meja)
        {
            ClassDAL objdal = new ClassDAL();
            objdal.getInvoiceIDMejaAktif(nomor_meja);
            tmp_InvoiceIDMejaAktif = objdal.tmp_InvoiceIDMejaAktif;
        }
        private void btn_editpesanan_Click(object sender, EventArgs e)
        {
            UpdateDtrans();
            UpdateGrandTotalHtrans();
            MessageBox.Show("Berhasil Update Pesanan!");
            lbl_Peringatan.Visible = false;
            tb_Bayar.Clear();
            lbl_Kembalian.Text = "0";
        }



        //Print saat meja baru dibuka, print 2x di dapur. 1 untuk ditempel dimeja, 1 untuk dapur, semua data baru dimasukkan ke DB
        private void pd_PrintPageMejaBaru(object sender, PrintPageEventArgs ev)
        {
            
            ClassBLL objbll = new ClassBLL();

            DataTable NotaDapur = objbll.GetNotaDapur(tmp_LastInvoiceID);
            DataTable dt = new DataTable();
            dt.Columns.Add("Qty");
            dt.Columns.Add("Product");
            dt.Columns.Add("Category");
            dt.Columns.Add("Nomor_Meja");
            dt.Columns.Add("InvoiceID");
            dt.Columns.Add("Nama_Kasir");
            dt.Columns.Add("InvoiceDate");


            DataRow dr = dt.NewRow();

            foreach (DataRow row in NotaDapur.Rows)
            {
                dr = dt.NewRow();

                dr[0] = row["Quantity"].ToString();
                dr[1] = row["nama_makanan"].ToString();
                dr[2] = row["category_makanan"].ToString();
                dr[3] = row["Nomor_Meja"].ToString();
                dr[4] = row["InvoiceID"].ToString();
                dr[5] = row["Nama_Kasir"];
                dr[6] = row["InvoiceDate"];

                dt.Rows.Add(dr);
            }

            System.Drawing.Font headingFont = new System.Drawing.Font("Calibri", 20, System.Drawing.FontStyle.Regular);
            System.Drawing.Font headingFontBungkus = new System.Drawing.Font("Calibri", 16, System.Drawing.FontStyle.Regular);
            System.Drawing.Font Footerfont = new System.Drawing.Font("Calibri", 13, System.Drawing.FontStyle.Regular);
            System.Drawing.Font Totalfont = new System.Drawing.Font("Calibri", 12, System.Drawing.FontStyle.Bold);
            System.Drawing.Font Neckfont = new System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font boldFont = new System.Drawing.Font("Calibri", 11, System.Drawing.FontStyle.Bold);
            System.Drawing.Font normalFont = new System.Drawing.Font("Calibri", 11, System.Drawing.FontStyle.Regular);


            float topMargin = ev.MarginBounds.Top;
            float leftMargin = ev.MarginBounds.Left;

            string NoMeja = dr[3].ToString();
            string receipt_no = dr[4].ToString();
            string kasir = dr[5].ToString();

            CultureInfo info = new CultureInfo("en-US");
            DateTime conDate = Convert.ToDateTime(dr[6]);
            string receipt_date = conDate.ToString("dd/MM/yyyy HH:mm:ss");

            string line = "--------------------------------------------------------------------------------";
            float height = 5;

            if(ctrprintdapurdanmeja == 0)
            {
                //printDAPUR
                ev.Graphics.DrawString("DAPUR", headingFont, Brushes.Black, 50, height, new StringFormat());
                height += 23;
                ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
                height += 15;
            }
            if(tmpmakanbungkus == 1)
            {
                ev.Graphics.DrawString("BUNGKUS", headingFontBungkus, Brushes.Black, 45, height, new StringFormat());
                height += 23;
            }
            else
            {
                //Print No Meja
                ev.Graphics.DrawString("MEJA: " + NoMeja, headingFont, Brushes.Black, 45, height, new StringFormat());
                height += 23;
            }
            
            
            ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
            height += 15;
            //Print Receipt No
            ev.Graphics.DrawString("Invoice ID", Neckfont, Brushes.Black, -3, height, new StringFormat());
            ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 63, height, new StringFormat());
            ev.Graphics.DrawString(receipt_no, Neckfont, Brushes.Black, 68, height, new StringFormat());
            height += 15;
            //Print Kasir
            ev.Graphics.DrawString("Kasir", Neckfont, Brushes.Black, -3, height, new StringFormat());
            ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 63, height, new StringFormat());
            ev.Graphics.DrawString(kasir, Neckfont, Brushes.Black, 68, height, new StringFormat());
            height += 15;
            //Print Receipt Date
            ev.Graphics.DrawString("Tanggal", Neckfont, Brushes.Black, -3, height, new StringFormat());
            ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 63, height, new StringFormat());
            ev.Graphics.DrawString(receipt_date, Neckfont, Brushes.Black, 68, height, new StringFormat());
            height += 15;

            //Print Line
            ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
            height += 10;


            //Print Makanan
            ev.Graphics.DrawString("--MAKANAN--", headingFont, Brushes.Black, 13, height, new StringFormat());
            height += 30;

            //Print Table Rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 0= quantity. 1= nama. 2 = category
                if (int.Parse(dt.Rows[i][2].ToString()) == 0)
                {
                    ev.Graphics.DrawString(dt.Rows[i][0].ToString() + "X", normalFont, Brushes.Black, -3, height, new StringFormat());
                    ev.Graphics.DrawString(dt.Rows[i][1].ToString(), normalFont, Brushes.Black, 30, height, new StringFormat());

                    height += 15;
                }


            }

            height += 10;

            //Print Minuman
            ev.Graphics.DrawString("--MINUMAN--", headingFont, Brushes.Black, 13, height, new StringFormat());
            height += 30;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 0= quantity. 1= nama. 2 = category
                if (int.Parse(dt.Rows[i][2].ToString()) == 1)
                {
                    ev.Graphics.DrawString(dt.Rows[i][0].ToString() + "X", normalFont, Brushes.Black, -3, height, new StringFormat());
                    ev.Graphics.DrawString(dt.Rows[i][1].ToString(), normalFont, Brushes.Black, 30, height, new StringFormat());

                    height += 15;
                }

            }

            height += 10;

            //Print Snack
            ev.Graphics.DrawString("--SNACK--", headingFont, Brushes.Black, 35, height, new StringFormat());
            height += 30;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 0= quantity. 1= nama. 2 = category
                if (int.Parse(dt.Rows[i][2].ToString()) == 2)
                {
                    ev.Graphics.DrawString(dt.Rows[i][0].ToString() + "X", normalFont, Brushes.Black, -3, height, new StringFormat());
                    ev.Graphics.DrawString(dt.Rows[i][1].ToString(), normalFont, Brushes.Black, 30, height, new StringFormat());

                    height += 15;
                }

            }

            //Print Line
            ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
            height += 15;

            ev.Graphics.DrawString(DateTime.Now.ToString("HH:mm:ss"), normalFont, Brushes.Black, 60, height, new StringFormat());



            ev.HasMorePages = false;
        }

        //print untuk customer saat bungkus
        private void pd_PrintPageBungkus(object sender, PrintPageEventArgs ev)
        {
            ClassBLL objbll = new ClassBLL();
            label5.Text = tmp_InvoiceIDMejaAktif.ToString();
            getGrandTotalHTrans(tmp_LastInvoiceID);
            DataTable Dtrans = objbll.GetDtrans(tmp_LastInvoiceID);

            DataTable dt = new DataTable();
            dt.Columns.Add("Product");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Price");
            dt.Columns.Add("Total");
            dt.Columns.Add("InvoiceID");
            dt.Columns.Add("Nomor_Meja");


            DataRow dr = dt.NewRow();

            foreach (DataRow row in Dtrans.Rows)
            {
                dr = dt.NewRow();

                dr[0] = row["Quantity"].ToString();
                dr[1] = row["nama_makanan"].ToString();
                dr[2] = row["harga_makanan"].ToString();
                dr[3] = row["Total_Amount"].ToString();
                dr[4] = row["InvoiceID"].ToString();
                dr[5] = row["Nomor_Meja"].ToString();

                dt.Rows.Add(dr);
            }

            System.Drawing.Font headingFont = new System.Drawing.Font("Beautiful Vibes", 20, System.Drawing.FontStyle.Regular);

            System.Drawing.Font Footerfont = new System.Drawing.Font("Calibri", 13, System.Drawing.FontStyle.Regular);
            System.Drawing.Font Totalfont = new System.Drawing.Font("Calibri", 12, System.Drawing.FontStyle.Bold);

            System.Drawing.Font Neckfont = new System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Regular);

            System.Drawing.Font boldFont = new System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Bold);
            System.Drawing.Font normalFont = new System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Regular);


            float topMargin = ev.MarginBounds.Top;
            float leftMargin = ev.MarginBounds.Left;

            string receipt_no = tmp_LastInvoiceID.ToString();
            CultureInfo info = new CultureInfo("en-US");

            DateTime conDate = Convert.ToDateTime(tmp_TanggalMejaAktif);
            string receipt_date = conDate.ToString("dd/MM/yyyy HH:mm:ss");
            string net_total = tmp_grandtotal_Htrans.ToString();
            string kasir = tmp_KasirMejaAktif.ToString();
            string NoMeja = "BUNGKUS";
            string line = "--------------------------------------------------------------------------------";
            float height = 5;

            //Print Company Name
            ev.Graphics.DrawString("Silvana", headingFont, Brushes.Black, 95, height, new StringFormat());
            height += 25;
            //Print Company Address
            ev.Graphics.DrawString("Jl. Bulawambona No.8, Baubau", normalFont, Brushes.Black, 50, height, new StringFormat());
            height += 30;

            //Print Receipt No
            ev.Graphics.DrawString("Invoice ID", Neckfont, Brushes.Black, -3, height, new StringFormat());
            ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 75, height, new StringFormat());
            ev.Graphics.DrawString(receipt_no, Neckfont, Brushes.Black, 85, height, new StringFormat());
            height += 15;
            //Print Receipt Date
            ev.Graphics.DrawString("Tanggal", Neckfont, Brushes.Black, -3, height, new StringFormat());
            ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 75, height, new StringFormat());
            ev.Graphics.DrawString(receipt_date, Neckfont, Brushes.Black, 85, height, new StringFormat());
            height += 15;
            //Print Kasir
            ev.Graphics.DrawString("Kasir", Neckfont, Brushes.Black, -3, height, new StringFormat());
            ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 75, height, new StringFormat());
            ev.Graphics.DrawString(kasir, Neckfont, Brushes.Black, 85, height, new StringFormat());
            height += 15;
            //Print No Meja
            ev.Graphics.DrawString("Nomor Meja", Neckfont, Brushes.Black, -3, height, new StringFormat());
            ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 75, height, new StringFormat());
            ev.Graphics.DrawString(NoMeja, Neckfont, Brushes.Black, 85, height, new StringFormat());
            height += 15;

            //Print Line
            ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
            height += 15;

            //Printe Table Headings
            //ev.Graphics.DrawString("Qty", normalFont, Brushes.Black, 1, height, new StringFormat());
            //ev.Graphics.DrawString("Description", normalFont, Brushes.Black, 23, height, new StringFormat());
            //ev.Graphics.DrawString("Price", normalFont, Brushes.Black, 90, height, new StringFormat());
            //ev.Graphics.DrawString("Total", normalFont, Brushes.Black, 140, height, new StringFormat());
            //height += 15;

            //Print Line
            //ev.Graphics.DrawString(line, normalFont, Brushes.Black, 1, height, new StringFormat());
            //height += 15;

            //Print Table Rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 0= quantity. 1= nama. 2 = harga. 3 = amount
                SizeF namawidth = ev.Graphics.MeasureString(dt.Rows[i][1].ToString(), normalFont);
                SizeF priceWidth = ev.Graphics.MeasureString(dt.Rows[i][2].ToString(), normalFont);
                SizeF totalWidth = ev.Graphics.MeasureString(dt.Rows[i][3].ToString(), normalFont);


                ev.Graphics.DrawString(dt.Rows[i][0].ToString() + "x", normalFont, Brushes.Black, -3, height, new StringFormat());
                ev.Graphics.DrawString(dt.Rows[i][1].ToString(), boldFont, Brushes.Black, 30, height, new StringFormat());
                CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
                ev.Graphics.DrawString(string.Format(elGR, "{0:0,0}", int.Parse(dt.Rows[i][2].ToString())), normalFont, Brushes.Black, 160 + (45 - priceWidth.Width), height, new StringFormat());
                ev.Graphics.DrawString(string.Format(elGR, "{0:0,0}", int.Parse(dt.Rows[i][3].ToString())), normalFont, Brushes.Black, 235 + (45 - totalWidth.Width), height, new StringFormat());
                height += 15;

            }
            //Print Line
            ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
            height += 15;

            //Print Net Total
            ev.Graphics.DrawString("Total", Totalfont, Brushes.Black, -3, height, new StringFormat());

            SizeF netWidth = ev.Graphics.MeasureString(net_total, normalFont);
            string tmp_net_total = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(net_total.ToString()));
            label5.Text = tmp_net_total;
            ev.Graphics.DrawString(tmp_net_total, boldFont, Brushes.Black, 210 + (50 - netWidth.Width), height, new StringFormat());
            height += 15;

            //Print Line
            ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
            height += 20;

            ev.Graphics.DrawString("Terima kasih - Silahkan datang lagi!", Footerfont, Brushes.Black, 5, height, new StringFormat());

            ev.HasMorePages = false;
        }

        //print saat pesanan selesai
        private void pd_PrintPagePesananSelesai(object sender, PrintPageEventArgs ev)
        {
            ClassBLL objbll = new ClassBLL();
            label5.Text = tmp_InvoiceIDMejaAktif.ToString();
            getGrandTotalHTrans(tmp_InvoiceIDMejaAktif);
            if(tmp_InvoiceIDMejaAktif == 0)
            {
                MessageBox.Show("Pilih meja yang ingin dicetak!");
            }
            else
            {
                DataTable Dtrans = objbll.GetDtrans(tmp_InvoiceIDMejaAktif);

                DataTable dt = new DataTable();
                dt.Columns.Add("Product");
                dt.Columns.Add("Qty");
                dt.Columns.Add("Price");
                dt.Columns.Add("Total");

                DataRow dr = dt.NewRow();

                foreach (DataRow row in Dtrans.Rows)
                {
                    dr = dt.NewRow();

                    dr[0] = row["Quantity"].ToString();
                    dr[1] = row["nama_makanan"].ToString();
                    dr[2] = row["harga_makanan"].ToString();
                    dr[3] = row["Total_Amount"].ToString();

                    dt.Rows.Add(dr);
                }

                System.Drawing.Font headingFont = new System.Drawing.Font("Beautiful Vibes", 20, System.Drawing.FontStyle.Regular);



                System.Drawing.Font Footerfont = new System.Drawing.Font("Calibri", 13, System.Drawing.FontStyle.Regular);
                System.Drawing.Font Totalfont = new System.Drawing.Font("Calibri", 12, System.Drawing.FontStyle.Bold);

                System.Drawing.Font Neckfont = new System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Regular);

                System.Drawing.Font boldFont = new System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Bold);
                System.Drawing.Font normalFont = new System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Regular);


                float topMargin = ev.MarginBounds.Top;
                float leftMargin = ev.MarginBounds.Left;

                string receipt_no = tmp_InvoiceIDMejaAktif.ToString();
                CultureInfo info = new CultureInfo("en-US");
                //tmp_TanggalMejaAktif

                DateTime conDate = Convert.ToDateTime(tmp_TanggalMejaAktif);
                string receipt_date = conDate.ToString("dd/MM/yyyy HH:mm:ss");
                string net_total = tmp_grandtotal_Htrans.ToString();
                string kasir = tmp_KasirMejaAktif.ToString();
                string NoMeja = tmp_NomorMejaAktif.ToString();
                string line = "--------------------------------------------------------------------------------";
                float height = 5;


                //Print Company Name
                ev.Graphics.DrawString("Silvana", headingFont, Brushes.Black, 100, height, new StringFormat());
                height += 25;
                //Print Company Address
                ev.Graphics.DrawString("Jl. Bulawambona No.8, Baubau", normalFont, Brushes.Black, 55, height, new StringFormat());
                height += 30;

                //Print Receipt No
                ev.Graphics.DrawString("Invoice ID", Neckfont, Brushes.Black, -3, height, new StringFormat());
                ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 75, height, new StringFormat());
                ev.Graphics.DrawString(receipt_no, Neckfont, Brushes.Black, 85, height, new StringFormat());
                height += 15;
                //Print Receipt Date
                ev.Graphics.DrawString("Tanggal", Neckfont, Brushes.Black, -3, height, new StringFormat());
                ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 75, height, new StringFormat());
                ev.Graphics.DrawString(receipt_date, Neckfont, Brushes.Black, 85, height, new StringFormat());
                height += 15;
                //Print Kasir
                ev.Graphics.DrawString("Kasir", Neckfont, Brushes.Black, -3, height, new StringFormat());
                ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 75, height, new StringFormat());
                ev.Graphics.DrawString(kasir, Neckfont, Brushes.Black, 85, height, new StringFormat());
                height += 15;
                //Print No Meja
                ev.Graphics.DrawString("Nomor Meja", Neckfont, Brushes.Black, -3, height, new StringFormat());
                ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 75, height, new StringFormat());
                ev.Graphics.DrawString(NoMeja, Neckfont, Brushes.Black, 85, height, new StringFormat());
                height += 15;

                //Print Line
                ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
                height += 15;


                //Print Table Rows
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // 0= quantity. 1= nama. 2 = harga. 3 = amount
                    SizeF namawidth = ev.Graphics.MeasureString(dt.Rows[i][1].ToString(), normalFont);
                    SizeF priceWidth = ev.Graphics.MeasureString(dt.Rows[i][2].ToString(), normalFont);
                    SizeF totalWidth = ev.Graphics.MeasureString(dt.Rows[i][3].ToString(), normalFont);

                
                    ev.Graphics.DrawString(dt.Rows[i][0].ToString() + "x", normalFont, Brushes.Black, -3, height, new StringFormat());
                    ev.Graphics.DrawString(dt.Rows[i][1].ToString(), boldFont, Brushes.Black, 30, height, new StringFormat());
                    CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
                    ev.Graphics.DrawString(string.Format(elGR, "{0:0,0}", int.Parse(dt.Rows[i][2].ToString())), normalFont, Brushes.Black, 160 + (45- priceWidth.Width), height, new StringFormat());
                    ev.Graphics.DrawString(string.Format(elGR, "{0:0,0}", int.Parse(dt.Rows[i][3].ToString())), normalFont, Brushes.Black, 235 + (45 - totalWidth.Width), height, new StringFormat());
                    height += 15;

                }
                //Print Line
                ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
                height += 15;

                //Print Net Total
                ev.Graphics.DrawString("Total", Totalfont, Brushes.Black, -3, height, new StringFormat());

                SizeF netWidth = ev.Graphics.MeasureString(net_total, normalFont);
                string tmp_net_total = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(net_total.ToString()));
                label5.Text = tmp_net_total;
                ev.Graphics.DrawString(tmp_net_total, boldFont, Brushes.Black, 210 + (50 - netWidth.Width), height, new StringFormat());
                height += 15;

                //Print Line
                ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
                height += 20;

                ev.Graphics.DrawString("Terima kasih - Silahkan datang lagi!", Footerfont, Brushes.Black, 5, height, new StringFormat());

                ev.HasMorePages = false;
            }

        }

        //print saat menekan tombol print di dapur, akan print 2x. 1 untuk ditempel dimeja, 1 untuk dapur, semua data sudah ada di DB
        private void pd_PrintPageDapur(object sender, PrintPageEventArgs ev)
        {
            ClassBLL objbll = new ClassBLL();
            label5.Text = tmp_InvoiceIDMejaAktif.ToString();

            DataTable NotaDapur = objbll.GetNotaDapur(tmp_InvoiceIDMejaAktif);
            DataTable dt = new DataTable();
            dt.Columns.Add("Qty");
            dt.Columns.Add("Product");
            dt.Columns.Add("Category");

            DataRow dr = dt.NewRow();

            foreach (DataRow row in NotaDapur.Rows)
            {
                dr = dt.NewRow();

                dr[0] = row["Quantity"].ToString();
                dr[1] = row["nama_makanan"].ToString();
                dr[2] = row["category_makanan"].ToString();
                dt.Rows.Add(dr);
            }

            System.Drawing.Font headingFont = new System.Drawing.Font("Calibri", 20, System.Drawing.FontStyle.Regular);
            //System.Drawing.Font Footerfont = new System.Drawing.Font("Merchant Copy", 13, System.Drawing.FontStyle.Regular);
            //System.Drawing.Font Totalfont = new System.Drawing.Font("Merchant Copy", 15, System.Drawing.FontStyle.Bold);

            //System.Drawing.Font Neckfont = new System.Drawing.Font("Merchant Copy", 13, System.Drawing.FontStyle.Regular);

            //System.Drawing.Font boldFont = new System.Drawing.Font("Merchant Copy", 13, System.Drawing.FontStyle.Bold);
            //System.Drawing.Font normalFont = new System.Drawing.Font("Merchant Copy", 13, System.Drawing.FontStyle.Regular);



            System.Drawing.Font Footerfont = new System.Drawing.Font("Calibri", 13, System.Drawing.FontStyle.Regular);
            System.Drawing.Font Totalfont = new System.Drawing.Font("Calibri", 12, System.Drawing.FontStyle.Bold);

            System.Drawing.Font Neckfont = new System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Regular);

            System.Drawing.Font boldFont = new System.Drawing.Font("Calibri", 11, System.Drawing.FontStyle.Bold);
            System.Drawing.Font normalFont = new System.Drawing.Font("Calibri", 11, System.Drawing.FontStyle.Regular);


            float topMargin = ev.MarginBounds.Top;
            float leftMargin = ev.MarginBounds.Left;


            string receipt_no = tmp_InvoiceIDMejaAktif.ToString();
            CultureInfo info = new CultureInfo("en-US");
            //tmp_TanggalMejaAktif

            DateTime conDate = Convert.ToDateTime(tmp_TanggalMejaAktif);
            string receipt_date = conDate.ToString("dd/MM/yyyy HH:mm:ss");
            string net_total = tmp_grandtotal_Htrans.ToString();
            string kasir = tmp_KasirMejaAktif.ToString();
            string NoMeja = tmp_NomorMejaAktif.ToString();
            string line = "--------------------------------------------------------------------------------";
            float height = 5;

            if (ctrprintdapurdanmeja == 0)
            {
                ev.Graphics.DrawString("DAPUR", headingFont, Brushes.Black, 50, height, new StringFormat());
                height += 23;
            }
            //Print No Meja
            ev.Graphics.DrawString("MEJA: " + NoMeja, headingFont, Brushes.Black, 45, height, new StringFormat());
            height += 23;
            ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
            height += 15;
            //Print Receipt No
            ev.Graphics.DrawString("Invoice ID", Neckfont, Brushes.Black, -3, height, new StringFormat());
            ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 63, height, new StringFormat());
            ev.Graphics.DrawString(receipt_no, Neckfont, Brushes.Black, 68, height, new StringFormat());
            height += 15;
            //Print Kasir
            ev.Graphics.DrawString("Kasir", Neckfont, Brushes.Black, -3, height, new StringFormat());
            ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 63, height, new StringFormat());
            ev.Graphics.DrawString(kasir, Neckfont, Brushes.Black, 68, height, new StringFormat());
            height += 15;
            //Print Receipt Date
            ev.Graphics.DrawString("Tanggal", Neckfont, Brushes.Black, -3, height, new StringFormat());
            ev.Graphics.DrawString(":", Neckfont, Brushes.Black, 63, height, new StringFormat());
            ev.Graphics.DrawString(receipt_date, Neckfont, Brushes.Black, 68, height, new StringFormat());
            height += 15;
            
            //Print Line
            ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
            height += 10;


            //Print Makanan
            ev.Graphics.DrawString("--MAKANAN--", headingFont, Brushes.Black, 13, height, new StringFormat());
            height += 30;

            //Print Table Rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 0= quantity. 1= nama. 2 = category
                if (int.Parse(dt.Rows[i][2].ToString()) == 0)
                {
                    ev.Graphics.DrawString(dt.Rows[i][0].ToString() + "X", normalFont, Brushes.Black, -3, height, new StringFormat());
                    ev.Graphics.DrawString(dt.Rows[i][1].ToString(), normalFont, Brushes.Black, 30, height, new StringFormat());

                    height += 15;
                }
                

            }

            height += 10;

            //Print Minuman
            ev.Graphics.DrawString("--MINUMAN--", headingFont, Brushes.Black, 13, height, new StringFormat());
            height += 30;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 0= quantity. 1= nama. 2 = category
                if (int.Parse(dt.Rows[i][2].ToString()) == 1)
                {
                    ev.Graphics.DrawString(dt.Rows[i][0].ToString() + "X", normalFont, Brushes.Black, -3, height, new StringFormat());
                    ev.Graphics.DrawString(dt.Rows[i][1].ToString(), normalFont, Brushes.Black, 30, height, new StringFormat());

                    height += 15;
                }

            }

            height += 10;

            //Print Snack
            ev.Graphics.DrawString("--SNACK--", headingFont, Brushes.Black, 35, height, new StringFormat());
            height += 30;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 0= quantity. 1= nama. 2 = category
                if (int.Parse(dt.Rows[i][2].ToString()) == 2)
                {
                    ev.Graphics.DrawString(dt.Rows[i][0].ToString() + "X", normalFont, Brushes.Black, -3, height, new StringFormat());
                    ev.Graphics.DrawString(dt.Rows[i][1].ToString(), normalFont, Brushes.Black, 30, height, new StringFormat());

                    height += 15;
                }

            }

            //Print Line
            ev.Graphics.DrawString(line, normalFont, Brushes.Black, -3, height, new StringFormat());
            height += 15;

            ev.Graphics.DrawString(DateTime.Now.ToString("HH:mm:ss"), normalFont, Brushes.Black, 60, height, new StringFormat());



            ev.HasMorePages = false;
        }


        private void Btn_CetakDiDapur_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    ctrprintdapurdanmeja = i;
                    PrintDocument pd2 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    pd2.PrintPage += new PrintPageEventHandler(this.pd_PrintPageDapur);
                    pd2.PrinterSettings.PrinterName = "POS-58";
                    pd2.Print();
                    Thread.Sleep(8000);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_PesananSelesai_Click(object sender, EventArgs e)
        {
            ClassDAL objDal = new ClassDAL();
            if(tb_Bayar.Text == "")
            {
                MessageBox.Show("Masukkan jumlah pembayaran!");
            }
            else
            {
                
                if (tmp_grandtotal <= tbbayar)
                {
                    DialogResult dialogResult = MessageBox.Show("Selesaikan pesanan?", "KONFIRMASI", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        objDal.UpdateJumlahBayardanPaymentType(tmp_InvoiceIDMejaAktif, int.Parse(tb_Bayar.Text), tmp_grandtotal_Htrans_SUDAHPPN, CB_BayarMenggunakan.SelectedItem.ToString());
                        try
                        {
                            PrintDocument pd = new PrintDocument();
                            PrinterSettings ps = new PrinterSettings();
                            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPagePesananSelesai);
                            pd.PrinterSettings.PrinterName = "POS-80";
                            pd.Print();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        objDal.HapusMejaAktif(tmp_InvoiceIDMejaAktif);
                        MejaAktif();
                        bersihkanMejaAktif();
                    }
                }
                else
                {
                    MessageBox.Show("Pembayaran belum mencukupi!");
                }


            }


        }

        public void bersihkanMejaAktif()
        {
            tmp_NomorMejaAktif = 0;
            lbl_NomormejaAktif.Text = "0";
            lbl_invoiceIDAktif.Text = "";
            flowLayoutDaftarPesanan.Controls.Clear();
            ID_Dtrans_MejaAktif.Clear();
            ID_selecteditem_MejaAktif.Clear();
            tmp_namamakanan_MejaAktif.Clear();
            tmp_hargayangdipesan_MejaAktif.Clear();
            tmp_jumlah_MejaAktif.Clear();
            tmp_TOTALhargayangdipesan_MejaAktif.Clear();
            tmp_grandtotal_Htrans_SUDAHPPN = 0;
            tb_Bayar.Clear();
            lbl_Kembalian.Text = "0";
            lbl_grandtotal_Htrans.Text = "0";
            lbl_grandtotal_Htrans_SUDAHPPN.Text = "0";
        }
        private void Btn_BatalkanPesanan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Batalkan pesanan meja " + tmp_NomorMejaAktif + "?", "KONFIRMASI", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                ClassDAL objdal = new ClassDAL();
                objdal.HapusMejaAktif(tmp_InvoiceIDMejaAktif);
                objdal.HapusDtransBATAL(tmp_InvoiceIDMejaAktif);
                objdal.HapusHtransBATAL(tmp_InvoiceIDMejaAktif);

                MejaAktif();

                tmp_NomorMejaAktif = 0;
                lbl_NomormejaAktif.Text = "0";
                lbl_invoiceIDAktif.Text = "";
                flowLayoutDaftarPesanan.Controls.Clear();
                ID_Dtrans_MejaAktif.Clear();
                ID_selecteditem_MejaAktif.Clear();
                tmp_namamakanan_MejaAktif.Clear();
                tmp_hargayangdipesan_MejaAktif.Clear();
                tmp_jumlah_MejaAktif.Clear();
                tmp_TOTALhargayangdipesan_MejaAktif.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void dgv_History_SelectionChanged(object sender, EventArgs e)
        {
            ClassBLL objbll = new ClassBLL();
            //DataTable dt = objbll.GetDtrans(int.Parse(row.Cells[0].Value.ToString()));

            foreach (DataGridViewRow row in dgv_History.SelectedRows)
            {
                DGV_DetailPesanan.DataSource = objbll.GetDtrans(int.Parse(row.Cells[0].Value.ToString()));
                DGV_DetailPesanan.Columns["ID_Dtrans"].Visible = false;
                DGV_DetailPesanan.Columns["Nomor_Meja"].Visible = false;
                DGV_DetailPesanan.Columns["Harga_Makanan"].Visible = false;
                DGV_DetailPesanan.Columns["created_at"].Visible = false;
                DGV_DetailPesanan.Columns["Updated_at"].Visible = false;
                DGV_DetailPesanan.Columns["InvoiceID"].Visible = false;
                DGV_DetailPesanan.Columns["ID_Makanan"].Visible = false;
                DGV_DetailPesanan.Columns["DiscountPer"].Visible = false;

                DGV_DetailPesanan.Columns["Quantity"].DisplayIndex = 0;
                DGV_DetailPesanan.Columns["Nama_Makanan"].DisplayIndex = 1;
                DGV_DetailPesanan.Columns["Total_Amount"].DisplayIndex = 2;


                DGV_DetailPesanan.Columns["Total_Amount"].DefaultCellStyle.Format = "C0";
                DGV_DetailPesanan.Columns["Total_Amount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");

                //DGV_DetailHistoryPengeluaran.Columns[6].DefaultCellStyle.Format = "C0";
                //DGV_DetailHistoryPengeluaran.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");
            }

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CariHistory_Click(object sender, EventArgs e)
        {
            ClassDAL objDal = new ClassDAL();
            
            DTP_Dari.Format = DateTimePickerFormat.Custom;
            DTP_Dari.CustomFormat = "yyyy-MM-dd";
            DTP_Sampai.Format = DateTimePickerFormat.Custom;
            DTP_Sampai.CustomFormat = "yyyy-MM-dd";
            
            string tmp_dari = DTP_Dari.Text + " 00:00:00.000";
            string tmp_sampai = DTP_Sampai.Text + " 23:59:00.000";
            dgv_History.DataSource = objDal.SelectTanggal(tmp_dari, tmp_sampai);
            //dgv_History.Columns[7].Visible = false;
            dgv_History.Columns[8].Visible = false;
            dgv_History.Columns[10].Visible = false;
            dgv_History.Columns[11].Visible = false;


            dgv_History.Columns[4].DefaultCellStyle.Format = "C0";
            dgv_History.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");
            dgv_History.Columns[5].DefaultCellStyle.Format = "C0";
            dgv_History.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");
            dgv_History.Columns[9].DefaultCellStyle.Format = "C0";
            dgv_History.Columns[9].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");
            dgv_History.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            DTP_Dari.Format = DateTimePickerFormat.Custom;
            DTP_Dari.CustomFormat = "dd-MM-yyyy";
            DTP_Sampai.Format = DateTimePickerFormat.Custom;
            DTP_Sampai.CustomFormat = "dd-MM-yyyy";
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void tb_Bayar_TextChanged(object sender, EventArgs e)
        {
            
            hitungkembalian();
            
        }

        private void hitungkembalian()
        {
            tmp_grandtotal = tmp_grandtotal_Htrans_SUDAHPPN;
            tbbayar = 0;
            if (tb_Bayar.Text != "")
            {
                tbbayar = int.Parse(tb_Bayar.Text);
                //if (tmp_grandtotal < tbbayar)
                //{
                    kembalian = tbbayar - tmp_grandtotal;
                    lbl_Kembalian.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(kembalian.ToString()));
                //}
                //else
                //{
                    //lbl_Kembalian.Text = "0";
                //}
            }
            
        }

        private void CB_BayarMenggunakan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label33.Text = CB_BayarMenggunakan.SelectedItem.ToString();
        }

        private void TB_BayarBungkus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_Bayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_BayarBungkus_TextChanged(object sender, EventArgs e)
        {
            hitungkembalianBUNGKUS();
        }

        private void hitungkembalianBUNGKUS()
        {
            tbbayarBungkus = 0;
            if (TB_BayarBungkus.Text != "")
            {
                tbbayarBungkus = int.Parse(TB_BayarBungkus.Text);
                //if (grandtotal < tbbayarBungkus)
                //{
                    kembalianBungkus = tbbayarBungkus - tmp_grandtotal_Htrans_SUDAHPPN_BUNGKUS;
                    lbl_KembaliBungkus.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(kembalianBungkus.ToString()));
                //}
                //else
                //{
                //    lbl_KembaliBungkus.Text = "0";
                //}
        }
        }

        private void Dgv_History_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            
        }

        

        private void CB_Periode_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void RB_Penjualan_CheckedChanged(object sender, EventArgs e)
        {
            pilihReport = 0; //penjualan
        }

        private void RB_Pembelian_CheckedChanged(object sender, EventArgs e)
        {
            pilihReport = 1; //pembelian

        }

        private void RB_PenjualanPembelian_CheckedChanged(object sender, EventArgs e)
        {
            pilihReport = 2; //penjualan & pembelian

        }

        private void RB_Makanan_CheckedChanged(object sender, EventArgs e)
        {
            pilihReport = 3; //makanan

        }

        private void tb_CaridiPesanan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                flowLayoutPanel1.Controls.Clear();
                flyoutpanel_menu.Controls.Clear();

                ClassBLL objbll = new ClassBLL();
                ClassDAL objDAL = new ClassDAL();

                DataTable dt = objDAL.ReadItemsTableSearch(tb_CaridiPesanan.Text);

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

                                MemoryStream ms = new MemoryStream((byte[])row["gambar_makanan"]);
                                listItems[i].Icon = new Bitmap(ms);
                                listItems[i].Nama = row["nama_makanan"].ToString();
                                listItems[i].Harga = row["harga_makanan"].ToString();
                                listItems[i].ID = int.Parse(row["ID_makanan"].ToString());

                                if(pesananataumenu == 0) flowLayoutPanel1.Controls.Add(listItems[i]);
                                else flyoutpanel_menu.Controls.Add(listItems[i]);



                                listItems[i].Click += new System.EventHandler(this.UserControl_click);
                                listItems[i].Click += new System.EventHandler(this.UserControlMenu_click);

                                idx++;
                            }

                        }
                    }
                }
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_TambahUserMenuStrip_Click(object sender, EventArgs e)
        {
            Registrasi f = new Registrasi();
            f.ShowDialog();
        }

        private void Btn_GantiPasswordAdminMenuStrip_Click(object sender, EventArgs e)
        {
            GantiPassword f = new GantiPassword();
            f.ShowDialog();
        }

        private void btn_Pengeluaran_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btn_Pengeluaran.Height;
            SidePanel.Top = btn_Pengeluaran.Top;

            gb_PesananBaru.Visible = false;
            gb_menu.Visible = false;
            gb_mejaaktif.Visible = false;
            gb_History.Visible = false;
            tb_CaridiPesanan.Visible = false;
            btn_Cari.Visible = false;

            if (ActiveMdiChild != null) ActiveMdiChild.Close();


            if (Application.OpenForms.OfType<Laporan>().Any())
            {
                Application.OpenForms.OfType<Laporan>().First().BringToFront();
            }
            else
            {
                Pengeluaran f = new Pengeluaran();
                f.MdiParent = this;
                f.Show();
                f.Location = new Point(0, 75);
            }
        }

        private void TetapkanPPNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PPN f = new PPN();
            f.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            f.Show();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            getPPN();
            hitunggrandtotal();
            bersihkanMejaAktif();
        }
    }
}
