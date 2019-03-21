namespace _01.Logger.Loggers.Contracts
{
    public interface ILogger
    {
        void Info(string dateTime, string infoMessage);

        void Warning(string dateTime, string warningMessage);

        void Error(string dateTime, string errorMessage);

        void Critical(string dateTime, string criticalMessage);

        void Fatal(string dateTime, string fatalMessage);
    }
}
