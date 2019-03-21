namespace _01.Logger.Appenders
{
    using Contracts;
    using Layouts.Contracts;
    using Loggers;
    using System;

    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string appenderType, ILayout layout)
        {
            switch (appenderType.ToLower())
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid appender type");
            }
        }
    }
}
