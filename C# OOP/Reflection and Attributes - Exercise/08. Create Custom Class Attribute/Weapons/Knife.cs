namespace _07._Inferno_Infinity.Weapons
{
    public class Knife : Weapon
    {
        private const int DefaultMinDmg = 3;
        private const int DefaultMaxDmg = 4;
        private const int DefaultNumberOfSockets = 2;

        public Knife(string name, string rarity)
            : base(name, DefaultMinDmg, DefaultMaxDmg, DefaultNumberOfSockets, rarity)
        {
        }
    }
}
