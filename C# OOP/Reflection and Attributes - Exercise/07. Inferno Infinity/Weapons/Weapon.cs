namespace _07._Inferno_Infinity.Weapons
{
    using Contracts;
    using Enums;

    using System;
    using System.Linq;

    public abstract class Weapon : IWeapon
    {
        private string name;
        private int minDamage;
        private int maxDamage;
        private int numberOfSockets;

        private Rarity rarity;
        private IGem[] gems;

        public Weapon(string name, int minDamage, int maxDamage, int numberOfSockets, string rarity)
        {
            this.name = name;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.numberOfSockets = numberOfSockets;

            this.rarity = Enum.Parse<Rarity>(rarity);
            this.gems = new IGem[numberOfSockets];
        }

        public string Name => this.name;

        public int MinDamage => this.minDamage * (int)rarity
             + this.gems.Where(g => g != null).Sum(g => g.Strength * 2)
             + this.gems.Where(g => g != null).Sum(g => g.Agility * 1);

        public int MaxDamage => this.maxDamage * (int)rarity
            + this.gems.Where(g => g != null).Sum(g => g.Strength * 3)
            + this.gems.Where(g => g != null).Sum(g => g.Agility * 4);

        public void AddGem(int index, IGem gem)
        {
            if (this.gems.Length > index)
            {
                this.gems[index] = gem;
            }
        }

        public void RemoveGem(int index)
        {
            if (this.gems.Length > index)
            {
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
