namespace _01.Logger.Appenders.Contracts
{
    using Layouts.Contracts;

    interface IAppenderFactory
    {
        IAppender CreateAppender(string appenderType, ILayout layout);
    }
}
