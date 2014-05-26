using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Communicator
{
    public class ConnectionManager
    {
        public static SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DB.MDF;Integrated Security=True;User Instance=True");

        }
    }
}