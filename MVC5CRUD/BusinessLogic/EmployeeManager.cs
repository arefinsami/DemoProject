using MVC5CRUD.Models;
using MVC5CRUD.Repository;
using MVC5CRUD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5CRUD.BusinessLogic
{
    public class EmployeeManager
    {
        private GenericRepository<Employee> db;
        public EmployeeManager()
        {
            this.db = new GenericRepository<Employee>(new Customer_Entities());
        }
        public List<EmployeeVM> GetEmployees()
        {
            List<EmployeeVM> employees = new List<EmployeeVM>();
            foreach (Employee e in db.GetAll())
            {
                EmployeeVM evm = new EmployeeVM();
                evm.EmployeeNo = e.EmployeeNo;
                evm.EmployeeName = e.EmployeeName;
                evm.Job = e.Job;
                evm.HireDate = e.HireDate;
                evm.Salary = e.Salary;
                evm.Commision = e.Commision;
                employees.Add(evm);
            }

            return employees;
        }
        
        public EmployeeVM GetEmployee(int id)
        {
            Employee emp = null;
            EmployeeVM evm = null;
            try
            {

                emp = db.GetById(id);

                if (emp != null)
                {
                    evm = new EmployeeVM();
                    evm.EmployeeNo = emp.EmployeeNo;
                    evm.EmployeeName = emp.EmployeeName;
                    evm.DeptNo = (int)emp.DeptNo;
                    evm.Job = emp.Job;
                    evm.HireDate = emp.HireDate;
                    evm.Salary = emp.Salary;
                    evm.Commision = emp.Commision;
                }
               
            }
            catch {
               
            }
            return evm;
        }
        
        public bool UpdateEmployee(EmployeeVM evm)
        {
            Employee emp = db.GetById(evm.EmployeeNo);
            emp.EmployeeName = evm.EmployeeName;
            emp.Commision = evm.Commision;
            emp.HireDate = evm.HireDate;
            emp.Job = evm.Job;
            emp.Manager = evm.Manager;
            emp.Salary = evm.Salary;
            try
            {
                db.Update(emp);
                db.Save();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        
        public int InsertEmployee(EmployeeVM evm)
        {

            Employee emp = new Employee();
            emp.EmployeeNo= evm.EmployeeNo;
            emp.EmployeeName = evm.EmployeeName;
            emp.Commision = evm.Commision;
            emp.DeptNo= evm.DeptNo;
            emp.HireDate = evm.HireDate;
            emp.Job = evm.Job;
            emp.Manager = evm.Manager;
            emp.Salary = evm.Salary;
            try
            {
                db.Insert(emp);
                db.Save();
            }
            catch (Exception e)
            {
            }
            return emp.EmployeeNo;

        }

        
        public bool DeleteEmployee(int id)
        {
            if (!EmployeeExists(id))
            {
                return false;
            }

            try
            {
                db.Delete(id);
                db.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

       
        public bool EmployeeExists(int id)
        {
            Employee emp= db.GetById(id);
            if (emp != null)
                return true;
            else
                return false;
        }

    }
}