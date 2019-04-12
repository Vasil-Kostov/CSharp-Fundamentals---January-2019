namespace _07._Inferno_Infinity.Weapons
{
    public class Sword : Weapon
    {
        private const int DefaultMinDmg = 4;
        private const int DefaultMaxDmg = 6;
        private const int DefaultNumberOfSockets = 3;

        public Sword(string name, string rarity)
            : base(name, DefaultMinDmg, DefaultMaxDmg, DefaultNumberOfSockets, rarity)
        {
        }
    }
}
