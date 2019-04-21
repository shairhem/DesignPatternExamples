using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrafficSample.Factories;

namespace TrafficSample.TrafficLights.Light
{
    public class RedLight : ILight
    {
        private readonly string color;
        private readonly double durationInSeconds;
        private readonly ILightFactory lightFactory;
        private readonly ILight successor;

        public RedLight(ILightFactory lightFactory)
        {
            this.color = "red";
            this.durationInSeconds = 20;
            this.lightFactory = lightFactory;
        }

        public bool CanProceed()
        {
            return false;
        }

        public async Task ScheduleStateChange(ITrafficLight trafficLight)
        {
            Console.WriteLine(this.color);
            await Task.Delay(TimeSpan.FromSeconds(this.durationInSeconds));
            trafficLight.SetState(this.lightFactory.GetNextState(this.color));
        }
    }
}
