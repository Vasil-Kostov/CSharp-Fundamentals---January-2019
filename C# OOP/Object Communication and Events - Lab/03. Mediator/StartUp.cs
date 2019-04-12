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

            IAttackGroup attackGroup = new Group();

            attackGroup.AddMember(new Warrior("Gencho", 15, combatLog));
            attackGroup.AddMember(new Warrior("Pesho", 25, combatLog));

            ITarget dragon = new Dragon("Lamia", 200, 25, combatLog);

            IExecutor executor = new CommandExecutor();
            ICommand groupTarget = new GroupTargetCommand(attackGroup, dragon);
            ICommand groupAttack = new GroupAttackCommand(attackGroup);
        }
    }
}
