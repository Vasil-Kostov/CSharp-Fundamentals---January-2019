namespace Heroes
{
    using Models;
    using Loggers;
    using System;
    using Heroes.Contracts;
    using Heroes.Commands;

    public class StartUp
    {
        public static void Main()
        {
            Logger combatLog = new CombatLogger();
            Logger eventlog = new EventLogger();

            combatLog.SetSuccessor(eventlog);

            IAttacker warrior = new Warrior("Gencho", 10, combatLog);
            ITarget dragon = new Dragon("Lamia", 100, 25, combatLog);

            IExecutor executor = new CommandExecutor();
            ICommand command = new TargetCommand(warrior, dragon);
            ICommand attack = new AttackCommand(warrior);
        }
    }
}
