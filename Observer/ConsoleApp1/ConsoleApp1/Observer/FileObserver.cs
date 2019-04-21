using ConsoleApp1.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Observer
{
    public class FileObserver : IObserver
    {
        private readonly ISubject subject;

        public FileObserver(ISubject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"{this.subject.Value} is written to file");
        }
    }
}
