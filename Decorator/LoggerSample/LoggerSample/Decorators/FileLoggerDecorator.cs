using LoggerSample.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerSample.Decorators
{
    public class FileLoggerDecorator : ILogger
    {
        private readonly ILogger logger;

        public FileLoggerDecorator(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogError(string message)
        {
            this.logger.LogError(message);
            Console.WriteLine($"[File ERR]: {message}");
        }

        public void LogInfo(string message)
        {
            this.logger.LogInfo(message);
            Console.WriteLine($"[File INF]: {message}");
        }

        public void LogWarning(string message)
        {
            this.logger.LogWarning(message);
            Console.WriteLine($"[File WRN]: {message}");
        }
    }
}
