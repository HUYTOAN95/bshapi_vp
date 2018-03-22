using bshapi.Models;
using bshapi.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bshapi.Controllers.ExcuteController
{
    public class EmployeeController : Controller
    {   private readonly IUsersRepository _repository;
    public EmployeeController(IUsersRepository repository)
       {
        _repository = repository;
       }
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            var model = _repository;
        return View(model);
        }
	}
}