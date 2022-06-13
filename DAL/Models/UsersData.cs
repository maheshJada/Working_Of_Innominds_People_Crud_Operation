using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

public enum RegistrationStatus
{
    UserExists,
    UserCreationFailed,
    UserCreationSuccess
}
namespace DAL.Models
{
    public class UsersData
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }
    //public class UserRules
    //{
    //    public const string Admin = "Admin";
    //    public const string User = "User";
    //}
    public class LoginReponse
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public bool Success { get; set; }
    }
    public class UserRegistrationResponse
    {
        public RegistrationStatus RegistrationStatus { get; set; }
    }
    public class ForgotResponce
    {
        public string Message { get; set; }
    }
}
