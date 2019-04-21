using AdapterSample.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample.Adapter
{
    public class LoggerAdapter : ILogger
    {
        private readonly ICustomLogger logger;

        public LoggerAdapter(ICustomLogger logger)
        {
            this.logger = logger;
        }

        public void LogInfo(string message)
        {
            this.logger.LogInfo(message);
        }
    }
}
