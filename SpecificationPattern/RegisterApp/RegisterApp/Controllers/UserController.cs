﻿using RegisterApp.Models;
using RegisterApp.Services;
using RegisterApp.Specifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterApp.Controllers
{
    public class UserController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public void RegisterUser(UserRegistrationRequest request)
        {
            var validEmail = new ValidEmailSpecification();
            var validUsername = new ValidUsernameSpecification();
            var validPassword = new ValidPasswordSpecification();
            var passwordConfirmed = new PasswordConfirmedSpecification();
            var validRequest = validEmail.And(validUsername).And(validPassword).And(passwordConfirmed);
            if (validRequest.IsSatisfiedBy(request))
            {
                var user = new User() { Username = request.Username, Email = request.Email, Password = request.Password };
                this.userService.RegisterUser(user);
            }
            else
            {
                Console.WriteLine("Request is not valid");
            }
        }
    }
}
