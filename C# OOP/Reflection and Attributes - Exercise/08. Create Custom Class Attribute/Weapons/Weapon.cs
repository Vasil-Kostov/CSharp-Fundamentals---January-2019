namespace _07._Inferno_Infinity.Weapons
{
    using Enums;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [CustomClass("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public abstract class Weapon : IWeapon
    {
        private string name;
        private int minDamage;
        private int maxDamage;
        private int numberOfSockets;

        private Rarity rarity;
        private List<IGem> gems;

        public Weapon(string name, int minDamage, int maxDamage, int numberOfSockets, string rarity)
        {
            this.name = name;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.numberOfSockets = numberOfSockets;

            this.rarity = Enum.Parse<Rarity>(rarity);
            this.gems = new List<IGem>(numberOfSockets);

            for (int i = 0; i < numberOfSockets; i++)
            {
                this.gems.Add(null);
            }
        }

        public string Name => this.name;

        public int MinDamage => this.minDamage * (int)rarity
             + this.gems.Where(g => g != null).Sum(g => g.Strength * 2)
             + this.gems.Where(g => g != null).Sum(g => g.Agility * 1);

        public int MaxDamage => this.maxDamage * (int)rarity
            + this.gems.Where(g => g != null).Sum(g => g.Strength * 3)
            + this.gems.Where(g => g != null).Sum(g => g.Agility * 4);

        public int NumberOfSockets => this.numberOfSockets;

        public Rarity Rarity => this.rarity;

        public void AddGem(int index, IGem gem)
        {
            if (this.gems.Capacity > index)
            {
                if (this.gems[index] != null)
                {
                    this.RemoveGem(index);
                }

                this.gems[index] = gem;
            }
        }

        public void RemoveGem(int index)
        {
            if (this.gems.Capacity > index && this.gems[index] != null)
            {
                IGem gem = this.gems[index];

                this.gems[index] = null;
            }
        }

        public override string ToString()
        {
            return $"{this.name}: {this.MinDamage}-{this.MaxDamage} Damage," +
                $" +{this.gems.Where(g => g != null).Sum(g => g.Strength)} Strength," +
                $" +{this.gems.Where(g => g != null).Sum(g => g.Agility)} Agility," +
                $" +{this.gems.Where(g => g != null).Sum(g => g.Vitality)} Vitality";
        }                    
    }
}
