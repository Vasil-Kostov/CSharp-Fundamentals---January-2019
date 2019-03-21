namespace _01.Logger.Loggers
{
    using Appenders.Contracts;
    using Loggers.Contracts;
    using Loggers.Enums;

    public class Logger : ILogger
    {
        private IAppender consoleAppender;
        private IAppender fileAppender;

        public Logger(IAppender consoleAppender)
        {
            this.consoleAppender = consoleAppender;
        }

        public Logger(IAppender consoleAppender, IAppender fileAppender)
            : this(consoleAppender)
        {
            this.fileAppender = fileAppender;
        }

        public void Info(string dateTime, string infoMessage)
        {
            this.Append(dateTime, ReportLevel.INFO, infoMessage);
        }

        public void Warning(string dateTime, string warningMessage)
        {
            this.Append(dateTime, ReportLevel.WARNING, warningMessage);
        }

        public void Error(string dateTime, string errorMessage)
        {
            this.Append(dateTime, ReportLevel.ERROR, errorMessage);
        }

        public void Critical(string dateTime, string criticalMessage)
        {
            this.Append(dateTime, ReportLevel.CRITICAL, criticalMessage);
        }

        public void Fatal(string dateTime, string fatalMessage)
        {
            this.Append(dateTime, ReportLevel.FATAL, fatalMessage);
        }

        private void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            this.consoleAppender?.Append(dateTime, reportLevel, message);
            this.fileAppender?.Append(dateTime, reportLevel, message);
        }
    }
}
