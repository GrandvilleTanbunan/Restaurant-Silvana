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
    public partial class PPN : Form
    {
        public PPN()
        {
            InitializeComponent();
        }
        ClassDAL objDAL = new ClassDAL();

        private void PPN_Load(object sender, EventArgs e)
        {
            ppn();
            tb_PPN.Text = "PPN Baru";
            tb_PPN.ForeColor = Color.Silver;
            
        }

        private void ppn()
        {
            objDAL.getPPN();
            lbl_PPN.Text = objDAL.ppn.ToString() + "%";
        }

        private void Btn_dismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_PPN_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Tb_PPN_Enter(object sender, EventArgs e)
        {
            if (tb_PPN.Text == "PPN Baru")
            {
                tb_PPN.Text = "";
                tb_PPN.ForeColor = Color.Black;

            }
        }
        private void Tb_PPN_Leave(object sender, EventArgs e)
        {
            if(tb_PPN.Text == "")
            {
                tb_PPN.Text = "PPN Baru";
                tb_PPN.ForeColor = Color.Silver;

            }
        }

        private void Tb_PPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Btn_tetapkan_Click(object sender, EventArgs e)
        {
            if(tb_PPN.Text == "" || tb_PPN.Text == "PPN Baru")
            {
                lbl_err.Visible = true;
                lbl_err.Text = "Silahkan masukan nilai PPN terbaru!";
            }
            else
            {
                if (objDAL.UpdatePPN(int.Parse(tb_PPN.Text)))
                {
                    lbl_err.Visible = true;
                    lbl_err.Text = "PPN telah ditetapkan!";
                    lbl_err.ForeColor = Color.Green;
                    ppn();
                }

            }

        }
    }
}
