namespace _07._Inferno_Infinity.Gems
{
    public class Ruby : Gem
    {
        private const int DefaultStrength = 7;
        private const int DefaultAgility = 2;
        private const int DefaultVitality = 5;

        public Ruby(string clarity)
            : base(clarity, DefaultStrength, DefaultAgility, DefaultVitality)
        {
        }
    }
}
