namespace _01.Logger.Core
{
    using Contracts;
    using System;

    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            int numberOfAppenders = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfAppenders; i++)
            {
                string[] appenderArgs = Console.ReadLine().Split();

                this.commandInterpreter.AddAppender(appenderArgs);
            }

            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] reportArgs = line.Split('|');

                this.commandInterpreter.AddReport(reportArgs);

                line = Console.ReadLine();
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}
