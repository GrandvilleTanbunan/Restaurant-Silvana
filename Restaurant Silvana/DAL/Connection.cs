using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Restaurant_Silvana.DAL
{
    class Connection
    {
        //public SqlConnection connect = new SqlConnection(@"Data Source =GRANDVILLETANBU\GRANDVILLE; Initial Catalog = silvana; User id=silvana; Password=silvana12345");
        //string ConnectString = "datasource = localhost; username = root; password=; database=silvana";
        public MySqlConnection connect = new MySqlConnection("datasource = localhost; username = silvana; password=silvana12345; database=silvana; Convert Zero Datetime=True");
    }
}
