using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC5CRUD.BusinessLogic;
using MVC5CRUD.ViewModels;


namespace MVC5CRUD.Test
{
    [TestClass]
    public class TestCustomerManager
    {
        private CustomerManager custMngr = new CustomerManager();
        
        [TestMethod]
        public void TestgetAllCustomers()
        {
            Assert.IsTrue(custMngr.getAllCustomers().Count>0);
        }

        [TestMethod]
        public void TestInsertCustomer()
        {
            CustomerVM cvm = new CustomerVM();
            cvm.CustName = "Harison Ford";
            cvm.CustEmail = "gford@gmail.com";
            long testCustId = custMngr.InsertCustomer(cvm);
            Assert.IsTrue(testCustId >= 0);
        }
        
        [TestMethod]
        public void TestGetCustomer()
        {
            Assert.IsTrue(custMngr.GetCustomer(2).Id==2);
        }

        [TestMethod]
        public void TestUpdateCustomer()
        {
            CustomerVM cvm = new CustomerVM();
            cvm.Id = 3;
            cvm.CustName = "Aron K";
            cvm.CustEmail = "aron@gmail.com";
            Assert.IsTrue(custMngr.UpdateCustomer(cvm));

        }

        [TestMethod]
        public void TestDeleteCustomer()
        {
            Assert.IsTrue(custMngr.DeleteCustomer(15));
        }
        
    }
}
