namespace _01.Logger
{
    using Core;
    using Core.Contracts;

    class Startup
    {
        static void Main()
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();

            Engine engine = new Engine(commandInterpreter);

            engine.Run();
        }
    }
}
