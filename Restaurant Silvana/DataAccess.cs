using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.IO;
using System.Drawing;

namespace Restaurant_Silvana
{
    public class DataAccess
    {
        public List<DaftarMakanan> GetDaftarMakanan()
        {
            //throw new NotImplementedException();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.makanan("silvana")))
            {
                //var output =  connection.Query<DaftarMenu>("select * from makanan").ToList();
                var outputMakanan = connection.Query<DaftarMakanan>("dbo.sp_getAllMakanan").ToList();
                return outputMakanan;
            }
        }

        public List<DaftarMinuman> GetDaftarMinuman()
        {
            //throw new NotImplementedException();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.makanan("silvana")))
            {
                //var output =  connection.Query<DaftarMenu>("select * from makanan").ToList();
                var outputMinuman = connection.Query<DaftarMinuman>("dbo.sp_getAllMinuman").ToList();
                return outputMinuman;
            }
        }

        public void InsertMakanan(string nama_makanan, int harga_makanan, Image gambar_makanan)
        {
            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.makanan("silvana")))
            //{
            //    //var output =  connection.Query<DaftarMenu>("select * from makanan").ToList();

            //    MemoryStream ms = new MemoryStream();
            //    gambar_makanan.Save(ms, gambar_makanan.RawFormat);


            //    List<DaftarMakanan> makanan = new List<DaftarMakanan>();

            //    makanan.Add(new DaftarMakanan { nama_makanan = nama_makanan, harga_makanan = harga_makanan, gambar_makanan = ms.ToArray() });

            //    connection.Execute("sp_InsertMakanan @nama_makanan, @harga_makanan, @gambar_makanan", makanan);
            //}
        }

        
    }
}
