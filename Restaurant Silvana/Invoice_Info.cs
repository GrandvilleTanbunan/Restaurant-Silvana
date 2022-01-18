using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Silvana
{
    class Invoice_Info
    {
        public string Invoice_date { get; set; }
        public string Payment_type { get; set; }
        public string Discount { get; set; }
        public string Grand_Total { get; set; }
        public string Total_paid { get; set; }
        public string Nama_Kasir { get; set; }
        public int Nomor_meja { get; set; }

        public string Remark { get; set; }

    }
}
