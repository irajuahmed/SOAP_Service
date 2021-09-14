using EployeeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EployeeService
{
    /// <summary>
    /// Summary description for EmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Welcome to Our SOAP service.";
        }

        [WebMethod]
        public Employee GetEmployeeDetails()
        {
            return GetEmployeeDetail();
        }

        [WebMethod]
        public Employee UpdateEmployeeDetails(Employee emp)
        {
            return new Employee 
            { 
                EmpId = emp.EmpId,
                FirstName = emp.FirstName,
                MiddleName = emp.MiddleName,
                LastName = emp.LastName,
                FullName ="Your full name is: "+ emp.FirstName +" "+emp.MiddleName +" "+emp.LastName,
                DateOfBirth =  emp.DateOfBirth.Value.AddYears(1),
            };
        }

        public Employee GetEmployeeDetail()
        {
            return new Employee
            {
                EmpId = 1,
                FirstName = "Raju",
                MiddleName = "",
                LastName = "Ahmed",
                DateOfBirth = DateTime.Now
            };
        }
    }
}
