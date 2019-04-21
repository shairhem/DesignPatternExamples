using ConsoleApp1.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Subject
{
    public interface ISubject
    {
        string Value { get; set; }

        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
