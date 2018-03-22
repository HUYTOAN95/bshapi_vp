using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using bshapi.Models;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Data;
using System.Web.Mvc;
using Newtonsoft.Json;


namespace bshapi.Controllers
{
    public class EmployeeController : ApiController
    {
        [System.Web.Mvc.HttpGet]


        public IEnumerable<Employee> GetEmployee()
        {


            List<Employee> lstemployee = new List<Employee>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM bsh_employee", GetConnect.cnn);
            cmd.CommandType = CommandType.Text;

            GetConnect.cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Employee employee = new Employee();

                employee.emp_id = rdr["emp_id"].ToString();
                employee.emp_name = rdr["emp_name"].ToString();
                employee.emp_address = rdr["emp_address"].ToString();
                employee.emp_mobile = rdr["emp_mobile"].ToString();


                lstemployee.Add(employee);
            }
            GetConnect.cnn.Close();

            return lstemployee;
           
        }
        [System.Web.Mvc.HttpGet]
        public IHttpActionResult GetEmployee(string id)
        {

           
            List<Employee> lstemployee = new List<Employee>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM bsh_employee WHERE emp_id = @emp_id", GetConnect.cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@emp_id", id);
            GetConnect.cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Employee employee = new Employee();

                employee.emp_id = rdr["emp_id"].ToString();
                employee.emp_name = rdr["emp_name"].ToString();
                employee.emp_address = rdr["emp_address"].ToString();
                employee.emp_mobile = rdr["emp_mobile"].ToString();


                lstemployee.Add(employee);
            }
            GetConnect.cnn.Close();

            return Ok(lstemployee);



        }
       //[System.Web.Routing("~/api/PostEmployee")]
       [System.Web.Mvc.HttpPost]
       
       
        public IHttpActionResult PostEmployee(Employee emp)
        {
            using (SqlCommand cmd = new SqlCommand("BSH_SP_INSERTEMPLOYEE", GetConnect.cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emp_id", emp.emp_id);
                cmd.Parameters.AddWithValue("@emp_name", emp.emp_name);
                cmd.Parameters.AddWithValue("@emp_address", emp.emp_address);
                cmd.Parameters.AddWithValue("@emp_mobile", emp.emp_mobile);
                cmd.Parameters.AddWithValue("@emp_email", emp.emp_email);
                cmd.Parameters.AddWithValue("@emp_joindate", emp.emp_joindate.ToShortDateString());
                cmd.Parameters.AddWithValue("@emp_validedate", emp.emp_validedate.ToShortDateString());
                GetConnect.cnn.Open();
                 var i = cmd.ExecuteNonQuery();
                GetConnect.cnn.Close();
                if (i == null)
                    return NotFound();//404
                return Ok(i);
               
            }
            
         }


        }

        
    }

