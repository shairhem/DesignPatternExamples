using EmailBuilder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailBuilder.BuildDirector
{
    public interface IEmailBuildDirector
    {
        Email BuildEmail(Person sender, Person receiver, string subject, string message);
    }
}
