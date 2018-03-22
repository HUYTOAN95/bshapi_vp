using bshapi.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bshapi.DataAccess;

namespace bshapi.Controllers.ExcuteController
{
    public class EmployeeController : Controller
    {
        // GET: /Employee/
        public ActionResult Index()
        {
            DataLayer da = new DataLayer();
            DataTable dt = da.GetEmployee();
            return View("Index",dt);

        }
        public ActionResult AddEmployee(FormCollection frm , string action)
        {
            
                string id = frm["emp_id"];
                string name = frm["emp_name"];
                string address = frm["emp_adress"];
                string mobile = frm["emp_mobile"];
                string email = frm["emp_mobile"];
                DateTime joindate = DateTime.Parse(frm["emp_joindate"]);
                DateTime validate = DateTime.Parse(frm["emp_validate"]);
                DataLayer da = new DataLayer();
                int stt = da.PostEmployee(id, name, address, mobile, email, joindate, validate);
                return RedirectToAction("Index");
          
        }
    }
}