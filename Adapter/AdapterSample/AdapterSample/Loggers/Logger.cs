using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample.Loggers
{
    public class Logger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"[Log] {message}");
        }
    }
}
