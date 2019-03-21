namespace _01.Logger.Loggers
{
    using Contracts;
    using System.Linq;

    public class LogFile : ILogFile
    {
        public int Size { get; private set; }

        public void Wrte(string message)
        {
            this.Size += message.Where(char.IsLetter).Sum(x => x);
        }
    }
}
