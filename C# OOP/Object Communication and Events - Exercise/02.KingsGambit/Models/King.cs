namespace _02.KingsGambit.Models
{
    using Contraccts;
    using System;

    public delegate void KingIsAttackedEventHandler();

    public class King : Person, IAttackable
    {
        public King(string name) 
            : base(name)
        {
        }

        public event KingIsAttackedEventHandler IsAttacked;

        public void RespondToAttack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");

            this.IsAttacked?.Invoke();
        }
    }
}
