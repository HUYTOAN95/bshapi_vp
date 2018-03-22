using bshapi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace bshapi.Repository
{
    public interface IEmpRepository
    {
        public Employee GetAllEmployee();
    }
    public class EmployeeRepository : IEmpRepository
    {
        private readonly string _connectionString;
        public EmployeeRepository(string connectionString)
        {
            _connectionString = GetConnect.cnn;
        }
        public Employee GetAllEmployee()
        {

            List<Employee> lstemployee = new List<Employee>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM bsh_employee", GetConnect.cnn);
            cmd.CommandType = CommandType.Text;

            GetConnect.cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (!rdr.Read())
            {

            }
            return new Employee

              {

                  emp_id = rdr["emp_id"].ToString(),
                  emp_name = rdr["emp_name"].ToString(),
                  emp_address = rdr["emp_address"].ToString(),
                  emp_mobile = rdr["emp_mobile"].ToString(),



              };
            GetConnect.cnn.Close();
        }
    }
}