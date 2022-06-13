using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.Models;

namespace Working_Of_Innominds_People_Crud_Operation.ServiceLayer.Interfaces
{
    /// <summary>
    /// It is a Vistors interface class 
    /// </summary>
    public interface IVisitor
    {
        #region Visitors interface mathods


        /// <summary>
        /// It will Describe the All visitors data
        /// </summary>
        /// <returns>It will return the Whole Visitors data</returns>
        IEnumerable<Visitors> GetAllVistedPeeples();
        /// <summary>
        /// It is for the adding data to the table
        /// </summary>
        /// <param name="visitors"></param>
        /// <returns> it will returns the Whole inserted data</returns>
        IEnumerable<Visitors> InsertVistedPeoples(Visitors visitors);
        /// <summary>
        /// it is to search the particular persons data based on EmpName_or_EmpId 
        /// </summary>
        /// <param name="EmpName_or_EmpId"></param>
        /// <returns>It will retern the particular visitor data</returns>
        Visitors GetVistorsDataBasedOnEmpNameOrEmpId(string EmpName_or_EmpId);
        //IEnumerable<Employee> UpdateData(Employee category);

        #endregion
    }
}
