using Restaurant_Silvana.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Silvana
{
    public partial class TambahMenu : Form
    {
        public TambahMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TambahMenu_Load(object sender, EventArgs e)
        {
            pb_image.Image = Properties.Resources.Upload_Image_2; 
            pb_image.Refresh();
            cb_category.SelectedIndex = 0;

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if(opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pb_image.Image = image; 
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            ClassBLL objbll = new ClassBLL();

            if (objbll.saveItems(tb_nama_makanan.Text, tb_harga.Text, pb_image.Image, cb_category.SelectedIndex))
            {
                MessageBox.Show("Menu baru sudah tersimpan");
            }
            else
            {
                MessageBox.Show("Gagal menyimpan");
            }
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tb_nama_makanan_MouseEnter(object sender, EventArgs e)
        {
        }


        #region Placeholder buatan
        private void tb_nama_makanan_MouseClick(object sender, MouseEventArgs e)
        {
            if(tb_nama_makanan.Text == "Nama Makanan")
            {
                tb_nama_makanan.Text = "";
            }

        }

        private void tb_nama_makanan_Leave(object sender, EventArgs e)
        {
            if (tb_nama_makanan.Text == "")
            {
                tb_nama_makanan.Text = "Nama Makanan";
            }
        }

        private void tb_harga_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_harga.Text == "Harga")
            {
                tb_harga.Text = "";
            }
        }

        private void tb_harga_Leave(object sender, EventArgs e)
        {
            if (tb_harga.Text == "")
            {
                tb_harga.Text = "Harga";
            }
        }

        #endregion 

        private void tb_harga_TextChanged(object sender, EventArgs e)
        {
           
        }

      



        private void tb_nama_makanan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nama_makanan_MouseLeave(object sender, EventArgs e)
        {
            
        }

        #region Textbox hanya terima angka
        private void tb_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
