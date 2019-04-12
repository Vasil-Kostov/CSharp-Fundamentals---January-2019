namespace _03BarracksFactory
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class AppEntryPoint
    {
        static void Main()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<IUnitFactory, UnitFactory>();
            services.AddSingleton<IRepository, UnitRepository>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            CommandInterpreter commandInterpreter = new CommandInterpreter(serviceProvider);

            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
