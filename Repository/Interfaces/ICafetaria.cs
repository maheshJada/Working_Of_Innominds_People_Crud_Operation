using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.Models;

namespace Working_Of_Innominds_People_Crud_Operation.ServiceLayer.Interfaces
{
    /// <summary>
    /// cafeteria interface class
    /// </summary>
    public interface ICafetaria
    {
        #region Cafeteria inferface mathods

        /// <summary>
        /// It perform the Getting the All cafetaerai details in the list form
        /// </summary>
        /// <returns>It will returns the All cafetaria data</returns>
        IEnumerable<Cafetaria> GetAllCafetariaDetails();
        /// <summary>
        /// It will describe to create the cafetaria data info....
        /// </summary>
        /// <param name="cafetaria"></param>
        /// <returns>It will returns the true or false when you insert the data</returns>
        bool InsertData(Cafetaria cafetaria);
        /// <summary>
        /// It will perform the get the details based on datetime
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>it will returns the data based on the datetime</returns>
        List<CafeteriaOperation> GetItemsByDate(DateTime dateTime);
        /// <summary>
        /// it will perform the put(edit) the data operation
        /// </summary>
        /// <param name="cafetaria"></param>
        /// <returns>it will returns the modified data </returns>
        bool UpdateTheItems(Cafetaria cafetaria);
        /// <summary>
        /// it will perform the delete operation vbased on datetime
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>It will returns the true or false when you perform the delete  </returns>
        bool DeleteTheItemsByDate(DateTime dateTime);
        /// <summary>
        /// It will perform the getting the particular data of lastely added
        /// </summary>
        /// <returns>It will returns the Last added data </returns>
        Cafetaria GetTheLastAddedData();
        #endregion
    }
}
