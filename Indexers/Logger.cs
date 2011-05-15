using System;
using Interfaces;

namespace Logic
{
    public delegate void LoggerCallback(IRequest request, bool found);

    public class Logger
    {
        private Logger(LoggerCallback callback)
        {
            ReportEvent += callback;
        }

        public static void CreateLogger(LoggerCallback callback)
        {
            new Logger(callback);
        }

        private static event LoggerCallback ReportEvent;

        public static void Report(IRequest request, bool found)
        {
            LoggerCallback handler = ReportEvent;
            if (handler != null) handler(request, found);
        }
    }
}