using System;
using System.Collections.Generic;
using System.Text;
using TrafficSample.TrafficLights.Light;

namespace TrafficSample.Factories
{
    public class LightFactory : ILightFactory
    {
        private readonly Dictionary<string, ILight> lightSuccessor;

        public LightFactory()
        {
            this.lightSuccessor = new Dictionary<string, ILight>();
            this.lightSuccessor.Add("red", new GreenLight(this));
            this.lightSuccessor.Add("yellow", new RedLight(this));
            this.lightSuccessor.Add("green", new RedLight(this));
        }

        public ILight GetNextState(string state)
        {
            return this.lightSuccessor[state];
        }
    }
}
