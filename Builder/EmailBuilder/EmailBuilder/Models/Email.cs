using System;
using System.Collections.Generic;
using System.Text;

namespace EmailBuilder.Models
{
    public class Email
    {
        public Person Sender { get; set; }

        public ICollection<Person> Receiver { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
