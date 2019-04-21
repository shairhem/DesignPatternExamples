using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Observer;


namespace ConsoleApp1.Subject
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers;
        public string Value { get; set; }

        public ConcreteSubject()
        {
            this.observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Notifying all observers");
            foreach(var observer in this.observers)
            {
                observer.Update();
            }
        }
    }
}
