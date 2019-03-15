namespace WildFarm
{
    using Animals.Birds;
    using Animals.Mammals;
    using Animals.Mammals.Felines;

    public static class AnimalFactory
    {
        public static Animal CreateAnimal(params string[] animalInfo)
        {
            switch (animalInfo[0])
            {
                case "Hen": return new Hen(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                case "Owl": return new Owl(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                case "Mouse": return new Mouse(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                case "Dog": return new Dog(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                case "Cat": return new Cat(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                case "Tiger": return new Tiger(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                default: return null;
            }
        }
    }
}
