namespace _02.KingsGambit.Models
{
    using Contraccts;
    using System;

    public class Footman : Person, IDefender
    {
        public Footman(string name)
            : base(name)
        {
        }

        public void DefendTheKing()
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
