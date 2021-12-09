using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant_Silvana.DAL
{
    class Connection
    {
        public SqlConnection connect = new SqlConnection(@"Data Source =GRANDVILLE\GRANDVILLE; Initial Catalog = silvana; User id=silvana; Password=silvana12345");
    }
}
