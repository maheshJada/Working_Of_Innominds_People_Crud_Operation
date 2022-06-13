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
    [Authorize(Roles = "It,Employee")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ItRepository:InIT
    {
        private readonly ApplicationContext _applicationContext;
        public ItRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        [HttpDelete]
        public bool Delete(int it)
        {

            var emp = _applicationContext.ItTable.Find(it);
            if (emp == null)
                return false;
            _applicationContext.Remove(emp);
            _applicationContext.SaveChanges();
            return true;
        }
        [HttpGet]
        public IEnumerable<It> GetEmployeeLaptopData()
        {
            return _applicationContext.ItTable;
        }
        [HttpGet]
        public It GetByEmployeeLaptopDataBasedOnEmpNameOrEmpId(string EmpName_or_EmpId)
        {
            if (EmpName_or_EmpId != null)
            {
                It Search = _applicationContext.ItTable.FirstOrDefault(x => x.EmpName == EmpName_or_EmpId);
                if (Search != null)
                {
                    return Search;
                }
                else
                {
                    return _applicationContext.ItTable.FirstOrDefault(x => x.EmpId == Convert.ToInt32(EmpName_or_EmpId));
                }
            }
            return null;
        }
        [HttpPost]
        public IEnumerable<It> CreateOrGiveTheLaptop(It employee)
        {
            _applicationContext.ItTable.Add(employee);
            _applicationContext.SaveChanges();
            return _applicationContext.ItTable;
        }
        [HttpPut]
        public IEnumerable<It> UpdateOrChangeTheEmployeeLaptop(It it)
        {
            _applicationContext.Update(it);
            _applicationContext.SaveChanges();
            return GetEmployeeLaptopData();
        }
    }
}
