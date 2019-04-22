using CommandPatternApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternApp.Commands.Lights
{
    public class IncreaseBrightnessLevel : ICommand
    {
        private readonly Light light;

        public IncreaseBrightnessLevel(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.AddBrightnessLevel(1);
        }
    }
}
