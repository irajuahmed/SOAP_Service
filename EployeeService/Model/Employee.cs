using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EployeeService.Model
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }         
    }
}