namespace _03BarracksFactory.Core.Commandss
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;

        public Command(string[] data)
        {
            this.data = data;
        }

        protected string[] Data => this.data;

        public abstract string Execute();
    }
}
