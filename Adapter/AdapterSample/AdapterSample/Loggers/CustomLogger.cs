using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample.Loggers
{
    public class CustomLogger : ICustomLogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"[CustomLogger] {message}");
        }
    }
}
