using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Working_Of_Innominds_People_Crud_Operation.BusinessLayer.AuthenticateFolder
{
    public interface IAuthenticateLayer
    {
        #region AuthenticateLayer Interface Mathods
        /// <summary>
        /// It will validate the email and password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>It will login or generate the Token</returns>
        Task<LoginReponse> Login(Login model);
        /// <summary>
        /// it will perform the signup operation
        /// </summary>
        /// <param name="model"></param>
        /// <returns>It will returns  the true or false whenever you can signup</returns>
        Task<UserRegistrationResponse> RegisterAdmin(UsersData model);
        #endregion
    }
}
