using System;
using System.Collections.Generic;
using System.Text;
using TrafficSample.TrafficLights.Light;

namespace TrafficSample.TrafficLights
{
    public interface ITrafficLight
    {
        ILight GetState();

        void SetState(ILight trafficLight);
    }
}
