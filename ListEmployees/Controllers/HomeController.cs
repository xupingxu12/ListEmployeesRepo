using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListEmployees.Models;

namespace ListEmployees.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string lastName = null, string firstName = null,
                                   int? departmentID = null, int? subDepartmentID = null)
        {
            lastName = (lastName == null || lastName.Trim() == "") ? null : lastName.Trim();
            firstName = (firstName == null || firstName.Trim() == "") ? null : firstName.Trim();

            TestDBEntities _entity = new TestDBEntities();
            ViewData["deptList"] = new SelectList(_entity.Departments.ToList(), "DepartmentID", "DepartmentName");
            ViewData["subDeptList"] = new SelectList(_entity.SubDepartments.ToList(), "SubDepartmentID", "SubDepartmentName");
            return View(_entity.SelectEmployee(lastName, firstName, departmentID, subDepartmentID));       
        }

    }
}