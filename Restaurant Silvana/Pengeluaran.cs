using Restaurant_Silvana.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Silvana
{
    public partial class Pengeluaran : Form
    {
        public Pengeluaran()
        {
            InitializeComponent();
        }
        ArrayList ID_Satuan = new ArrayList();

        ClassDAL objDAL = new ClassDAL();
        int tmp_LastInvoiceID;
        int sum = 0;

        int tmpselectionidx;
        int tmpSelectedIDPengeluaran;
        int sumSelectedPengeluaran;
        string tmpTanggalSelectedPengeluaran;
        bool edited = false;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pengeluaran_Load(object sender, EventArgs e)
        {
            DTP_Tanggal.Value = DateTime.Now;

            DTP_Tanggal.Format = DateTimePickerFormat.Custom;
            DTP_Tanggal.CustomFormat = "dd-MM-yyyy";

            loadsatuan();
            //loadHistoryPengeluaran();
        }

        private void loadsatuan()
        {
            DataTable dt = objDAL.getSatuan();
            CB_Satuan.Items.Clear();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        CB_Satuan.Items.Add(row["Nama_Satuan"]);
                        ID_Satuan.Add(row["ID_Satuan"]);
                    }
                }
            }

            ((DataGridViewComboBoxColumn)dataGridView1.Columns["Satuan"]).DataSource = CB_Satuan.Items;
        }

        private void loadHistoryPengeluaran()
        {
            //DataTable dt1 = objDAL.getHPengeluaran();
            //DataTable dt2 = objDAL.getDPengeluaran();
            DGV_HistoryPengeluaran.DataSource = objDAL.getHPengeluaran();

            DGV_HistoryPengeluaran.Columns[3].Visible = false;
            DGV_HistoryPengeluaran.Columns[4].Visible = false;

            DGV_HistoryPengeluaran.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            DGV_HistoryPengeluaran.Columns[2].DefaultCellStyle.Format = "C0";
            DGV_HistoryPengeluaran.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");

            



        }

        private void DGV_HistoryPengeluaran_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_HistoryPengeluaran.SelectedRows)
            {
                DGV_DetailHistoryPengeluaran.DataSource = objDAL.getDPengeluaran(int.Parse(row.Cells[0].Value.ToString()));
                DGV_DetailHistoryPengeluaran.Columns[0].Visible = false;
                DGV_DetailHistoryPengeluaran.Columns[1].Visible = false;
                DGV_DetailHistoryPengeluaran.Columns[7].Visible = false;
                DGV_DetailHistoryPengeluaran.Columns[8].Visible = false;


                DGV_DetailHistoryPengeluaran.Columns[5].DefaultCellStyle.Format = "C0";
                DGV_DetailHistoryPengeluaran.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");

                DGV_DetailHistoryPengeluaran.Columns[6].DefaultCellStyle.Format = "C0";
                DGV_DetailHistoryPengeluaran.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");
            }

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int jumlah, harga;
            sum = 0;
            if(dataGridView1.Rows[e.RowIndex].Cells["Jumlah"].Value != null && dataGridView1.Rows[e.RowIndex].Cells["Harga_Satuan"].Value != null)
            {
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Jumlah"].Value.ToString(), out jumlah) && int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Harga_Satuan"].Value.ToString(), out harga))
                {
                    int price = jumlah * harga;
                    dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = price.ToString();
                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            Lbl_Total.Text = string.Format(CultureInfo.CreateSpecificCulture("id"), "{0:C0}", int.Parse(sum.ToString()));

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void BTN_TambahSatuan_Click(object sender, EventArgs e)
        {
            if (objDAL.InsertSatuan(TB_Satuan.Text)) {
                loadsatuan();
                MessageBox.Show("Berhasil Menambah Satuan!");
                TB_Satuan.Text = "";
            } 
            else MessageBox.Show("Gagal Menambah Satuan!");
        }

        private void BTN_HapusSatuan_Click(object sender, EventArgs e)
        {
            int tmpSelectedIndex = CB_Satuan.SelectedIndex;

            if (objDAL.HapusSatuan(int.Parse(ID_Satuan[tmpSelectedIndex].ToString())))
            {
                loadsatuan();
                MessageBox.Show("Berhasil Menghapus Satuan!");
                CB_Satuan.ResetText();
            }
            else MessageBox.Show("Gagal Menghapus Satuan!");
        }

        private void TB_Satuan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_TambahSatuan_Click(this, new EventArgs());
            }
        }

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 1 || dataGridView1.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }

            if (e.Control is DataGridViewTextBoxEditingControl tbc)
            {
                tbc.KeyDown -= DataGridView1_KeyDown;
                tbc.KeyDown += DataGridView1_KeyDown;
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Delete))
            {
                //foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                //{
                //    dataGridView1.Rows.RemoveAt(item.Index);
                //}
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        MessageBox.Show("Baris dihapus!");
                    }
                }

            }
        }

        private void Btn_Selesai_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Simpan_Click(object sender, EventArgs e)
        {
            bool tmp_Null = false;
            string tmp_Waktu = DateTime.Now.ToString("HH:mm:ss");

            DateTime tmp_dari = Convert.ToDateTime(DTP_Tanggal.Text);

            string tmp_Tanggal = tmp_dari.ToString("yyyy-MM-dd") +" "+ tmp_Waktu;

            if (dataGridView1.Rows.Count == 1)
            {
                Lbl_Err.Visible = true;
                Lbl_Err.Text = "Isi data!";
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {
                            tmp_Null = true;
                            break;
                        }
                    }
                }
                if (tmp_Null == true)
                {
                    Lbl_Err.Visible = true;
                    Lbl_Err.Text = "Lengkapi Kolom!";
                }
                else
                {
                    if (objDAL.InsertPengeluaran(sum, tmp_Tanggal))
                    {
                        generateinvoiceID();
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            if (objDAL.InsertDetailPengeluaran(tmp_LastInvoiceID, dataGridView1.Rows[i].Cells[0].Value.ToString(), int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()), dataGridView1.Rows[i].Cells[2].Value.ToString(), int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()), int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()))) ;
                           
                        }

                        Lbl_Err.Visible = true;
                        Lbl_Err.Text = "Berhasil menambahkan pengeluaran!";
                        //loadHistoryPengeluaran();
                        //Btn_CariHistory_Click(this, new EventArgs());
                        sum = 0;
                        Lbl_Total.Text = sum.ToString();
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                    }

                    
                }
            }
            
        }

        public void generateinvoiceID()
        {
            ClassDAL objdal = new ClassDAL();
            objdal.getIDPengeluaran();
            tmp_LastInvoiceID = objdal.lastIDPengeluaran;
        }

        private void BTN_TambahSatuan_Click_1(object sender, EventArgs e)
        {
            if (objDAL.InsertSatuan(TB_Satuan.Text))
            {
                loadsatuan();
                MessageBox.Show("Berhasil Menambah Satuan!");
                TB_Satuan.Text = "";
            }
            else MessageBox.Show("Gagal Menambah Satuan!");
        }

        private void BTN_HapusSatuan_Click_1(object sender, EventArgs e)
        {
            int tmpSelectedIndex = CB_Satuan.SelectedIndex;

            if (objDAL.HapusSatuan(int.Parse(ID_Satuan[tmpSelectedIndex].ToString())))
            {
                loadsatuan();
                MessageBox.Show("Berhasil Menghapus Satuan!");
                CB_Satuan.ResetText();
            }
            else MessageBox.Show("Gagal Menghapus Satuan!");
        }

        private void DGV_DetailHistoryPengeluaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_HistoryPengeluaran_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tmpselectionidx = e.RowIndex;
            tmpSelectedIDPengeluaran = int.Parse(DGV_HistoryPengeluaran.Rows[e.RowIndex].Cells["ID_Pengeluaran"].Value.ToString());
            tmpTanggalSelectedPengeluaran = DGV_HistoryPengeluaran.Rows[e.RowIndex].Cells["Tanggal_Pengeluaran"].Value.ToString();
            sumSelectedPengeluaran = int.Parse(DGV_HistoryPengeluaran.Rows[e.RowIndex].Cells["Grand_Total_History"].Value.ToString());

            //MessageBox.Show(tmpSelectedIDPengeluaran.ToString());
        }

        private void DGV_DetailHistoryPengeluaran_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int jumlah, harga;
            sum = 0;
            if (DGV_DetailHistoryPengeluaran.Rows[e.RowIndex].Cells["Jumlah_History"].Value != null && DGV_DetailHistoryPengeluaran.Rows[e.RowIndex].Cells["Harga_Satuan_History"].Value != null)
            {
                if (int.TryParse(DGV_DetailHistoryPengeluaran.Rows[e.RowIndex].Cells["Jumlah_History"].Value.ToString(), out jumlah) && int.TryParse(DGV_DetailHistoryPengeluaran.Rows[e.RowIndex].Cells["Harga_Satuan_History"].Value.ToString(), out harga))
                {
                    int price = jumlah * harga;
                    DGV_DetailHistoryPengeluaran.Rows[e.RowIndex].Cells["Total_History"].Value = price.ToString();
                }
            }

            for (int i = 0; i < DGV_DetailHistoryPengeluaran.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(DGV_DetailHistoryPengeluaran.Rows[i].Cells["Total_History"].Value);
            }
            DGV_HistoryPengeluaran.Rows[tmpselectionidx].Cells["Grand_Total_History"].Value = sum.ToString();

            lbl_Peringatan.Visible = true;
            lbl_Peringatan2.Visible = true;
            DGV_HistoryPengeluaran.Enabled = false;
        }

        private void Btn_Edit_Click_1(object sender, EventArgs e)
        {
            lbl_Peringatan.Visible = false;
            lbl_Peringatan2.Visible = true;
            DGV_HistoryPengeluaran.Enabled = true;

            //string tmp_Waktu = DateTime.Now.ToString("HH:mm:ss");


            string tmp_Tanggal = DGV_HistoryPengeluaran.Rows[tmpselectionidx].Cells["Tanggal_Pengeluaran"].Value.ToString();
            DateTime MyTanggal = Convert.ToDateTime(tmp_Tanggal);


            tmpTanggalSelectedPengeluaran = MyTanggal.ToString("yyyy-MM-dd HH:mm:ss");


            sumSelectedPengeluaran = int.Parse(DGV_HistoryPengeluaran.Rows[tmpselectionidx].Cells["Grand_Total_History"].Value.ToString());
            //MessageBox.Show(sumSelectedPengeluaran.ToString());
            //MessageBox.Show(tmpTanggalSelectedPengeluaran.ToString());

            if (objDAL.UpdateHPengeluaran(tmpSelectedIDPengeluaran, tmpTanggalSelectedPengeluaran, sumSelectedPengeluaran))
            {
                //MessageBox.Show(DGV_DetailHistoryPengeluaran.Rows.Count.ToString());
                for (int i = 0; i < DGV_DetailHistoryPengeluaran.Rows.Count; i++)
                {
                    if (objDAL.UpdateDPengeluaran(int.Parse(DGV_DetailHistoryPengeluaran.Rows[i].Cells["ID_DPengeluaran"].Value.ToString()),
                                                  DGV_DetailHistoryPengeluaran.Rows[i].Cells["Nama_Produk_History"].Value.ToString(),
                                                  int.Parse(DGV_DetailHistoryPengeluaran.Rows[i].Cells["Jumlah_History"].Value.ToString()),
                                                  DGV_DetailHistoryPengeluaran.Rows[i].Cells["Satuan_History"].Value.ToString(),
                                                  int.Parse(DGV_DetailHistoryPengeluaran.Rows[i].Cells["Harga_Satuan_History"].Value.ToString()),
                                                  int.Parse(DGV_DetailHistoryPengeluaran.Rows[i].Cells["Total_History"].Value.ToString()))) ;

                }
                MessageBox.Show("Berhasil Edit Pengeluaran!");

                //loadHistoryPengeluaran();
                Btn_CariHistory_Click(this, new EventArgs());

                sum = 0;
                Lbl_Total.Text = sum.ToString();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }

        }

        private void DGV_HistoryPengeluaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_BatalEdit_Click_1(object sender, EventArgs e)
        {
            //loadHistoryPengeluaran();
            Btn_CariHistory_Click(this, new EventArgs());

            DGV_HistoryPengeluaran.Enabled = true;
            lbl_Peringatan.Visible = false;
        }

        private void Btn_CariHistory_Click(object sender, EventArgs e)
        {
            DateTime tmp_dari = Convert.ToDateTime(DTP_Dari.Text);
            DateTime tmp_sampai = Convert.ToDateTime(DTP_Sampai.Text);

            string dari = tmp_dari.ToString("yyyy-MM-dd") + " 00:00:00";
            string sampai = tmp_sampai.ToString("yyyy-MM-dd") + " 23:59:00";

            DGV_HistoryPengeluaran.DataSource = objDAL.SelectTanggalHistory(dari, sampai);


            DGV_HistoryPengeluaran.Columns[3].Visible = false;
            DGV_HistoryPengeluaran.Columns[4].Visible = false;

            DGV_HistoryPengeluaran.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            DGV_HistoryPengeluaran.Columns[2].DefaultCellStyle.Format = "C0";
            DGV_HistoryPengeluaran.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id");
        }

        private void BTN_Hapus_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Hapus pengeluaran?", "KONFIRMASI", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (objDAL.HapusHPengeluaran(tmpSelectedIDPengeluaran))
                {
                    if (objDAL.HapusDPengeluaran(tmpSelectedIDPengeluaran))
                    {
                        Btn_CariHistory_Click(this, new EventArgs());
                        MessageBox.Show("Berhasil menghapus pengeluaran!");
                    }
                }
            }

               

        }

        private void DataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        
    }
}
