namespace _03BarracksFactory.Core.Commandss
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.data = data;
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        protected string[] Data => this.data;

        protected IRepository Repository => this.repository;

        protected IUnitFactory UnitFactory => this.unitFactory;

        public abstract string Execute();
    }
}
