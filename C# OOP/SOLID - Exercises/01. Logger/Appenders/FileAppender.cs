namespace _01.Logger.Appenders
{
    using Layouts.Contracts;
    using Loggers.Contracts;
    using Loggers.Enums;
    using System.IO;

    public class FileAppender : Appender
    {
        private const string Path = "../../../log.txt";
        private ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                string fullMessage = string.Format(this.Layout.Format, dateTime, reportLevel, message);

                File.AppendAllText(Path, fullMessage);
                
                this.MessagesAppended++;

                this.logFile.Wrte(fullMessage);
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.logFile.Size}";
        }
    }
}
