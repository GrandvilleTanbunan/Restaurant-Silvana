using Restaurant_Silvana.BLL;
using System;
using System.Collections;
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
    public partial class Registrasi : Form
    {
        public Registrasi()
        {
            InitializeComponent();
        }

        bool terdaftar = false;
        ArrayList username = new ArrayList();


        private void btn_dismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Placeholder
        private void tb_username_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_username.Text == "username")
            {
                tb_username.ForeColor = Color.Black;
                tb_username.Text = "";
            }
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.ForeColor = Color.Silver;

                tb_username.Text = "username";
            }
        }

        private void tb_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_password.Text == "Password")
            {
                tb_password.ForeColor = Color.Black;

                tb_password.Text = "";
                tb_password.PasswordChar = '*';
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.ForeColor = Color.Silver;

                tb_password.Text = "Password";
                tb_password.PasswordChar = '\0';
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "Password")
            {
                tb_password.ForeColor = Color.Black;

                tb_password.Text = "";
                tb_password.PasswordChar = '*';
            }
        }

        private void tb_ulangipassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_ulangipassword.Text == "Ulangi Password")
            {
                tb_ulangipassword.ForeColor = Color.Black;

                tb_ulangipassword.Text = "";
                tb_ulangipassword.PasswordChar = '*';
            }
        }

        private void tb_ulangipassword_Leave(object sender, EventArgs e)
        {
            if (tb_ulangipassword.Text == "")
            {
                tb_ulangipassword.ForeColor = Color.Silver;

                tb_ulangipassword.Text = "Ulangi Password";
                tb_ulangipassword.PasswordChar = '\0';

            }
        }

        private void tb_ulangipassword_Enter(object sender, EventArgs e)
        {
            if (tb_ulangipassword.Text == "Ulangi Password")
            {
                tb_ulangipassword.ForeColor = Color.Black;

                tb_ulangipassword.Text = "";
                tb_ulangipassword.PasswordChar = '*';
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            if (tb_password.Text == tb_ulangipassword.Text)
            {
                registrasi();
            }
            else
            {
                lbl_err.Visible = true;
                lbl_err.Text = "Konfirmasi password tidak cocok!";
            }
        }

        public void registrasi()
        {
            string tmppassword = tb_password.Text;
            var calculateHash = EasyEncryption.MD5.ComputeMD5Hash(tmppassword);

            terdaftar = false;
            username.Clear();

            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.GetUser();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        username.Add(row["username"]);
                    }
                }
            }

            for (int i = 0; i < username.Count; i++)
            {
                if (tb_username.Text == username[i].ToString())
                {
                    terdaftar = true;
                }
            }

            if(terdaftar == true)
            {
                lbl_err.Visible = true;
                lbl_err.Text = "Username sudah terdaftar!";
            }
            else
            {
                if (objbll.AddUser(tb_username.Text, calculateHash))
                {
                    MessageBox.Show("Registrasi Berhasil!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registrasi Gagal!!");

                }
            }

            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Tb_ulangipassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_err_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
