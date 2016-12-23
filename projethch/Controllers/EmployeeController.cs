using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projethch.EF;
using projethch.ViewModel;

namespace projethch.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        [Authorize]
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeModel oEmployeeModel= new EmployeeModel();
            Dal oDal= new Dal();
            oEmployeeModel.listofEmployee = oDal.employees.ToList();

            return View(oEmployeeModel);
        }
    }
}