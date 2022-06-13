using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IAuthenticate
    {
        #region Authenticate Interface Mathods
        /// <summary>
        /// It will validate the email and password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>It will login or generate the Token</returns>
        Task<LoginReponse> Login( Login model);
        /// <summary>
        /// it will perform the signup operation
        /// </summary>
        /// <param name="model"></param>
        /// <returns>It will returns  the true or false whenever you can signup</returns>
        Task<UserRegistrationResponse> RegisterAdmin( UsersData model);
        /// <summary>
        /// It will change the Passowrd
        /// </summary>
        /// <param name="model"></param>
        /// <returns>It will give success or fail</returns>
        Task<ForgotResponce> ResetpassWord(Login model);
        #endregion
    }
}
