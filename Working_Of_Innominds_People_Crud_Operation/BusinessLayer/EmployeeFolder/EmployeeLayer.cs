using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.Models;
using Working_Of_Innominds_People_Crud_Operation.ServiceLayer.Interfaces;

namespace Working_Of_Innominds_People_Crud_Operation.BusinessLayer.EmployeeFolder
{
    public class EmployeeLayer : IEmployeeLayer
    {
        private readonly IEmployee Employee;
        public EmployeeLayer(IEmployee employee)
        {
            Employee = employee;
        }
        public bool Delete(int EmpId)
        {

            if (Employee.Delete(EmpId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return Employee.GetAllEmployee();
        }

        public Employee GetByDataBasedOnEmpNameOrEmpId(string EmpName_or_EmpId)
        {
            return Employee.GetByDataBasedOnEmpNameOrEmpId(EmpName_or_EmpId);
        }

        public IEnumerable<Employee> InsertEmployee(Employee employee)
        {
            return Employee.InsertEmployee(employee);
        }

        public IEnumerable<Employee> UpdateData(Employee category)
        {
            return Employee.UpdateData(category);
        }
    }
}
