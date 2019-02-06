namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Tournament")
            {
                Pokemon currentPokemon = new Pokemon(command[1], command[2], int.Parse(command[3]));

                if (trainers.Any(t => t.Name == command[0]))
                {
                    trainers.Find(t => t.Name == command[0]).Pokemons.Add(currentPokemon);
                }
                else
                {
                    trainers.Add(new Trainer(command[0], currentPokemon));
                }

                command = Console.ReadLine().Split();
            }

            string element = Console.ReadLine();

            while (element != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);

                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }

                element = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
