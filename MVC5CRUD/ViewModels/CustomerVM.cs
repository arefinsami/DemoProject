using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5CRUD.ViewModels
{
    public class CustomerVM
    {
        public long Id { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
    }
}