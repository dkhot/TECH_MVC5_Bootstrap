using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var allEmployees = new List<EmployeeViewModel>();

            for (int i = 0; i <= 10; i++)
            {
                EmployeeViewModel emp = new EmployeeViewModel();
                emp.Name = "My Name " + i;
                emp.Department = "My Dept " + i;
                emp.ContactNumber = 10000 + i;
                allEmployees.Add(emp);

            }

            ViewBag.EmplListDropDown = new SelectList(allEmployees, "ContactNumber", "Name");
            return View();
        }

        public ActionResult AjaxHandler(jQueryDataTableParamModel param)
        {
            var allEmployees = new List<EmployeeViewModel>();

            for (int i = 0; i <= 10; i++)
            {
                EmployeeViewModel emp = new EmployeeViewModel();
                emp.Name = "My Name " + i;
                emp.Department = "My Dept " + i;
                emp.ContactNumber = 10000 + i;
                allEmployees.Add(emp);

            }

            var result = allEmployees.ToArray<EmployeeViewModel>();
            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = allEmployees.Count(),
                iTotalDisplayRecords = allEmployees.Count(),
                aaData = result
            }, JsonRequestBehavior.AllowGet);
        }
    }
}