using System;
using System.Collections.Generic;
using System.Text;
using TrafficSample.TrafficLights.Light;

namespace TrafficSample.Factories
{
    public interface ILightFactory
    {
        ILight GetNextState(string state);
    }
}
