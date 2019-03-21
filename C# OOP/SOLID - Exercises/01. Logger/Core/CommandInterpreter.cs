namespace _01.Logger.Core
{
    using Appenders;
    using Appenders.Contracts;
    using Contracts;
    using Layouts;
    using Layouts.Contracts;
    using Loggers.Enums;
    using System;
    using System.Collections.Generic;

    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }

        public void AddAppender(string[] args)
        {
            string appenderType = args[0];

            string appenderLayoutType = args[1];
            ILayout layout = this.layoutFactory.CreateLayout(appenderLayoutType);

            ReportLevel reportLevel = args.Length == 3 
                ? Enum.Parse<ReportLevel>(args[2])
                : ReportLevel.INFO;

            IAppender appender = this.appenderFactory.CreateAppender(appenderType, layout);
            appender.ReportLevel = reportLevel;

            this.appenders.Add(appender);
        }

        public void AddReport(string[] args)
        {
            string reportType = args[0];
            string dateTime = args[1];
            string message = args[2];

            foreach (var appender in this.appenders)
            {
                appender.Append(dateTime, Enum.Parse<ReportLevel>(reportType), message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info");

            foreach (var appender in appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
