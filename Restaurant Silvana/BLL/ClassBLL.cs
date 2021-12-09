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
                DialogResult result = MessageBox.Show(e.Message.ToString());
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
    }
}
