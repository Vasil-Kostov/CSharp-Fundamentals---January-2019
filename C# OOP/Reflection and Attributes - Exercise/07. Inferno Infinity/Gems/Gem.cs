namespace _07._Inferno_Infinity.Gems
{
    using Contracts;
    using Enums;

    using System;

    public abstract class Gem : IGem
    {
        protected Clarity clarity;
        protected int strength;
        protected int agility;
        protected int vitality;

        public Gem(string clarity, int strength, int agility, int vitality)
        {
            this.clarity = Enum.Parse<Clarity>(clarity);
            this.strength = strength;
            this.agility = agility;
            this.vitality = vitality;
        }

        public int Strength => this.strength + (int)this.clarity;

        public int Agility => this.agility + (int)this.clarity;

        public int Vitality => this.vitality + (int)this.clarity;
    }
}
