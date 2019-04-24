using RegisterApp.Controllers;
using RegisterApp.Factories;
using RegisterApp.Models;
using RegisterApp.Services;

namespace RegisterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = new UserService();
            var registrationSpecificationFactory = new RegistrationSpecificationFactory();
            var controller = new UserController(userService, registrationSpecificationFactory);

            var user = new UserRegistrationRequest("shairhem","shairhem@gmail.com","password","password");
            controller.RegisterUser(user);

            var user1 = new UserRegistrationRequest("", "shairhem@gmail.com", "password", "password");
            controller.RegisterUser(user1);

            var user2 = new UserRegistrationRequest("shairhem", "shairhem.com", "password", "password");
            controller.RegisterUser(user2);

            var user3 = new UserRegistrationRequest("shairhem", "shairhem.com", "password", "");
            controller.RegisterUser(user3);

            var user4 = new UserRegistrationRequest("shairhem", "shairhem.com", "", "");
            controller.RegisterUser(user4);
        }
    }
}
