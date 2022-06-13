using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.Models;
namespace Working_Of_Innominds_People_Crud_Operation.ServiceLayer.Interfaces
{
    public interface ICourier
    {
        #region Courier interface mathods
        /// <summary>
        /// It will perform the getting the courier employees data
        /// </summary>
        /// <returns>It will returns the all courier employee data</returns>
        IEnumerable<Courier_To_The_Company> GetAllCourierEmployeesData();
        /// <summary>
        /// It will perfor the post the data to the courier table 
        /// </summary>
        /// <param name="courier"></param>
        /// <returns>It will returns the inserted courier employee data</returns>
        IEnumerable<Courier_To_The_Company> InsertTheCourierDetailsToTheRecord(Courier_To_The_Company courier);
        /// <summary>
        /// It will perform the finding the particular data
        /// </summary>
        /// <param name="EmpName_or_EmpId"></param>
        /// <returns>It will returns the particular courier data based on EmpName_or_EmpId</returns>
        Courier_To_The_Company GetParticularEmployeeCourierData(string EmpName_or_EmpId);
        /// <summary>
        /// It will perform the put(update) operation
        /// </summary>
        /// <param name="courier"></param>
        /// <returns>It will change or modify the data based on your requirements</returns>
        IEnumerable<Courier_To_The_Company> UpdateTheEmployeeData(Courier_To_The_Company courier );
        #endregion
    }//class
}//NameSpace
