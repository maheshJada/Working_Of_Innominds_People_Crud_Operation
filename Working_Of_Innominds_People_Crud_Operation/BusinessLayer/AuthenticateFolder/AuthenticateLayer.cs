using DAL.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Working_Of_Innominds_People_Crud_Operation.BusinessLayer.AuthenticateFolder
{
    public class AuthenticateLayer : IAuthenticateLayer
    {
        private readonly IAuthenticate Authenticate;
        public AuthenticateLayer(IAuthenticate authenticate)
        {
            Authenticate = authenticate;
        }
        public Task<LoginReponse> Login(Login model)
        {
            return Authenticate.Login(model);
        }

        public Task<UserRegistrationResponse> RegisterAdmin(UsersData model)
        {
            return Authenticate.RegisterAdmin(model);
        }
    }
}
