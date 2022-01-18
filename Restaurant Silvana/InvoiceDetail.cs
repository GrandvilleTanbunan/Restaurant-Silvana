using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Silvana
{
    class InvoiceDetail
    {
        
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Harga_Barang { get; set; }
        public string Quantity { get; set; }
        public string Amount { get; set; }
        public string Discountper { get; set; }
        public int totalamount { get; set; }


    }
}
