using System;
namespace Logger
{
    public class ConsoleLogger : ILogger
    {
        private readonly string _className;

        public ConsoleLogger(Type classType)
        {
            _className = classType.Name;
        }
        public void Trace(string message)
        {
            Log(message, LogLevel.Trace);
        }
        public void Info(string message)
        {
            Log(message, LogLevel.Info);
        }
        public void Debug(string message)
        {
            Log(message, LogLevel.Debug);
        }
        public void Warning(string message)
        {
            Log(message, LogLevel.Warning);
        }
        public void Error(string message)
        {
            Log(message, LogLevel.Error);
        }
        public void Fatal(string message)
        {
            Log(message, LogLevel.Fatal);
        }
        public void Log(string message, LogLevel level)
        {
            Console.WriteLine(DateTime.Now + " | " + _className + " | " + level + " | " + message);
        }
    }
}
