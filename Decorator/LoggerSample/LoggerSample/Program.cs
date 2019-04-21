using LoggerSample.Decorators;
using LoggerSample.Loggers;
using System;

namespace LoggerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "Hello World!";

            var logger = new ConsoleLogger();
            logger.LogInfo(message);

            // decorate to log into file
            var fileLogger = new FileLoggerDecorator(logger);
            fileLogger.LogInfo(message);

            // decorate console logger to log to insights;
            var insightsLogger = new InsightsLoggerDecorator(logger);
            insightsLogger.LogInfo(message);

            // decorate the decorate
            var allLogger = new InsightsLoggerDecorator(fileLogger);
            allLogger.LogInfo(message);
        }
    }
}
