using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.BusinessLayer.AuthenticateFolder;

namespace Working_Of_Innominds_People_Crud_Operation.Controllers.Authentication
{

    public class AuthenticationController : Controller
    {
        private readonly IAuthenticateLayer AuthenticateLayer;
        public AuthenticationController(IAuthenticateLayer authenticateLayer)
        {
            AuthenticateLayer = authenticateLayer;
           
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> SignUp(UsersData regModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new IdentityUser { UserName = regModel.UserName, Email = regModel.Email };
        //        var result = await userManager.CreateAsync(user, regModel.Password);
        //        if (result.Succeeded)
        //        {
        //            await _signInManager.SignInAsync(user, isPersistent: false);
        //            //return RedirectToAction("Login", "Login");
        //            return RedirectToAction("Login");
        //        }
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError(string.Empty, error.Description);
        //        }
        //    }
        //    return View(regModel);
        //}

        [HttpPost]
        public async Task<IActionResult> SignUp(UsersData regModel)
        {
            var response = await AuthenticateLayer.RegisterAdmin(regModel);
            switch (response.RegistrationStatus)
            {
                case RegistrationStatus.UserCreationSuccess:
                    return RedirectToAction("Login");
                case RegistrationStatus.UserCreationFailed:
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });
                case RegistrationStatus.UserExists:
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });
            };
            return View(regModel);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> Login(Login logModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var data = await userManager.FindByEmailAsync(logModel.Email);
        //        if (data != null)
        //        {
        //            var result = await _signInManager.PasswordSignInAsync(data.UserName, logModel.Password, false, false);
        //            if (result.Succeeded)
        //            {
        //                return RedirectToAction("Index", "Employees");
        //            }
        //            ModelState.AddModelError(string.Empty, "Invalid loginattempt");
        //        }

        //    }
        //    return View(logModel);
        //}
        [HttpPost]
        public async Task<IActionResult> Login(Login logModel)
        {
            var response = await AuthenticateLayer.Login(logModel);
            if (response.Success)
                return RedirectToAction("Index", "Employees");
            else
                ModelState.AddModelError(" ", " Email and Password are not matching");
            return View(logModel);
        }
    }
}
