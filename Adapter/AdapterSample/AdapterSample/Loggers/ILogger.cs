using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample.Loggers
{
    public interface ILogger
    {
        void LogInfo(string message);
    }
}
