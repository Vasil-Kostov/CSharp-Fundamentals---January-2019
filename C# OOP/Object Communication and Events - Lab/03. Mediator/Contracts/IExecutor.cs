namespace Heroes.Contracts
{
    public interface IExecutor
    {
        void ExecuteCommand(ICommand command);
    }
}
