using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterApp.Services
{
    public interface IUserService
    {
        void RegisterUser(User user);
    }
}
