using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bshapi.Models;
using System.Data.Odbc;
using System.Data;

namespace bshapi.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
    //    public ActionResult Login(string b_ma_dvi, string b_nsd, string b_pas)
    //{
    //    OdbcCommand cmd = new OdbcCommand("KT_BSH.PBH_MA_NSD_TEST", GetConnect.cnn);
    //    GetConnect.cnn.Open();
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.Parameters.Add("b_ma_dvi", b_ma_dvi);
    //    cmd.Parameters.Add("b_nsd", b_nsd);
    //    cmd.Parameters.Add("b_pas", b_pas);
    //    var result = cmd.ExecuteScalar();
    //    if (result != null)
    //    {
    //        ViewBag.Message = "Login Successfull !";
    //        return View();
    //    }
    //    else
    //    {
    //        ViewBag.Message = "Login Error !";
    //        return View();
    //    }
    //}
	}
}
