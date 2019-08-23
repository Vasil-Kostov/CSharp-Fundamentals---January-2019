namespace MortalEngines.Core
{
    using Contracts;
    using Common;

    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private ICollection<IPilot> pilots;
        private ICollection<IMachine> machines;

        public MachinesManager()
        {
            this.pilots = new List<IPilot>();
            this.machines = new List<IMachine>();
        }

        public string HirePilot(string name)
        {
            if (this.pilots.Any(p => p.Name == name))
            {
                return string.Format(OutputMessages.PilotExists, name);
            }

            this.pilots.Add(new Pilot(name));

            return string.Format(OutputMessages.PilotHired, name);
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.Any(m => m.Name == name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            Tank tank = new Tank(name, attackPoints, defensePoints);
            this.machines.Add(tank);

            string defensive = tank.DefenseMode ? "ON" : "OFF";

            return string.Format(OutputMessages.TankManufactured, name, tank.AttackPoints, tank.DefensePoints, defensive);
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.Any(m => m.Name == name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            IFighter fighter = new Fighter(name, attackPoints, defensePoints);

            this.machines.Add(fighter);

            string agresive = fighter.AggressiveMode ? "ON" : "OFF";

            return string.Format(OutputMessages.FighterManufactured, name, fighter.AttackPoints, fighter.DefensePoints, agresive);
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            IPilot pilot = this.pilots.FirstOrDefault(p => p.Name == selectedPilotName);

            if (pilot == null)
            {
                return string.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }

            IMachine machine = this.machines.FirstOrDefault(m => m.Name == selectedMachineName);

            if (machine == null)
            {
                return string.Format(OutputMessages.MachineNotFound, selectedMachineName);
            }

            if (machine.Pilot != null)
            {
                return string.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);
            }

            pilot.AddMachine(machine);
            machine.Pilot = (IPilot)pilot;

            return string.Format(OutputMessages.MachineEngaged, selectedPilotName, selectedMachineName);
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            IMachine attackingMachine = this.machines.FirstOrDefault(m => m.Name == attackingMachineName);

            if (attackingMachine == null)
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }

            IMachine defendingMachine = this.machines.FirstOrDefault(m => m.Name == defendingMachineName);

            if (defendingMachine == null)
            {
                return string.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }

            if (attackingMachine.HealthPoints <= 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attackingMachine.Name);
            }

            if (defendingMachine.HealthPoints <= 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, defendingMachine.Name);
            }

            attackingMachine.Attack(defendingMachine);

            return string.Format(OutputMessages.AttackSuccessful
                , defendingMachine.Name, attackingMachine.Name, defendingMachine.HealthPoints);
        }

        public string PilotReport(string pilotReporting)
        {
            return this.pilots.First(p => p.Name == pilotReporting).Report();
        }

        public string MachineReport(string machineName)
        {
            return this.machines.First(m => m.Name == machineName).ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            IFighter fighter = this.machines
                .FirstOrDefault(m => m.Name == fighterName && m.GetType().Name == "Fighter") as IFighter;

            if (fighter == null)
            {
                return string.Format(OutputMessages.MachineNotFound, fighterName);
            }

            fighter.ToggleAggressiveMode();

            return string.Format(OutputMessages.FighterOperationSuccessful, fighterName);
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            ITank tank = machines
                .FirstOrDefault(m => m.Name == tankName && m.GetType().Name == "Tank") as ITank;

            if (tank == null)
            {
                return string.Format(OutputMessages.MachineNotFound, tankName);
            }

            tank.ToggleDefenseMode();

            return string.Format(OutputMessages.TankOperationSuccessful, tankName);
        }
    }
}