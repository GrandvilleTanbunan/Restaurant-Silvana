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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ArrayList username = new ArrayList();
        ArrayList password = new ArrayList();
        bool terdaftar = false;
        bool validasipassword = false;

        public static string loggeduser;

        private void btn_dismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registrasi reg = new Registrasi();
            reg.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            reg.Show();

        }

        #region PLACECHOLDER
        private void tb_username_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_username.Text == "username")
            {
                tb_username.Text = "";
            }
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "username";
            }
        }

        private void tb_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_password.Text == "Password")
            {
                tb_password.Text = "";
                tb_password.PasswordChar = '*';
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "Password";
                tb_password.PasswordChar = '\0';

            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "Password")
            {
                tb_password.Text = "";
                tb_password.PasswordChar = '*';
            }
        }

        #endregion

        private void btn_login_Click(object sender, EventArgs e)
        {
            terdaftar = false;
            validasipassword = false;
            username.Clear();
            password.Clear();

            string tmppassword = tb_password.Text;
            var calculateHash = EasyEncryption.MD5.ComputeMD5Hash(tmppassword);

            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.GetUser();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        username.Add(row["username"]);
                        password.Add(row["password"]);
                    }
                }
            }

            for (int i = 0; i < username.Count; i++)
            {
                if(tb_username.Text == username[i].ToString())
                {
                    terdaftar = true;
                    if (calculateHash == password[i].ToString())
                    {
                        loggeduser = username[i].ToString();
                        validasipassword = true;
                    }
                    else
                    {
                        validasipassword = false;
                    }
                }
            }

            if (terdaftar == true)
            {
                if(validasipassword == true)
                {
                    lbl_err.Visible = true;
                    lbl_err.Text = "Login Berhasil!";


                    this.Hide();
                    Main main = new Main();
                    main.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                    main.Show();
                }
                else
                {
                    lbl_err.Visible = true;
                    lbl_err.Text = "Password Salah!";
                    terdaftar = false;

                }
            }
            else
            {
                lbl_err.Visible = true;
                lbl_err.Text = "Username tidak terdaftar!";
            }


        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            tb_password.Text = "Password";
            tb_username.Text = "username";
            tb_password.PasswordChar = '\0';

            lbl_err.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
