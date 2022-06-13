
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
    [Authorize(Roles = "Visitors")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VisitorsRepository:IVisitor
    {
        private readonly ApplicationContext _applicationContext;
        public VisitorsRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        [HttpGet]
        public IEnumerable<Visitors> GetAllVistedPeeples()
        {
            return _applicationContext.VisitorsTable;
        }
        [HttpGet]

        public Visitors GetVistorsDataBasedOnEmpNameOrEmpId(string EmpName_or_EmpId)
        {
            if (EmpName_or_EmpId != null)
            {
                Visitors Search = _applicationContext.VisitorsTable.FirstOrDefault(x => x.Name == EmpName_or_EmpId);
                if (Search != null)
                {
                    return Search;
                }
                else
                {
                    return _applicationContext.VisitorsTable.FirstOrDefault(x => x.EmpId == EmpName_or_EmpId);
                }
            }
            return null;
        }
        [HttpPost]
        public IEnumerable<Visitors> InsertVistedPeoples(Visitors visitors)
        {
            _applicationContext.VisitorsTable.Add(visitors);
            _applicationContext.SaveChanges();
            return _applicationContext.VisitorsTable;
        }
    }
}
