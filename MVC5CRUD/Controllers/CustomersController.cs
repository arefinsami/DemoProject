using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MVC5CRUD.Models;
using MVC5CRUD.BusinessLogic;
using MVC5CRUD.ViewModels;

namespace MVC5CRUD.Controllers
{
    public class CustomersController : ApiController
    {
        private CustomerManager customerManager = new CustomerManager();

        // GET: api/Customers
        public List<CustomerVM> GetCustomers()
        {
            return customerManager.getAllCustomers();
        }

        // GET: api/Customers/5
        [ResponseType(typeof(CustomerVM))]
        public IHttpActionResult GetCustomer(int id)
        {
            CustomerVM customer = customerManager.GetCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // PUT: api/Customers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomer(CustomerVM customer)
        {
            if (!ModelState.IsValid)
            {
                
                return Content(HttpStatusCode.BadRequest, BadRequest(ModelState));
            }

            if (customerManager.GetCustomer(Convert.ToInt32(customer.Id)) == null)
            {
                
                return Content(HttpStatusCode.NotFound, NotFound());
            }

            try
            {
                if (customerManager.UpdateCustomer(customer))
                {
                    
                    return Content(HttpStatusCode.OK, true);
                }
                else {
                   
                    return Content(HttpStatusCode.BadRequest, StatusCode(HttpStatusCode.NoContent));
                }
            }
            catch
            {
                
                return Content(HttpStatusCode.BadRequest, BadRequest(ModelState));
            }
        }

        // POST: api/Customers
        [ResponseType(typeof(Customer))]
        public IHttpActionResult PostCustomer(CustomerVM customer)
        {
            if (!ModelState.IsValid)
            {
               
                return Content(HttpStatusCode.BadRequest, BadRequest(ModelState));
            }
            try
            {
                customer.Id = customerManager.InsertCustomer(customer);
            }
            catch
            {
                return Content(HttpStatusCode.BadRequest, BadRequest());
            }
            return Content(HttpStatusCode.OK, true);

           
        }

        // DELETE: api/Customers/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult DeleteCustomer(long id)
        {
            if (customerManager.GetCustomer(Convert.ToInt32(id)) == null)
            {
                return Content(HttpStatusCode.NotFound, NotFound());
            }
            if (customerManager.DeleteCustomer(id))
            {
                return Content(HttpStatusCode.OK, true);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, BadRequest(ModelState));
            }
        }
    }
}