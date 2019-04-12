namespace _07._Inferno_Infinity.Weapons
{
    public class Axe : Weapon
    {
        private const int DefaultMinDmg = 5;
        private const int DefaultMaxDmg = 10;
        private const int DefaultNumberOfSockets = 4;

        public Axe(string name, string rarity)
            : base(name, DefaultMinDmg, DefaultMaxDmg, DefaultNumberOfSockets, rarity)
        {
        }
    }
}
