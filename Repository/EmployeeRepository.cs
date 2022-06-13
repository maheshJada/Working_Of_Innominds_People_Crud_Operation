using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.Models;
using Working_Of_Innominds_People_Crud_Operation.ServiceLayer.Interfaces;

namespace Working_Of_Innominds_People_Crud_Operation.ServiceLayer
{
    [Authorize(Roles = "Employee,It")]
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeRepository:IEmployee
    {
        private readonly ApplicationContext _applicationContext;
        public EmployeeRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        
        [HttpDelete]
        public bool Delete(int EmpId)
        {

            var emp = _applicationContext.EmployeeTable.Find(EmpId);
            if (emp == null)
                return false;
            _applicationContext.Remove(emp);
            _applicationContext.SaveChanges();
            return true;
        }

        [HttpGet]
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _applicationContext.EmployeeTable;
        }

        [HttpGet]
        public Employee GetByDataBasedOnEmpNameOrEmpId(string EmpName_or_EmpId)
        {
            if (EmpName_or_EmpId != null)
            {
                Employee Search = _applicationContext.EmployeeTable.FirstOrDefault(x => x.EmpName == EmpName_or_EmpId);
                if (Search != null)
                {
                    return Search;
                }
                else
                {
                    return _applicationContext.EmployeeTable.FirstOrDefault(x => x.EmpId == Convert.ToInt32(EmpName_or_EmpId));
                }
            }
            return null;
        }
        [HttpPost]
        public IEnumerable<Employee> InsertEmployee(Employee employee)
        {
            _applicationContext.EmployeeTable.Add(employee);
            _applicationContext.SaveChanges();
            return _applicationContext.EmployeeTable;
        }
        [HttpPut]
        public IEnumerable<Employee> UpdateData(Employee category)
        {
            _applicationContext.EmployeeTable.Update(category);
            _applicationContext.SaveChanges();
            return GetAllEmployee();
        }

    }
}
