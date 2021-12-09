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
    public partial class Cetak : UserControl
    {
        List<DaftarMakanan> namamakanan = new List<DaftarMakanan>();
        public Cetak()
        {
            InitializeComponent();
        }

        private void Cetak_Load(object sender, EventArgs e)
        {
            //DataAccess db = new DataAccess();
            //namamakanan = db.GetDaftarMenus();

            //dataGridView1.DataSource = namamakanan;
        }
    }
}
