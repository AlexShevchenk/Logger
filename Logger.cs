using System;
using System.Collections.Generic;

namespace LoggerExample
{
    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();
        private readonly List<string> logs;

        static Logger() { }

        private Logger()
        {
            logs = new List<string>();
        }

        public static Logger Instance
        {
            get
            {
                return instance;
            }
        }

        public void Log(string message, LogType logType)
        {
            string formattedMessage = $"{DateTime.Now}: {logType}: {message}";
            Console.WriteLine(formattedMessage);
            logs.Add(formattedMessage);
        }

        public string GetAllLogs()
        {
            return string.Join(Environment.NewLine, logs);
        }
    }

    public enum LogType
    {
        Error,
        Info,
        Warning
    }
}