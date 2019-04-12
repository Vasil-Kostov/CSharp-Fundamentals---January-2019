namespace Heroes.Commands
{
    using Contracts;

    public class CommandExecutor : IExecutor
    {
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
