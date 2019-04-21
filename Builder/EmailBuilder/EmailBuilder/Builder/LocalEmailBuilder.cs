using System;
using System.Collections.Generic;
using System.Text;
using EmailBuilder.Models;

namespace EmailBuilder.Builder
{
    public class LocalEmailBuilder : IEmailBuilder
    {
        private readonly Email email;

        public LocalEmailBuilder()
        {
            this.email = new Email();
        }
        
        public IEmailBuilder AddMessage(string message)
        {
            this.email.Message = message;
            return this;
        }

        public IEmailBuilder AddReceiver(Person receiver)
        {
            if(this.email.Receiver == null)
            {
                this.email.Receiver = new List<Person>();
            }

            this.email.Receiver.Add(receiver);
            return this;
        }

        public IEmailBuilder AddReceivers(ICollection<Person> receivers)
        {
            foreach (var receiver in receivers) {
                this.AddReceiver(receiver);
            }

            return this;
        }

        public IEmailBuilder AddSender(Person sender)
        {
            this.email.Sender = sender;
            return this;
        }

        public IEmailBuilder AddSubject(string subject)
        {
            this.email.Subject = subject;
            return this;
        }

        public Email Build()
        {
            return email;
        }
    }
}
