using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC5CRUD.ViewModels;
using MVC5CRUD.BusinessLogic;

namespace MVC5CRUD.Test
{
    [TestClass]
    public class TestEmployeeManager
    {
        private EmployeeManager empMngr = new EmployeeManager();
        
        [TestMethod]
        public void TestGetEmployees()
        {
            Assert.IsTrue(empMngr.GetEmployees().Count > 0);
        }
        [TestMethod]
        public void TestGetEmployee()
        {
            Assert.IsTrue(empMngr.GetEmployee(3).EmployeeNo==3);
        }
        [TestMethod]
        public void TestInsertEmployee()
        {
            EmployeeVM evm = new EmployeeVM();
            evm.EmployeeName = "Aston K";
            evm.EmployeeNo = 100;
            evm.Commision = 100;
            evm.DeptNo = 2;
            evm.HireDate = DateTime.Today;
            evm.Job = "TECH";
            evm.Manager = 3;
            evm.Salary = 22900;
            Assert.IsTrue(empMngr.InsertEmployee(evm)==100);
        }
        [TestMethod]
        public void TestUpdateEmployee()
        {
            EmployeeVM evm = new EmployeeVM();
            evm.EmployeeName = "Aston K";
            evm.EmployeeNo = 4;
            evm.Commision = 100;
            evm.DeptNo = 2;
            evm.HireDate = DateTime.Today;
            evm.Job = "TECH";
            evm.Manager = 3;
            evm.Salary = 22900;
            Assert.IsTrue(empMngr.UpdateEmployee(evm));
        }
       
        [TestMethod]
        public void TestDeleteEmployee()
        {
            Assert.IsTrue(empMngr.DeleteEmployee(100));
        }
        [TestMethod]
        public void TestEmployeeExists()
        {
            Assert.IsFalse(empMngr.EmployeeExists(100));
        }
    }
}
