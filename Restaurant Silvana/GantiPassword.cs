using Restaurant_Silvana.BLL;
using Restaurant_Silvana.DAL;
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
    public partial class GantiPassword : Form
    {
        public GantiPassword()
        {
            InitializeComponent();
        }

        bool terdaftar = false;
        bool validasipassword = false;
        string loggeduser;
        string tmp_Password;

        private void Btn_Konfirmasi_Click(object sender, EventArgs e)
        {
            terdaftar = false;
            validasipassword = false;


            string tmppasswordSebelumnya = tb_PasswordSaatIni.Text;
            var calculateHash = EasyEncryption.MD5.ComputeMD5Hash(tmppasswordSebelumnya);
            var passwordbaru = EasyEncryption.MD5.ComputeMD5Hash(tb_password.Text);
            ClassDAL objDAL = new ClassDAL();

            objDAL.GetUserPassword(loggeduser);

            tmp_Password = objDAL.tmp_passwordLoggedUser;


            if (calculateHash == tmp_Password)
            {
                if(tb_password.Text == tb_ulangipassword.Text)
                {
                    if(objDAL.UpdatePassword(loggeduser, passwordbaru))
                    {
                        lbl_err.Visible = true;
                        lbl_err.ForeColor = Color.Green;
                        lbl_err.Text = "Berhasil ganti password!";
                    }
                    else
                    {
                        lbl_err.Visible = true;
                        lbl_err.ForeColor = Color.Red;

                        lbl_err.Text = "Gagal ganti password!";
                    }
                    
                }
                else
                {
                    lbl_err.Visible = true;
                    lbl_err.ForeColor = Color.Red;

                    lbl_err.Text = "Konfirmasi Password salah!";
                }
            }
            else
            {
                lbl_err.Visible = true;
                lbl_err.ForeColor = Color.Red;

                lbl_err.Text = "Password salah!";

            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GantiPassword_Load(object sender, EventArgs e)
        {
            loggeduser = Login.loggeduser;
        }

        private void Btn_dismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Tb_PasswordSaatIni_TextChanged(object sender, EventArgs e)
        {

        }
        private void Tb_PasswordSaatIni_Enter(object sender, EventArgs e)
        {
            if (tb_PasswordSaatIni.Text == "Password Saat ini")
            {
                tb_PasswordSaatIni.ForeColor = Color.Black;
                tb_PasswordSaatIni.Text = "";
                tb_PasswordSaatIni.PasswordChar = '*';
            }
        }
        private void Tb_PasswordSaatIni_Leave(object sender, EventArgs e)
        {
            if (tb_PasswordSaatIni.Text == "")
            {
                tb_PasswordSaatIni.ForeColor = Color.Silver;
                tb_PasswordSaatIni.Text = "Password Saat ini";
                tb_PasswordSaatIni.PasswordChar = '\0';
            }
        }

        private void Tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "Password Baru")
            {
                tb_password.ForeColor = Color.Black;
                tb_password.Text = "";
                tb_password.PasswordChar = '*';
            }
        }

        private void Tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.ForeColor = Color.Silver;
                tb_password.Text = "Password Baru";
                tb_password.PasswordChar = '\0';
            }
        }

        private void Tb_ulangipassword_Enter(object sender, EventArgs e)
        {
            if (tb_ulangipassword.Text == "Ulangi Password")
            {
                tb_ulangipassword.ForeColor = Color.Black;
                tb_ulangipassword.Text = "";
                tb_ulangipassword.PasswordChar = '*';
            }
        }

        private void Tb_ulangipassword_Leave(object sender, EventArgs e)
        {
            if (tb_ulangipassword.Text == "")
            {
                tb_ulangipassword.ForeColor = Color.Silver;
                tb_ulangipassword.Text = "Ulangi Password";
                tb_ulangipassword.PasswordChar = '\0';
            }
        }
    }
}
