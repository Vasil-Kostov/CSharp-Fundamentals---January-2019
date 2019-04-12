namespace _03BarracksFactory.Core
{
    using Contracts;
    using Commandss;
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Linq;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            commandName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(commandName.ToLower());

            var type = Type.GetType($"{typeof(Command).Namespace}.{commandName}Command");

            var fieldsToInject = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(f => f.CustomAttributes.Any(a => a.AttributeType == typeof(InjectAttribute)));

            var fields = fieldsToInject
                .Select(f => this.serviceProvider.GetService(f.FieldType));

            var instance = Activator.CreateInstance(type, new object[] { data }.Concat(fields).ToArray());

            return (IExecutable)instance;
        }
    }
}
