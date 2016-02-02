using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5CRUD.Models;
using MVC5CRUD.Repository;
using MVC5CRUD.ViewModels;

namespace MVC5CRUD.BusinessLogic
{
    public class CustomerManager
    {
        private GenericRepository<Customer> CustRepository;
        public CustomerManager()
        {
            this.CustRepository = new GenericRepository<Customer>(new Customer_Entities());
        }

        public List<CustomerVM> getAllCustomers()
        {
            List<CustomerVM> custVMs = new List<CustomerVM>();
            IEnumerable<Customer> customers = CustRepository.GetAll();
            foreach (Customer c in customers)
            {
                CustomerVM cvm = new CustomerVM();
                cvm.Id = c.Id;
                cvm.CustName = c.CustName;
                cvm.CustEmail = c.CustEmail;
                custVMs.Add(cvm);
            }

            return custVMs;
        }

        public long InsertCustomer(CustomerVM model)
        {
            Customer cust = new Customer();
            cust.CustName = model.CustName;
            cust.CustEmail = model.CustEmail;
            CustRepository.Insert(cust);
            CustRepository.Save();
            return model.Id;
        }

        public bool DeleteCustomer(long id)
        {
            try
            {
                this.CustRepository.Delete(id);
                CustRepository.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public CustomerVM GetCustomer(int id)
        {
            CustomerVM cvm = null;
            Customer cust = new Customer();
            try
            {
                cust = this.CustRepository.GetById(id);
                cvm = new CustomerVM();
                cvm.Id = cust.Id;
                cvm.CustName = cust.CustName;
                cvm.CustEmail = cust.CustEmail;
            }
            catch
            {
                
            }

            return cvm;

        }


        public bool UpdateCustomer(CustomerVM model)
        {
            try
            {
                Customer cust = this.CustRepository.GetById(model.Id);
               // cust.Id = model.Id;
                cust.CustName = model.CustName;
                cust.CustEmail = model.CustEmail;
                this.CustRepository.Update(cust);
                CustRepository.Save();
                return true;
            }
            catch(Exception e) {

                    return false;
                        
            }
        }

    }
}