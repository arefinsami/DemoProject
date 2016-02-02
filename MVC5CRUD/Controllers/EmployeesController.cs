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
using MVC5CRUD.ViewModels;
using MVC5CRUD.BusinessLogic;

namespace MVC5CRUD.Controllers
{
    public class EmployeesController : ApiController
    {
        private EmployeeManager empManager = new EmployeeManager();

        // GET: api/Employees
        public List<EmployeeVM> GetEmployees()
        {
            List<EmployeeVM> employees = empManager.GetEmployees();
            return employees;
        }

        // GET: api/Employees/5
        [ResponseType(typeof(EmployeeVM))]
        public IHttpActionResult GetEmployee(int id)
        {
            EmployeeVM evm = empManager.GetEmployee(id);
            if (evm == null)
            {
                return NotFound();
            }
            
            return Ok(evm);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(EmployeeVM employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (empManager.GetEmployee(employee.EmployeeNo) == null)
            {
                return NotFound();
            }
            
            try
            {
                empManager.UpdateEmployee(employee);
                return StatusCode(HttpStatusCode.NoContent);
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }

        // POST: api/Employees
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(EmployeeVM evm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (empManager.EmployeeExists(evm.EmployeeNo))
            {
                return Conflict();
            }
            try
            {
                evm.EmployeeNo=empManager.InsertEmployee(evm);
            }
            catch
            {
                return BadRequest();
            }

            return CreatedAtRoute("DefaultApi", new { id = evm.EmployeeNo }, evm);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            if (empManager.GetEmployee(id) == null)
            {
                return NotFound();
            }
            if (empManager.DeleteEmployee(id))
            {
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            } 
        }
    }
}