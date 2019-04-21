using ConsoleApp1.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Observer
{
    public class InsightsObserver : IObserver
    {
        private readonly ISubject subject;

        public InsightsObserver(ISubject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"{this.subject.Value} has been sent to insights");
        }
    }
}
