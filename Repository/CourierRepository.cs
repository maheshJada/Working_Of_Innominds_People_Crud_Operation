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
    [Authorize(Roles = "Courier,Employee")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourierRepository: ICourier
    {
        private readonly ApplicationContext _applicationContext;
        public CourierRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        [HttpGet]
        public IEnumerable<Courier_To_The_Company> GetAllCourierEmployeesData()
        {
            return _applicationContext.CourierTable;
        }
        [HttpGet]
        public Courier_To_The_Company GetParticularEmployeeCourierData(string EmpName_or_EmpId)
        {
            if (EmpName_or_EmpId != null )
            {
                Courier_To_The_Company Search= _applicationContext.CourierTable.FirstOrDefault(x => x.EmpName == EmpName_or_EmpId);
                if(Search != null)
                {
                    return Search;
                }
                else
                {
                    return _applicationContext.CourierTable.FirstOrDefault(x => x.EmpId == Convert.ToInt32(EmpName_or_EmpId));
                }
            }
            return null;
        }
        [HttpPost]
        public IEnumerable<Courier_To_The_Company> InsertTheCourierDetailsToTheRecord(Courier_To_The_Company courier)
        {
            var data = _applicationContext.EmployeeTable.Find(courier.EmpId);
            if (data != null)
            {
                _applicationContext.CourierTable.Add(courier);
                _applicationContext.SaveChanges();
                return _applicationContext.CourierTable;
            }
            return null;
        }
        [HttpPut]
        public IEnumerable<Courier_To_The_Company> UpdateTheEmployeeData(Courier_To_The_Company courier)
        {
            _applicationContext.Update(courier);
            _applicationContext.SaveChanges();
            return GetAllCourierEmployeesData();
        }
    }
}
