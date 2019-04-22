using CommandPatternApp.Commands.Lights;
using CommandPatternApp.Invoker;
using CommandPatternApp.Models;
using System;

namespace CommandPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var light = new Light(false, 0);
            var remote = new Remote();
            remote.AddCommand(new LightsOnCommand(light));
            remote.AddCommand(new IncreaseBrightnessLevel(light));
            remote.AddCommand(new IncreaseBrightnessLevel(light));
            remote.AddCommand(new IncreaseBrightnessLevel(light));
            remote.ExecuteCommands();

            light.PrintState();
        }
    }
}
