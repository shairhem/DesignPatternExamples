using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerSample.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            
            Console.WriteLine($"[Console ERR]: {message}");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"[Console INF]: {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"[Console WRN]: {message}");
        }
    }
}
