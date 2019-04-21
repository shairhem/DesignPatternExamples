using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample.Loggers
{
    public interface ICustomLogger
    {
        void LogInfo(string message);
    }
}
