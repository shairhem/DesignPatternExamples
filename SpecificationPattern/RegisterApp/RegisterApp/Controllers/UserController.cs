using RegisterApp.Factories;
using RegisterApp.Models;
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
        private readonly ISpecificationFactory<UserRegistrationRequest> registrationSpecificationFactory;

        public UserController(IUserService userService, ISpecificationFactory<UserRegistrationRequest> registrationSpecificationFactory)
        {
            this.userService = userService;
            this.registrationSpecificationFactory = registrationSpecificationFactory;
        }

        public void RegisterUser(UserRegistrationRequest request)
        {
            var spec = this.registrationSpecificationFactory.CreateSpecification();
            if (spec.IsSatisfiedBy(request))
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
