using ConsoleApp1.Observer;
using ConsoleApp1.Subject;
using System;

namespace ConsoleApp1
{
    

    public class Program
    {
        static void Main(string[] args)
        {
            var subject = new ConcreteSubject();
            var fileObserver = new FileObserver(subject);
            var insightsObserver = new InsightsObserver(subject);

            subject.Value = "Change this value";
            subject.Notify();
        }
    }
}
