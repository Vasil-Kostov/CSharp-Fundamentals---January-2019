namespace _01.Logger.Appenders
{
    using Contracts;
    using Layouts.Contracts;
    using Loggers.Enums;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public int MessagesAppended { get; protected set; }

        public ILayout Layout { get; private set; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, " +
                    $"Layout type: {this.Layout.GetType().Name}, " +
                    $"Report level: {this.ReportLevel}, " +
                    $"Messages appended: {this.MessagesAppended}";
        }
    }
}
