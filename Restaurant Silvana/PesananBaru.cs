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
    public partial class PesananBaru : UserControl
    {
        List<DaftarMakanan> makanan = new List<DaftarMakanan>();
        List<DaftarMinuman> minuman = new List<DaftarMinuman>();
        public PesananBaru()
        {
            InitializeComponent();
            
        }

        private void PesananBaru_Load(object sender, EventArgs e)
        {

        }

        

       
        private void UpdateBinding()
        {
            DataAccess db = new DataAccess();
            DataAccess db2 = new DataAccess();

            makanan = db.GetDaftarMakanan();

            minuman = db2.GetDaftarMinuman();

            //dgfMakanan.DataSource = makanan;
            //dgfMinuman.DataSource = minuman;


        }

        private void PesananBaru_Enter(object sender, EventArgs e)
        {
            
        }

        private void PesananBaru_StyleChanged(object sender, EventArgs e)
        {
            
        }

        private void PesananBaru_ChangeUICues(object sender, UICuesEventArgs e)
        {
            UpdateBinding();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
