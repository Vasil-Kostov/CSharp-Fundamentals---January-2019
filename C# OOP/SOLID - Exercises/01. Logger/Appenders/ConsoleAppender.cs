namespace _01.Logger.Appenders
{
    using Layouts.Contracts;
    using Loggers.Enums;
    using System;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                Console.WriteLine(
                    string.Format(this.Layout.Format, dateTime, reportLevel, message));

                this.MessagesAppended++;
            }
        }
    }
}
