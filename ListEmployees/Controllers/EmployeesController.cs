using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ListEmployees.Models;
using Newtonsoft.Json;

namespace ListEmployees.Controllers
{
    public class EmployeesController : ApiController
    {
        // GET: api/employees
        [HttpGet]
        public IHttpActionResult Get(string lastName = null, string firstName = null,
                                   int? departmentID = null, int? subDepartmentID = null)
        {
            TestDBEntities _entity = new TestDBEntities();
            return Ok(_entity.SelectEmployee(lastName, firstName, departmentID, subDepartmentID));
        }

    }
}
