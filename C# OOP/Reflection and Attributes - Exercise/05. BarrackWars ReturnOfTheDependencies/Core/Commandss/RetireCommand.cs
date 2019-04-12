namespace _03BarracksFactory.Core.Commandss
{
    using Contracts;

    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data, IRepository repository)
            : base(data)
        {
            this.repository = repository;
        }

        public override string Execute()
        {
            string unitType = Data[1];
            this.repository.RemoveUnit(unitType);

            return $"{unitType} retired!";
        }
    }
}
