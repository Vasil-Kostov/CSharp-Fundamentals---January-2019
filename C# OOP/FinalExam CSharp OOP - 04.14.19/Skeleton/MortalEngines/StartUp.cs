namespace MortalEngines
{
    using Core.Contracts;
    using MortalEngines.Core;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();

            engine.Run();
        }
    }
}