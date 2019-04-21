using EmailBuilder.BuildDirector;
using EmailBuilder.Models;
using System;

namespace EmailBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new EmailDirector();

            var sender = new Person()
            {
                Email = "shairhem@gmail.com",
                Name = "Shairhem Fernandez"
            };

            var email = directory.BuildEmail(sender, sender, "Re: utang", "dear shairhem, magbayad ka na ng utang mo. Thanks!");

        }
    }
}
