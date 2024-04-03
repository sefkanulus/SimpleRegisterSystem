using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RegisterSystem.Classes
{
    public class SqlConnectionClass
    {

        public static SqlConnection connection = new SqlConnection("Data Source=;Initial Catalog=ETRADE;Integrated Security=True;Encrypt=False");

        public static void CheckConnection()
        {

            //eğer connection bağlantımın durumu kapalı ise
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                //bağlantıyı aç
                connection.Open();
            }
                       
        }
    }
}