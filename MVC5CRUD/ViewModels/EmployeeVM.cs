using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5CRUD.ViewModels
{
    public class EmployeeVM
    {
        public int EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public string Job { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<decimal> Commision { get; set; }
        public int DeptNo { get; set; }
        public int Manager { get; set; }
    }
}