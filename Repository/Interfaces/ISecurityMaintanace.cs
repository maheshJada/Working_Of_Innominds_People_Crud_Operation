using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.Models;

namespace Working_Of_Innominds_People_Crud_Operation.ServiceLayer.Interfaces
{
    /// <summary>
    /// It is SecurityMaintanace interface class
    /// </summary>
    public interface ISecurityMaintanace
    {
        #region it is a securty maintance interface mathods

        /// <summary>
        /// It will Describe the Maintanace data info
        /// </summary>
        /// <returns>It will return the All Maintance data</returns>
        IEnumerable<SecuritySystemMaintanace> GetAllMaintanceData();
        /// <summary>
        /// It will describe the insertopertion info... 
        /// </summary>
        /// <param name="maintanace"></param>
        /// <returns>it will return the inserted maintains data</returns>
        IEnumerable<SecuritySystemMaintanace> InsertTheThings(SecuritySystemMaintanace maintanace);
        /// <summary>
        /// It will describe the Particular maintainace info...
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>It will return the Particular id data</returns>
        SecuritySystemMaintanace GetByParticularThing(int Id);
        IEnumerable<SecuritySystemMaintanace> UpdateTheThings(SecuritySystemMaintanace maintanace);
        /// <summary>
        /// It will descibe the Delete operation based on id info.....
        /// </summary>
        /// <param name="id"></param>
        /// <returns>It will return the true or false when you do the delete opertaion</returns>
        bool DeleteTheThings(int id);

        #endregion
    }
}
