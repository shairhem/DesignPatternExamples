using EmailBuilder.BuildDirector;
using EmailBuilder.Builder;
using EmailBuilder.Models;
using System;

namespace EmailBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new EmailDirector(new LocalEmailBuilder());

            var sender = new Person()
            {
                Email = "test@gmail.com",
                Name = "Test User"
            };

            var email = directory.BuildEmail(sender, sender, "Re: utang", "dear User, magbayad ka na ng utang mo. Thanks!");

        }
    }
}
