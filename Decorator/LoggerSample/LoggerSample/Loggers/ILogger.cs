namespace LoggerSample.Loggers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ILogger
    {
        void LogInfo(string message);

        void LogError(string message);

        void LogWarning(string message);
    }
}
