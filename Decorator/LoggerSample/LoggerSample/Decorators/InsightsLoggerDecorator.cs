using LoggerSample.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerSample.Decorators
{
    public class InsightsLoggerDecorator : ILogger
    {
        private readonly ILogger logger;

        public InsightsLoggerDecorator(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogError(string message)
        {
            this.logger.LogError(message);
            Console.WriteLine($"[Insights ERR]: {message}");
        }

        public void LogInfo(string message)
        {
            this.logger.LogInfo(message);
            Console.WriteLine($"[Insights INF]: {message}");
        }

        public void LogWarning(string message)
        {
            this.logger.LogWarning(message);
            Console.WriteLine($"[Insights WRN]: {message}");
        }
    }
}
