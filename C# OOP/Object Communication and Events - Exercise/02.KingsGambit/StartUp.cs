namespace _02.KingsGambit
{
    using _02.KingsGambit.Contraccts;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string kingsName = Console.ReadLine();
            King king = new King(kingsName);

            var royalGuardsNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var footmenNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var defenders = new List<Person>();

            foreach (var name in royalGuardsNames)
            {
                RoyalGuard guard = new RoyalGuard(name);
                defenders.Add(guard);
                king.IsAttacked += guard.DefendTheKing;
            }

            foreach (var name in footmenNames)
            {
                Footman footman = new Footman(name);
                defenders.Add(footman);
                king.IsAttacked += footman.DefendTheKing;
            }

            while (true)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];

                switch (command)
                {
                    case "Kill":
                        string name = input[1];
                        Person defender = defenders.First(s => s.Name == name);
                        defenders.Remove(defender);
                        king.IsAttacked -= ((IDefender)defender).DefendTheKing;
                        break;

                    case "Attack":
                        king.RespondToAttack();
                        break;

                    case "End":
                        return;
                }
            }
        }
    }
}
