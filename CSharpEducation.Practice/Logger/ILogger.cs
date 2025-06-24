namespace Logger
{
    public enum LogLevel
    { 
        Trace,
        Info,
        Debug,
        Warning,
        Error,
        Fatal
    }
    public interface ILogger
    {
        void Trace(string message);
        void Info(string message);
        void Debug(string message);
        void Warning(string message);
        void Error(string message);
        void Fatal(string message);
        void Log(string message, LogLevel level);
    }
}
