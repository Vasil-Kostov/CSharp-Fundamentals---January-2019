namespace Heroes.Loggers
{
    using Contracts;
    using Enums;

    public abstract class Logger : IHandler
    {
        private IHandler successor;

        public abstract void Handle(LogType type, string message);

        protected void PassToSuccessor(LogType type, string message)
        {
            this.successor?.Handle(type, message);
        }

        public void SetSuccessor(IHandler successor)
        {
            this.successor = successor;
        }
    }
}
