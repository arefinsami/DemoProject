using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5CRUD.Repository;
using MVC5CRUD.BusinessLogic;
using MVC5CRUD.ViewModels;

namespace MVC5CRUD.Controllers
{
    public class HomeController : Controller
    {
        private CustomerManager customerManager;

       
        public HomeController()
        {
            this.customerManager = new CustomerManager();
        }
        //ActionResult
        // GET: Home
        public ActionResult Index()
        {
            List<CustomerVM> customers = customerManager.getAllCustomers();
            return View(customers);
        }
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CustomerVM model)
        {
            if (ModelState.IsValid)
            {
                customerManager.InsertCustomer(model);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(long id)
        {
            customerManager.DeleteCustomer(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            return View(customerManager.GetCustomer(id));
        }

        [HttpPost]
        public ActionResult Update(CustomerVM model)
        {
            customerManager.UpdateCustomer(model);
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}