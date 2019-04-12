namespace _02.KingsGambit.Models
{
    using Contraccts;
    using System;

    public class RoyalGuard : Person, IDefender
    {
        public RoyalGuard(string name)
            : base(name)
        {
        }

        public void DefendTheKing()
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
