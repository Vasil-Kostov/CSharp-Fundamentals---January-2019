namespace _01.Logger.Loggers.Contracts
{
    public interface ILogFile
    {
        void Wrte(string message);

        int Size { get; }
    }
}
