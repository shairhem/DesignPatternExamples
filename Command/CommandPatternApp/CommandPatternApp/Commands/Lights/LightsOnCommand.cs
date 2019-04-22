using CommandPatternApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternApp.Commands.Lights
{
    public class LightsOnCommand : ICommand
    {
        private readonly Light light;

        public LightsOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.SwitchOn(true);
        }
    }
}
