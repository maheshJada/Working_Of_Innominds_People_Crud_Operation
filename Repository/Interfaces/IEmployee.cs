using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.Models;

namespace Working_Of_Innominds_People_Crud_Operation.ServiceLayer.Interfaces
{
    /// <summary>
    /// It is a Employee Interface class 
    /// </summary>
    public interface IEmployee
    {
        #region EmployeeInterfaceMethods

        /// <summary>
        /// Get the Employee info 
        /// </summary>
        /// <returns>return the whole  Employee data </returns>
        IEnumerable<Employee> GetAllEmployee();
        /// <summary>
        /// Insert the Employee data  
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>It will returns the Inserted Employee data</returns>
        IEnumerable<Employee> InsertEmployee(Employee employee);
        /// <summary>
        /// It will serach based on our requirement
        /// </summary>
        /// <param name="EmpName_or_EmpId"></param>
        /// <returns>It will returns the Serched data</returns>
        Employee GetByDataBasedOnEmpNameOrEmpId(string EmpName_or_EmpId);
        /// <summary>
        ///If we want to modify the data Update the Employee data 
        /// </summary>
        /// <param name="category"></param>
        /// <returns>It will returns the Updated data</returns>
        IEnumerable<Employee> UpdateData(Employee category);
        /// <summary>
        /// Delete the EmpId info belongs to Employee
        /// </summary>
        /// <param name="EmpId">it will check the Employee Id </param>
        /// <returns>It returns true if it is Deleted otherwise it will returns false</returns>
        bool Delete(int EmpId);

        #endregion
    }
}
