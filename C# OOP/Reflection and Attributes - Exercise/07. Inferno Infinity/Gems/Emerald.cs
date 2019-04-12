namespace _07._Inferno_Infinity.Gems
{
    public class Emerald : Gem
    {
        private const int DefaultStrength = 1;
        private const int DefaultAgility = 4;
        private const int DefaultVitality = 9;

        public Emerald(string clarity)
            : base(clarity, DefaultStrength, DefaultAgility, DefaultVitality)
        {
        }
    }
}
