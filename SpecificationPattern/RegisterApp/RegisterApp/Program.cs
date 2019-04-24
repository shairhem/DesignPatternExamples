using RegisterApp.Controllers;
using RegisterApp.Models;
using RegisterApp.Services;

namespace RegisterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = new UserService();
            var controller = new UserController(userService);
            var user = new UserRegistrationRequest("shairhem","shairhem@gmail.com","password","password");
            controller.RegisterUser(user);
        }
    }
}
