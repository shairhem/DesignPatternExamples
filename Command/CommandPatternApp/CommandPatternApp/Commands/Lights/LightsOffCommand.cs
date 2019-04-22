using CommandPatternApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternApp.Commands.Lights
{
    public class LightsOffCommand : ICommand
    {
        private readonly Light light;

        public LightsOffCommand()
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.SwitchOn(false);
        }
    }
}
