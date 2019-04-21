using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSample.TrafficLights.Light
{
    public interface ILight
    {
        bool CanProceed();

        Task ScheduleStateChange(ITrafficLight trafficLight);
    }
}
