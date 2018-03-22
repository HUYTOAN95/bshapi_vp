using bshapi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace bshapi.DataAccess
{
    public class DataLayer
    {



        public DataTable GetEmployee()
        {
            DataTable dt = new DataTable();


            SqlCommand cmd = new SqlCommand("SELECT * FROM bsh_employee", GetConnect.cnn);
            GetConnect.cnn.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GetConnect.cnn.Close();
            return dt;
          }

        public DataTable GetEmployee(string id)
        {


            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM bsh_employee WHERE emp_id = @emp_id", GetConnect.cnn);
            GetConnect.cnn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@emp_id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GetConnect.cnn.Close();
            return dt;
        }
        public int PostEmployee(string id , string name, string address, string phone, string email, DateTime joindate, DateTime validadate)
        {
            SqlCommand cmd = new SqlCommand("BSH_SP_INSERTEMPLOYEE", GetConnect.cnn);
            GetConnect.cnn.Open();
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@emp_id", id);
              cmd.Parameters.AddWithValue("@emp_name", name);
              cmd.Parameters.AddWithValue("@emp_address",address);
              cmd.Parameters.AddWithValue("@emp_moblie", phone);
              cmd.Parameters.AddWithValue("@emp_email", email);
              cmd.Parameters.AddWithValue("@emp_joindate", joindate);
              cmd.Parameters.AddWithValue("@emp_validate", validadate);
              return cmd.ExecuteNonQuery();

        }
    }
    
}