using CommandPatternApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternApp.Commands.Lights
{
    public class DecreaseBrightnessCommand : ICommand
    {
        private readonly Light light;

        public DecreaseBrightnessCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.AddBrightnessLevel(-1);
        }
    }
}
