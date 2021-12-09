using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Silvana.DAL
{
    class ClassDAL
    {


        string query;
        public bool AddItemstoTable(string nama, string harga, Image img, int category)
        {
            Connection con = new Connection();
            if(ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            //if(category == 0)
            //{
                query = "INSERT INTO makanan(nama_makanan,harga_makanan, gambar_makanan, category_makanan) Values(@nama, @harga, @gambar, @category)";

            //}
            //else if(category == 1)
            //{
            //    query = "INSERT INTO minuman(nama_minuman,harga_minuman, gambar_minuman, category_minuman) Values(@nama, @harga, @gambar, @category)";

            //}

            //else
            //{
            //    query = "INSERT INTO snack(nama_snack,harga_snack, gambar_snack, category_snack) Values(@nama, @harga, @gambar, @category)";

            //}


            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@nama", nama.Trim());
                    cmd.Parameters.AddWithValue("@harga", harga.Trim());
                    cmd.Parameters.AddWithValue("@category", category);

                   
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    cmd.Parameters.AddWithValue("@gambar", ms.ToArray());

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Masuk catch additemstotable");
                throw;
            }
        }

        public DataTable ReadItemsTable(int category)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM makanan";
            
            SqlCommand cmd = new SqlCommand(query, con.connect);

            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }

            }

            catch
            {
                throw;
            }
        }
    }
}
