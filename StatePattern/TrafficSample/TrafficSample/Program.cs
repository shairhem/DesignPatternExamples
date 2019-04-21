using System;
using TrafficSample.Factories;
using TrafficSample.TrafficLights;
using TrafficSample.TrafficLights.Light;

namespace TrafficSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var trafficLight = new TrafficLight();
            var factory = new LightFactory();
            trafficLight.SetState(factory.GetNextState("red"));

            while(true)
            {
                Console.WriteLine($"CurrentState: {trafficLight.GetState().ToString()}");
                Console.WriteLine($"Can Proceed: {trafficLight.GetState().CanProceed()}");
                Console.WriteLine("====================================================");
            }
        }
    }
}
