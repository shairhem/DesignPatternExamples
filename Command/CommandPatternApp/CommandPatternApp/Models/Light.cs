using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternApp.Models
{
    public class Light
    {
        private bool isOn;

        private int brightnessLevel;

        public Light(bool isOn, int brightnessLevel)
        {
            this.isOn = isOn;
            this.brightnessLevel = brightnessLevel;
        }

        public void AddBrightnessLevel(int brightnessLevel)
        {
            this.brightnessLevel += brightnessLevel;
        }

        public void SwitchOn(bool isOn)
        {
            this.isOn = isOn;
        }

        public void PrintState()
        {
            Console.WriteLine($"Is on? {this.isOn}");
            Console.WriteLine($"Brightness Level: {this.brightnessLevel}");
        }
    }
}
