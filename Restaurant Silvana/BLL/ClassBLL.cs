using Restaurant_Silvana.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Silvana.BLL
{
    class ClassBLL
    {
        public bool saveItems(string nama_makanan, string harga_makanan, Image img, int category)
        {
            //0=makanan; 1=minuman; 2=snack
            
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.AddItemstoTable(nama_makanan, harga_makanan, img, category);
            }
            catch (Exception e)
            {
                //DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
            

        }

        public bool UpdateItems(string nama_makanan, string harga_makanan, Image img, int category, int id)
        {
            //0=makanan; 1=minuman; 2=snack

            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.UpdateItems(nama_makanan, harga_makanan, img, category, id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }


        }

        public bool DeleteItems(int id)
        {
            //0=makanan; 1=minuman; 2=snack

            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.DeleteItems(id);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }


        }

        public bool AddUser(string username, string password)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.SaveUsertoDatabase(username, password);
            }
            catch (Exception e)
            {
                //DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool TambahPesananHTRANS(string tanggal, string tipe_pembayaran, float discount, int grandtotal, int grandtotal_ppn ,string nama_kasir, int nomor_meja, int mejaaktif, int bayar)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.addtoHTRANS(tanggal, tipe_pembayaran, discount, grandtotal, grandtotal_ppn, nama_kasir, nomor_meja, mejaaktif, bayar);
            }
            catch (Exception e)
            {
                //DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool TambahPesananDTRANS(int invoiceID, int nomormeja, int ID_makanan, string nama_makanan, int quantity, int harga_makanan, float discountper, int total_amount)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.addtoDTRANS(invoiceID, nomormeja, ID_makanan, nama_makanan, quantity, harga_makanan, discountper, total_amount);
            }
            catch (Exception e)
            {
                //DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool TambahkanMejaAktif(int invoiceid, int nomormeja)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.addToMejaAktif(invoiceid, nomormeja);
            }
            catch (Exception e)
            {
                //DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool UpdateDtrans(int ID_Dtrans, int InvoiceID, int quantity, int total_amount)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.UpdateDTransMejaAktif(ID_Dtrans, InvoiceID, quantity, total_amount);
            }
            catch (Exception e)
            {
                //DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable GetItems(int category)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadItemsTable(category);
            }
            catch(Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable GetItemsSearch(string keywords)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadItemsTableSearch(keywords);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable GetUser()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadUsers();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable GetMejaAktif()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadMejaAktif();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.StackTrace.ToString());
                return null;
            }
        }

        public DataTable GetDtrans(int InvoiceID)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadDtrans(InvoiceID);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable GetHtrans(int InvoiceID)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadHtrans(InvoiceID);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable GetNotaDapur(int InvoiceID)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.GetNotaDapur(InvoiceID);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

    }
}
