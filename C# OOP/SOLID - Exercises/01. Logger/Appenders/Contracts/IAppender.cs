namespace _01.Logger.Appenders.Contracts
{
    using Layouts.Contracts;
    using Loggers.Enums;

    public interface IAppender
    {
        ILayout Layout { get; }

        void Append(string dateTime, ReportLevel reportLevel, string message);

        ReportLevel ReportLevel { get; set; }

        int MessagesAppended { get; }
    }
}
