using EmailBuilder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailBuilder.Builder
{
    public interface IEmailBuilder
    {
        IEmailBuilder AddSubject(string subject);

        IEmailBuilder AddMessage(string message);

        IEmailBuilder AddSender(Person sender);

        IEmailBuilder AddReceiver(Person receiver);

        IEmailBuilder AddReceivers(ICollection<Person> receivers);

        Email Build();
    }
}
