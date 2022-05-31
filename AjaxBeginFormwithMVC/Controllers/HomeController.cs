using AjaxBeginFormwithMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxBeginFormwithMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult EmployeeMaster()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeMaster(EmpModel obj)
        {
            ViewBag.Records = "Name : " + obj.Name + " City:  " + obj.City + " Addreess: " + obj.Address;
            return PartialView("EmployeeMaster");
        }
    }
}