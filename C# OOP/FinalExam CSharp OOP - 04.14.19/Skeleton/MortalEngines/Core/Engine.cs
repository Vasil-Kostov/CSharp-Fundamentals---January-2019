namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;

    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine : IEngine
    {
        private IMachinesManager machinesManager;

        public Engine()
        {
            this.machinesManager = new MachinesManager();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "Quit")
            {
                string[] commandArgs = command.Split();

                string message = string.Empty;

                try
                {
                    switch (commandArgs[0])
                    {
                        case "HirePilot":
                            message = this.machinesManager.HirePilot(commandArgs[1]);
                            break;
                        case "PilotReport":
                            message = this.machinesManager.PilotReport(commandArgs[1]);
                            break;
                        case "ManufactureTank":
                            message = this.machinesManager.ManufactureTank(commandArgs[1], double.Parse(commandArgs[2]), double.Parse(commandArgs[3]));
                            break;
                        case "ManufactureFighter":
                            message = this.machinesManager.ManufactureFighter(commandArgs[1], double.Parse(commandArgs[2]), double.Parse(commandArgs[3]));
                            break;
                        case "MachineReport":
                            message = this.machinesManager.MachineReport(commandArgs[1]);
                            break;
                        case "AggressiveMode":
                            message = this.machinesManager.ToggleFighterAggressiveMode(commandArgs[1]);
                            break;
                        case "DefenseMode":
                            message = this.machinesManager.ToggleTankDefenseMode(commandArgs[1]);
                            break;
                        case "Engage":
                            message = this.machinesManager.EngageMachine(commandArgs[1], commandArgs[2]);
                            break;
                        case "Attack":
                            message = this.machinesManager.AttackMachines(commandArgs[1], commandArgs[2]);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    message = "Error: " + ex.Message; // Is there whiteSpace after Erroe:
                }

                Console.WriteLine(message);

                command = Console.ReadLine();
            }
        }
    }
}
