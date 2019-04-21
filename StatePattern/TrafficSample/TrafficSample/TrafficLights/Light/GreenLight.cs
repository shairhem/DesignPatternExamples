using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrafficSample.Factories;

namespace TrafficSample.TrafficLights.Light
{
    public class GreenLight : ILight
    {
        private readonly string color;
        private readonly double durationInSeconds;
        private readonly ILightFactory lightFactory;
        public GreenLight(ILightFactory lightFactory)
        {
            this.color = "green";
            this.durationInSeconds = 20;
            this.lightFactory = lightFactory;
        }

        public string GetColor()
        {
            return this.color;
        }

        public bool CanProceed()
        {
            return true;
        }

        public async Task ScheduleStateChange(ITrafficLight trafficLight)
        {
            Console.WriteLine(this.color);
            await Task.Delay(TimeSpan.FromSeconds(this.durationInSeconds));
            trafficLight.SetState(this.lightFactory.GetNextState(this.color));
        }
    }
}
