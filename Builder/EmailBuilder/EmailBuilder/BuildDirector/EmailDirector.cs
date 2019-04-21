using System;
using System.Collections.Generic;
using System.Text;
using EmailBuilder.Builder;
using EmailBuilder.Models;

namespace EmailBuilder.BuildDirector
{
    public class EmailDirector : IEmailBuildDirector
    {
        private readonly IEmailBuilder emailBuilder;

        public EmailDirector(IEmailBuilder emailBuilder)
        {
            this.emailBuilder = emailBuilder;
        }

        public Email BuildEmail(Person sender, Person receiver, string subject, string message)
        {
            var email = this.emailBuilder
                .AddMessage(message)
                .AddSubject(subject)
                .AddSender(sender)
                .AddReceiver(receiver)
                .Build();

            return email;
        }
    }
}
