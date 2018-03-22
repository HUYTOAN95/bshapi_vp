using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Mvc;


namespace bshapi.Models
{
    public class GetConnect
    {
        public static SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
        public void checkconnect()
        {
            if( cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
               
            }
        }
    }
}