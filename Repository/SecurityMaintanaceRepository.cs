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
   [Authorize(Roles = "SecurityMaintanace")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SecurityMaintanaceRepository:ISecurityMaintanace
    {
        private readonly ApplicationContext _applicationContext;
        public SecurityMaintanaceRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        [HttpDelete]
        public bool DeleteTheThings(int id)
        {

            var emp = GetByParticularThing(id);
            if (emp == null)
                return false;
            _applicationContext.Remove(emp);
            _applicationContext.SaveChanges();
            return true;
        }
        [HttpGet]
        public IEnumerable<SecuritySystemMaintanace> GetAllMaintanceData()
        {
            return _applicationContext.MaintanacesTable;
        }
        [HttpGet]
        public SecuritySystemMaintanace GetByParticularThing(int Id)
        {
            return _applicationContext.MaintanacesTable.Find(Id);
        }
        [HttpPost]
        public IEnumerable<SecuritySystemMaintanace> InsertTheThings(SecuritySystemMaintanace maintanace)
        {
            _applicationContext.MaintanacesTable.Add(maintanace);
            _applicationContext.SaveChanges();
            return _applicationContext.MaintanacesTable;
        }
        [HttpPut]
        public IEnumerable<SecuritySystemMaintanace> UpdateTheThings(SecuritySystemMaintanace maintanace)
        {
            _applicationContext.Update(maintanace);
            _applicationContext.SaveChanges();
            return GetAllMaintanceData();
        }
    }
}
