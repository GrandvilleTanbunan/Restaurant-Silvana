using MySql.Data.MySqlClient;
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

        public int lastinsertedid;
        public int lastIDPengeluaran;
        public int tmp_Quantity;
        public int ppn;
        public int tmp_InvoiceIDMejaAktif;
        string query;
        public string tmp_passwordLoggedUser;
        private bool OpenConnection()
        {
            Connection con = new Connection();
            try
            {
                con.connect.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch(ex.Number)
                {
                    case 0: MessageBox.Show("Connection to server Failed!");
                        break;
                    case 1045: MessageBox.Show("Server Username or Password is Incorrect!");
                        break;
                }
                return false;
            }
        }

        public bool AddItemstoTable(string nama, string harga, Image img, int category)
        {
            Connection con = new Connection();
            if(ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "INSERT INTO makanan(nama_makanan,harga_makanan, gambar_makanan, category_makanan) Values(@nama, @harga, @gambar, @category)";

            try
            {

                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@nama", nama.Trim());
                    cmd.Parameters.AddWithValue("@harga", harga.Trim());
                    cmd.Parameters.AddWithValue("@category", category);


                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    byte[] imgs = ms.ToArray();
                    cmd.Parameters.Add("@gambar", MySqlDbType.Blob);
                    cmd.Parameters["@gambar"].Value = imgs;

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch(Exception e)
            {
                con.connect.Close();
                MessageBox.Show("Lengkapi Kolom!");
                MessageBox.Show(e.ToString());

                throw;
            }
        }

        public bool UpdateItems(string nama, string harga, Image img, int category, int id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "UPDATE makanan SET nama_makanan = @nama, harga_makanan = @harga, gambar_makanan = @gambar, category_makanan = @category WHERE ID_makanan = @id; ";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@nama", nama.Trim());
                    cmd.Parameters.AddWithValue("@harga", harga.Trim());
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@id", id);

                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    cmd.Parameters.AddWithValue("@gambar", ms.ToArray());

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Lengkapi Kolom!");
                throw;
            }

        }

        public bool DeleteItems(int id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "DELETE FROM makanan WHERE ID_makanan= @id;";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Gagal Menghapus!");
                throw;
            }
        }

        public bool SaveUsertoDatabase(string username, string password)
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "INSERT INTO users(username, password) Values(@username, @password)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@username", username.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Trim());

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());

                throw;
            }
        }


        public bool addtoHTRANS(string tanggal, string tipe_pembayaran, float discount, int grandtotal, int grandtotal_ppn, string nama_kasir, int nomor_meja, int mejaaktif, int bayar)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "INSERT INTO Htrans(InvoiceDate, Payment_type, discount, Grand_Total, Grand_Total_PPN, Nama_Kasir, Nomor_Meja, MejaAktif, Bayar) Values(@tanggal, @tipe_pembayaran, @discount, @grandtotal, @grandtotal_ppn, @nama_kasir, @nomor_meja, @mejaaktif, @bayar);";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@tanggal", tanggal);
                    cmd.Parameters.AddWithValue("@tipe_pembayaran", tipe_pembayaran.Trim());
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@grandtotal", grandtotal);
                    cmd.Parameters.AddWithValue("@grandtotal_ppn", grandtotal_ppn);
                    cmd.Parameters.AddWithValue("@nama_kasir", nama_kasir);
                    cmd.Parameters.AddWithValue("@nomor_meja", nomor_meja);
                    cmd.Parameters.AddWithValue("@mejaaktif", mejaaktif);
                    cmd.Parameters.AddWithValue("@bayar", bayar);


                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Lengkapi Kolom!");
                throw;
            }
        }

        public bool addtoDTRANS(int InvoiceID, int nomormeja, int ID_makanan, string nama_makanan, int quantity, int harga_makanan, float discountper, int total_amount)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "INSERT INTO Dtrans(InvoiceID, Nomor_Meja, ID_makanan, nama_makanan, Quantity, harga_makanan, Discountper, Total_Amount) Values(@InvoiceID, @Nomormeja, @ID_makanan, @nama_makanan, @quantity, @harga_makanan, @discountper, @total_amount)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                    cmd.Parameters.AddWithValue("@Nomormeja", nomormeja);
                    cmd.Parameters.AddWithValue("@ID_makanan", ID_makanan);
                    cmd.Parameters.AddWithValue("@nama_makanan", nama_makanan.Trim());
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@harga_makanan", harga_makanan);
                    cmd.Parameters.AddWithValue("@discountper", discountper);
                    cmd.Parameters.AddWithValue("@total_amount", total_amount);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show("Gagal Menyimpan Detail!");
                DialogResult result = MessageBox.Show(e.Message.ToString());

                throw;
            }
        }

        public bool UpdateDTransMejaAktif(int ID_Dtrans, int InvoiceID, int quantity, int total_amount)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "UPDATE Dtrans SET Quantity = @quantity, Total_Amount = @totalharga WHERE ID_Dtrans = @ID_Dtrans;";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID_Dtrans", ID_Dtrans);
                    cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@totalharga", total_amount);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show("Gagal Menyimpan Detail!");
                DialogResult result = MessageBox.Show(e.Message.ToString());

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

            query = "SELECT * FROM makanan ORDER BY nama_makanan";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);

            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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
        public DataTable ReadItemsTableSearch(string keywords)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM makanan WHERE nama_makanan LIKE '%" + keywords + "%'";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {

                    cmd.Parameters.AddWithValue("@keywords", keywords);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                    
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }


        }

        public DataTable ReadUsers()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM users";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);

            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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

        public DataTable ReadMejaAktif()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM Htrans WHERE MejaAktif = 1 ORDER BY Nomor_Meja ASC";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);

            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }

            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                throw;
            }
        }


        public DataTable ReadDtrans(int invoiceID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM Dtrans WHERE InvoiceID = @invoiceID";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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

        public DataTable ReadHtransALL()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM Htrans WHERE MejaAktif = 0";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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

        public DataTable ReadHtransWithCondition(int periode, string tanggal, string bulan, string dari, string sampai, string tahun)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            if(periode == 0) //hari ini
            {
                query = "SELECT * from Htrans WHERE InvoiceDate BETWEEN @tanggal1 and @tanggal2 AND MejaAktif = 0";
            }

            else if(periode == 1) // bulan ini
            {
                query = "SELECT SUM(Grand_Total) AS Grand_Total, SUM(Grand_Total_PPN) AS Grand_Total_PPN, DATE(InvoiceDate) AS InvoiceDate FROM htrans WHERE MONTH(InvoiceDate) = @bulan AND YEAR(invoiceDate) = @tahun AND MejaAktif = 0 GROUP BY DATE(invoiceDate)";
            }

            else if (periode == 2 || periode == 4) // tahun ini & pilih Tahun
            {
                query = "SELECT SUM(Grand_Total) AS Grand_Total, SUM(Grand_Total_PPN) AS Grand_Total_PPN, DATE(InvoiceDate) AS InvoiceDate FROM htrans WHERE YEAR(invoiceDate) = @tahun AND MejaAktif = 0 GROUP BY MONTH(invoiceDate);";
            }

            else if (periode == 3) //pilih tanggal
            {
                query = "SELECT SUM(Grand_Total) AS Grand_Total, SUM(Grand_Total_PPN) AS Grand_Total_PPN, DATE(InvoiceDate) AS InvoiceDate FROM htrans WHERE InvoiceDate BETWEEN @dari and @sampai AND MejaAktif = 0 GROUP BY DATE(invoiceDate)";

            }

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    
                    string tanggal1 = tanggal + " 00:00:00";
                    string tanggal2 = tanggal + " 23:59:00";

                    cmd.Parameters.AddWithValue("@tanggal1", tanggal1);
                    cmd.Parameters.AddWithValue("@tanggal2", tanggal2);
                    cmd.Parameters.AddWithValue("@bulan", bulan);
                    cmd.Parameters.AddWithValue("@tahun", tahun);
                    cmd.Parameters.AddWithValue("@dari", dari);
                    cmd.Parameters.AddWithValue("@sampai", sampai);


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

        public DataTable ReadHPengeluaranWithCondition(int periode, string tanggal, string bulan, string dari, string sampai, string tahun)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            if (periode == 0) //hari ini
            {
                query = "SELECT * from hpengeluaran WHERE Tanggal_Pengeluaran BETWEEN @tanggal1 and @tanggal2";
            }

            else if (periode == 1) // bulan ini
            {
                query = "SELECT SUM(Grand_Total_Pengeluaran) AS Grand_Total_Pengeluaran, DATE(Tanggal_Pengeluaran) AS Tanggal_Pengeluaran FROM hpengeluaran WHERE MONTH(Tanggal_Pengeluaran) = @bulan AND YEAR(Tanggal_Pengeluaran) = @tahun GROUP BY DATE(Tanggal_Pengeluaran)";
            }

            else if (periode == 2 || periode == 4) // tahun ini & pilih Tahun
            {
                query = "SELECT SUM(Grand_Total_Pengeluaran) AS Grand_Total_Pengeluaran, DATE(Tanggal_Pengeluaran) AS Tanggal_Pengeluaran FROM hpengeluaran WHERE YEAR(Tanggal_Pengeluaran) = @tahun GROUP BY MONTH(Tanggal_Pengeluaran);";
            }

            else if (periode == 3) //pilih tanggal
            {
                query = "SELECT SUM(Grand_Total_Pengeluaran) AS Grand_Total_Pengeluaran, DATE(Tanggal_Pengeluaran) AS Tanggal_Pengeluaran FROM hpengeluaran WHERE Tanggal_Pengeluaran BETWEEN @dari and @sampai GROUP BY DATE(Tanggal_Pengeluaran)";

            }

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {

                    string tanggal1 = tanggal + " 00:00:00";
                    string tanggal2 = tanggal + " 23:59:00";

                    cmd.Parameters.AddWithValue("@tanggal1", tanggal1);
                    cmd.Parameters.AddWithValue("@tanggal2", tanggal2);
                    cmd.Parameters.AddWithValue("@bulan", bulan);
                    cmd.Parameters.AddWithValue("@tahun", tahun);
                    cmd.Parameters.AddWithValue("@dari", dari);
                    cmd.Parameters.AddWithValue("@sampai", sampai);


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

        public DataTable ReadSumHPengeluaran(int periode, string tanggal, string bulan, string dari, string sampai, string tahun)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            if (periode == 0) //hari ini
            {
                query = "SELECT SUM(Grand_Total_Pengeluaran) AS Grand_Total_Pengeluaran, DATE(Tanggal_Pengeluaran) AS Tanggal_Pengeluaran FROM hpengeluaran  WHERE Tanggal_Pengeluaran BETWEEN @tanggal1 and @tanggal2 GROUP BY DATE(Tanggal_Pengeluaran)";
            }

            //else if (periode == 1) // bulan ini
            //{
            //    query = "SELECT SUM(Grand_Total_Pengeluaran) AS Grand_Total_Pengeluaran, DATE(Tanggal_Pengeluaran) AS Tanggal_Pengeluaran FROM hpengeluaran WHERE MONTH(Tanggal_Pengeluaran) = @bulan AND YEAR(Tanggal_Pengeluaran) = @tahun GROUP BY DATE(Tanggal_Pengeluaran)";
            //}

            //else if (periode == 2 || periode == 4) // tahun ini & pilih Tahun
            //{
            //    query = "SELECT SUM(Grand_Total_Pengeluaran) AS Grand_Total_Pengeluaran, DATE(Tanggal_Pengeluaran) AS Tanggal_Pengeluaran FROM hpengeluaran WHERE YEAR(Tanggal_Pengeluaran) = @tahun GROUP BY MONTH(Tanggal_Pengeluaran);";
            //}

            //else if (periode == 3) //pilih tanggal
            //{
            //    query = "SELECT SUM(Grand_Total_Pengeluaran) AS Grand_Total_Pengeluaran, DATE(Tanggal_Pengeluaran) AS Tanggal_Pengeluaran FROM hpengeluaran WHERE Tanggal_Pengeluaran BETWEEN @dari and @sampai GROUP BY DATE(Tanggal_Pengeluaran)";

            //}

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {

                    string tanggal1 = tanggal + " 00:00:00";
                    string tanggal2 = tanggal + " 23:59:00";

                    cmd.Parameters.AddWithValue("@tanggal1", tanggal1);
                    cmd.Parameters.AddWithValue("@tanggal2", tanggal2);
                    cmd.Parameters.AddWithValue("@bulan", bulan);
                    cmd.Parameters.AddWithValue("@tahun", tahun);
                    cmd.Parameters.AddWithValue("@dari", dari);
                    cmd.Parameters.AddWithValue("@sampai", sampai);


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

        public DataTable ReadSumHtrans(int periode, string tanggal, string bulan, string dari, string sampai, string tahun)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            if (periode == 0) //hari ini
            {
                query = "SELECT SUM(Grand_Total) AS Grand_Total, DATE(InvoiceDate) AS InvoiceDate FROM htrans WHERE InvoiceDate BETWEEN @tanggal1 and @tanggal2 AND MejaAktif = 0 GROUP BY DATE(invoiceDate)";
            }

            //else if (periode == 1) // bulan ini
            //{
            //    query = "SELECT SUM(Grand_Total) AS Grand_Total, SUM(Grand_Total_PPN) AS Grand_Total_PPN, DATE(InvoiceDate) AS InvoiceDate FROM htrans WHERE MONTH(InvoiceDate) = @bulan AND YEAR(invoiceDate) = @tahun AND MejaAktif = 0 GROUP BY DATE(invoiceDate)";
            //}

            //else if (periode == 2 || periode == 4) // tahun ini & pilih Tahun
            //{
            //    query = "SELECT SUM(Grand_Total) AS Grand_Total, SUM(Grand_Total_PPN) AS Grand_Total_PPN, DATE(InvoiceDate) AS InvoiceDate FROM htrans WHERE YEAR(invoiceDate) = @tahun AND MejaAktif = 0 GROUP BY MONTH(invoiceDate);";
            //}

            //else if (periode == 3) //pilih tanggal
            //{
            //    query = "SELECT SUM(Grand_Total) AS Grand_Total, SUM(Grand_Total_PPN) AS Grand_Total_PPN, DATE(InvoiceDate) AS InvoiceDate FROM htrans WHERE InvoiceDate BETWEEN @dari and @sampai AND MejaAktif = 0 GROUP BY DATE(invoiceDate)";

            //}

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {

                    string tanggal1 = tanggal + " 00:00:00";
                    string tanggal2 = tanggal + " 23:59:00";

                    cmd.Parameters.AddWithValue("@tanggal1", tanggal1);
                    cmd.Parameters.AddWithValue("@tanggal2", tanggal2);
                    cmd.Parameters.AddWithValue("@bulan", bulan);
                    cmd.Parameters.AddWithValue("@tahun", tahun);
                    cmd.Parameters.AddWithValue("@dari", dari);
                    cmd.Parameters.AddWithValue("@sampai", sampai);


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



        public DataTable ReadDtransALL()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM Dtrans";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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

        public DataTable ReadHtrans(int invoiceID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM Htrans WHERE InvoiceID = @invoiceID";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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
        public void getInvoiceID()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT MAX(InvoiceID) FROM Htrans";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);

            lastinsertedid = (int)cmd.ExecuteScalar();

        }

        public void getQuantity(int ID_Dtrans)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT Quantity FROM Dtrans WHERE ID_Dtrans = @ID_Dtrans";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@ID_Dtrans", ID_Dtrans);


            tmp_Quantity = (int)cmd.ExecuteScalar();
        }

        public void UpdatePesanan(int quantitybaru, int id_dtrans, int totalharga)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "UPDATE Dtrans SET Quantity = @quantity, Total_Amount = @totalharga WHERE ID_Dtrans = @id_dtrans; ";


            using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
            {
                cmd.Parameters.AddWithValue("@quantity", quantitybaru);
                cmd.Parameters.AddWithValue("@id_dtrans", id_dtrans);
                cmd.Parameters.AddWithValue("@totalharga", totalharga);


                cmd.ExecuteNonQuery();
            }

        }

        public void UpdateGrandTotalHTrans(int invoiceID, int grand_total)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "UPDATE Htrans SET Grand_Total = @grand_total WHERE invoiceID = @invoiceID; ";


            using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
            {
                cmd.Parameters.AddWithValue("@grand_total", grand_total);
                cmd.Parameters.AddWithValue("@invoiceID", invoiceID);


                cmd.ExecuteNonQuery();
            }
        }

        public void getInvoiceIDMejaAktif(int nomor_meja)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT InvoiceID FROM Htrans WHERE MejaAktif = 1 and Nomor_Meja = @nomor_meja";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@nomor_meja", nomor_meja);


            tmp_InvoiceIDMejaAktif = (int)cmd.ExecuteScalar();

        }

        public void HapusDtrans(int ID_Dtrans)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "DELETE FROM Dtrans WHERE ID_Dtrans= @id;";


            using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
            {
                cmd.Parameters.AddWithValue("@id", ID_Dtrans);


                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetNotaDapur(int invoiceID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT d.InvoiceID, d.Nomor_Meja, h.InvoiceDate, h.Nama_Kasir, d.Quantity, d.nama_makanan, m.category_makanan FROM Dtrans d, makanan m, Htrans h WHERE d.ID_makanan = m.ID_makanan and h.InvoiceID = d.InvoiceID and d.InvoiceID = @invoiceID";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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

        public void HapusMejaAktif(int InvoiceID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "UPDATE Htrans SET MejaAktif = 0 WHERE InvoiceID = @InvoiceID; ";


            using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
            {
                cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                cmd.ExecuteNonQuery();
            }
        }

        public void HapusHtransBATAL(int InvoiceID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "DELETE FROM Htrans WHERE InvoiceID=@InvoiceID";

            using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
            {
                cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                cmd.ExecuteNonQuery();
            }
        }

        public void HapusDtransBATAL(int InvoiceID)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "DELETE FROM Dtrans WHERE InvoiceID=@InvoiceID";

            using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
            {
                cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                cmd.ExecuteNonQuery();
            }
        }

        public bool addToMejaAktif(int invoiceid, int nomormeja)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "INSERT INTO Meja_Aktif(InvoiceID,Nomor_Meja) Values(@invoiceid, @nomormeja)";

            
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@nomormeja", nomormeja);
                    cmd.Parameters.AddWithValue("@invoiceid", invoiceid);


                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Lengkapi Kolom!");
                throw;
            }
            


            
        }

        public DataTable SelectTanggal(string dari, string sampai)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * from Htrans WHERE InvoiceDate BETWEEN @dari and @sampai AND MejaAktif = 0";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@dari", dari);
            cmd.Parameters.AddWithValue("@sampai", sampai);

            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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

        public DataTable SelectTanggalHistory(string dari, string sampai)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * from hpengeluaran WHERE Tanggal_Pengeluaran BETWEEN @dari and @sampai";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@dari", dari);
            cmd.Parameters.AddWithValue("@sampai", sampai);

            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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

        public void UpdateJumlahBayardanPaymentType(int InvoiceID, int bayar, int grandtotalPPN, string Payment_Type)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "UPDATE Htrans SET Bayar = @bayar, Payment_Type = @PT, Grand_Total_PPN = @grandtotalppn WHERE InvoiceID = @InvoiceID; ";


            using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
            {
                cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                cmd.Parameters.AddWithValue("@bayar", bayar);
                cmd.Parameters.AddWithValue("@grandtotalppn", grandtotalPPN);
                cmd.Parameters.AddWithValue("@PT", Payment_Type);
                cmd.ExecuteNonQuery();
            }
        }

        public void GetUserPassword(string username)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT password FROM users WHERE username = @username";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@username", username);

            tmp_passwordLoggedUser = (string)cmd.ExecuteScalar();
        }

        public bool UpdatePassword(string username, string passwordbaru)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "UPDATE users SET password = @password WHERE username = @username";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", passwordbaru);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public DataTable getSatuan()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM satuan";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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

        public DataTable getHPengeluaran()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM hpengeluaran";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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

        public DataTable getDPengeluaran(int id_pengeluaran)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT * FROM dpengeluaran WHERE ID_Pengeluaran = @id_Pengeluaran";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@id_Pengeluaran", id_pengeluaran);

            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
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

        public bool UpdateHPengeluaran(int ID_Pengeluaran, string tanggalpengeluaran, int grandtotalpengeluaran)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "UPDATE Hpengeluaran SET Tanggal_Pengeluaran = @tanggal, Grand_Total_Pengeluaran = @grand_total_pengeluaran WHERE ID_Pengeluaran = @ID_Pengeluaran; ";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@tanggal", tanggalpengeluaran);
                    cmd.Parameters.AddWithValue("@grand_total_pengeluaran", grandtotalpengeluaran);
                    cmd.Parameters.AddWithValue("@ID_Pengeluaran", ID_Pengeluaran);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool UpdateDPengeluaran(int ID_DPengeluaran, string nama_produk, int jumlah, string satuan, int hargapersatuan, int total)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            //MessageBox.Show(ID_DPengeluaran.ToString());
            query = "UPDATE dpengeluaran SET Nama_Produk = @nama_produk, Jumlah = @jumlah, Satuan = @satuan, Harga_Per_Satuan = @harga_per_satuan, Sub_Total_Pengeluaran = @total WHERE ID_DPengeluaran = @ID_DPengeluaran";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID_DPengeluaran", ID_DPengeluaran);
                    cmd.Parameters.AddWithValue("@nama_produk", nama_produk);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@satuan", satuan);
                    cmd.Parameters.AddWithValue("@harga_per_satuan", hargapersatuan);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool InsertSatuan(string satuan)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "INSERT INTO SATUAN(Nama_Satuan) VALUES(@satuan)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@satuan", satuan);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool HapusSatuan(int ID_Satuan)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "DELETE FROM SATUAN WHERE ID_Satuan= @id";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", ID_Satuan);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool InsertPengeluaran(int grandtotal, string tanggal)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "INSERT INTO Hpengeluaran(Tanggal_Pengeluaran, Grand_Total_Pengeluaran) VALUES(@tanggal, @grandtotal)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@tanggal", tanggal);
                    cmd.Parameters.AddWithValue("@grandtotal", grandtotal);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool InsertDetailPengeluaran(int ID_Pengeluaran, string nama_produk, int jumlah, string satuan, int hargapersatuan, int total)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "INSERT INTO Dpengeluaran(ID_Pengeluaran, Nama_Produk, Jumlah, Satuan, Harga_Per_Satuan, Sub_Total_Pengeluaran) VALUES(@id_pengeluaran, @nama_produk, @jumlah, @satuan, @hargapersatuan, @total)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ID_Pengeluaran", ID_Pengeluaran);
                    cmd.Parameters.AddWithValue("@Nama_Produk", nama_produk);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@satuan", satuan);
                    cmd.Parameters.AddWithValue("@hargapersatuan", hargapersatuan);
                    cmd.Parameters.AddWithValue("@total", total);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public void getIDPengeluaran()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT MAX(ID_Pengeluaran) FROM hpengeluaran";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);

            lastIDPengeluaran = (int)cmd.ExecuteScalar();

        }

        public void getPPN()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "SELECT PPN FROM ppn WHERE ID_PPN = 1";

            MySqlCommand cmd = new MySqlCommand(query, con.connect);

            ppn = (int)cmd.ExecuteScalar();
        }

        public bool UpdatePPN(int ppn)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "UPDATE PPN SET PPN=@ppn WHERE ID_PPN = 1";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ppn", ppn);
                 
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool HapusHPengeluaran(int IDPengeluaran)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "DELETE FROM hpengeluaran WHERE ID_Pengeluaran= @id;";


            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", IDPengeluaran);


                    cmd.ExecuteNonQuery();
                }
                return true;

            }

            catch
            {
                throw;
            }
        }

        public bool HapusDPengeluaran(int IDPengeluaran)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            query = "DELETE FROM dpengeluaran WHERE ID_Pengeluaran= @id;";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@id", IDPengeluaran);


                    cmd.ExecuteNonQuery();
                }
                return true;

            }

            catch
            {
                throw;
            }

        }


    }
}
