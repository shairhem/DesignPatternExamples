using System;
using System.Collections.Generic;
using System.Text;
using TrafficSample.TrafficLights.Light;

namespace TrafficSample.TrafficLights
{
    public class TrafficLight : ITrafficLight
    {
        private ILight state;

        public ILight GetState()
        {
            return this.state;
        }

        public void SetState(ILight trafficLight)
        {
            this.state = trafficLight;
            this.state.ScheduleStateChange(this);
        }   
    }
}
