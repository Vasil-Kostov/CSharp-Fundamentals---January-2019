namespace WildFarm
{
    using System;

    public class InvalidFoodException : InvalidOperationException
    {
        public InvalidFoodException(string animalType, string foodType)
            : base($"{animalType} does not eat {foodType}!")
        {
        }
    }
}
