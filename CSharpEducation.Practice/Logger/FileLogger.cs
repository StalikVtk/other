using System;
using System.IO;
using System.Runtime.CompilerServices;
namespace Logger
{
    public class FileLogger : ILogger
    {
        private readonly string _className;
        private readonly string _filePath;
        private readonly StreamWriter _write;
        public FileLogger(Type classType, string filePath = "log.txt")
        {
            _className = classType.Name;
            _filePath = filePath;
            try
            {
                _write = new StreamWriter(_filePath, append: true)
                {
                    AutoFlush = true
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
        }
        public void Trace(string message) => Log(message, LogLevel.Trace);
        public void Info(string message) => Log(message, LogLevel.Info);
        public void Debug(string message) => Log(message, LogLevel.Debug);
        public void Warning(string message) => Log(message, LogLevel.Warning);
        public void Error(string message) => Log(message, LogLevel.Error);
        public void Fatal(string message) => Log(message, LogLevel.Fatal);
        public void Log(string message, LogLevel level)
        {
            string messageLog = $"{DateTime.Now} | {_className} | {level} | {message}";
            File.AppendAllText(_filePath, messageLog + Environment.NewLine);
        }
    }
}
