using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.Models;

namespace Working_Of_Innominds_People_Crud_Operation.ServiceLayer.Interfaces
{
    public interface InIT
    {
        #region ITRelated Interface Methods

        /// <summary>
        /// Get the Employee info 
        /// </summary>
        /// <returns>return the whole  Employee data </returns>
        IEnumerable<It> GetEmployeeLaptopData();
        /// <summary>
        /// It will perform the insertion operation
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>It will append the data to the table</returns>
        IEnumerable<It> CreateOrGiveTheLaptop(It employee);
        /// <summary>
        /// It will search the data based on EmpName_or_EmpId
        /// </summary>
        /// <param name="EmpName_or_EmpId"></param>
        /// <returns>It will returns the Searched data</returns>
        It GetByEmployeeLaptopDataBasedOnEmpNameOrEmpId(string EmpName_or_EmpId);
        /// <summary>
        /// It will perform the modification of the content
        /// </summary>
        /// <param name="it"></param>
        /// <returns>It will returns the updated data</returns>
        IEnumerable<It> UpdateOrChangeTheEmployeeLaptop(It it);
       /// <summary>
       /// it wiil check to delete the poarticular data
       /// </summary>
       /// <param name="it"></param>
       /// <returns>it will delete the data</returns>
        bool Delete(int it);

        #endregion
    }
}
