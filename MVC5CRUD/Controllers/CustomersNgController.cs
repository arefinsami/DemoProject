using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5CRUD.Models;

namespace MVC5CRUD.Controllers
{
    public class CustomersNgController : Controller
    {
     
        // GET: CustomersNg
        public ActionResult Index()
        {
            return View();
        }
      
    }
}
