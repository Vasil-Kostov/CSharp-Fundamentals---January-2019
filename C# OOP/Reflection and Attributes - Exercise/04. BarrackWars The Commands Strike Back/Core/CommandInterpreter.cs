namespace _03BarracksFactory.Core
{
    using Contracts;
    using Commandss;
    using System;
    using System.Globalization;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private readonly IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            commandName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(commandName.ToLower());

            var type = Type.GetType($"{typeof(Command).Namespace}.{commandName}Command");

            var instance = Activator.CreateInstance(type, new object[] { data, repository, unitFactory });

            return (IExecutable)instance;
        }
    }
}
