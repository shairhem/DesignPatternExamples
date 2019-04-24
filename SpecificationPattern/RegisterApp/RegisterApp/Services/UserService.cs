using System;
using System.Collections.Generic;
using System.Text;
using RegisterApp.Models;

namespace RegisterApp.Services
{
    public class UserService : IUserService
    {
        public void RegisterUser(User user)
        {
            Console.WriteLine("Registration successful!");
        }
    }
}
