using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Working_Of_Innominds_People_Crud_Operation.Controllers;
using Working_Of_Innominds_People_Crud_Operation.Models;
using Working_Of_Innominds_People_Crud_Operation.ServiceLayer.Interfaces;
using Xunit;

namespace EmployeeUnitTesting
{
    public class EmployeeTest
    {
        private readonly IEmployee _Employee;
        //private readonly EmployeesController EmployeeController;

        public EmployeeTest(EmployeeFakeServices employee)
        {
            _Employee = employee;
           // EmployeeController = employeesController;
        }

        [Fact]
        public void InsertTest()
        {
            int initialcount = _Employee.GetAllEmployee().ToList().Count;
            var emp = new Employee() { EmpId = 29, EmpName = "Mahimood", PhoneNumber = 836267252, EmailID = "mahi@innominds.com", EmpLocation = "sec", Date = Convert.ToDateTime(04/12/2001), EmpCategory = "Java", };
            List<Employee> employees=_Employee.InsertEmployee(emp).ToList();
            int finalcount = employees.Count;
            Assert.NotEqual(initialcount, finalcount);
        }
    }
}
