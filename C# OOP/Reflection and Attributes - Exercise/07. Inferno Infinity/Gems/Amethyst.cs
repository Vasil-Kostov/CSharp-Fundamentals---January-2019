namespace _07._Inferno_Infinity.Gems
{
    public class Amethyst : Gem
    {
        private const int DefaultStrength = 2;
        private const int DefaultAgility = 8;
        private const int DefaultVitality = 4;

        public Amethyst(string clarity)
            : base(clarity, DefaultStrength, DefaultAgility, DefaultVitality)
        {
        }
    }
}
