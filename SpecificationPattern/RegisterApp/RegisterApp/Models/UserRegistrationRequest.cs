using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterApp.Models
{
    public class UserRegistrationRequest
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordConfirmation { get; set; }

        public UserRegistrationRequest(string username, string email, string password, string passwordConfirmation)
        {
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.PasswordConfirmation = passwordConfirmation;
        }
    }
}
