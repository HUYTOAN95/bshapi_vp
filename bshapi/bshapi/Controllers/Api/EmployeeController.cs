using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using bshapi.DataAccess;
using System.Data;

namespace bshapi.Controllers.Api
{
    public class EmployeeController : ApiController
    {   [HttpGet]
        public IHttpActionResult GetEmployee()
        {
            DataLayer da = new DataLayer();
            DataTable dt = da.GetEmployee();
            if (dt == null)
            {
                return NotFound();
            }
            else
                return Ok(dt);
        }
        public IHttpActionResult GetEmployee(string id)
    {
        DataLayer da = new DataLayer();
        DataTable dt = da.GetEmployee(id);
        if (dt == null)
        {
            return NotFound();
        }
        else
            return Ok(dt);
            
    }
    }
}
