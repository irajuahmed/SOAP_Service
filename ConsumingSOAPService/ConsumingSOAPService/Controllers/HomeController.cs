using ConsumingSOAPService.EmployeeServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumingSOAPService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                EmployeeServiceSoapClient client = new EmployeeServiceSoapClient();
                ViewBag.HelloWorldMessage= client.HelloWorld();
                ViewBag.EmployeeDetails = client.GetEmployeeDetails();
                Employee employee = client.GetEmployeeDetails();
                employee.EmpId = 500;
                employee.FirstName = "Md.";
                employee.MiddleName = "Shohag";
                employee.LastName = "Mia";
                

                ViewBag.UpdateEmployeeDetails = client.UpdateEmployeeDetails(employee);
            }
            catch (Exception ex)
            {
                @ViewBag.ErrorMessage = ex.Message;
                return View("Error");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}