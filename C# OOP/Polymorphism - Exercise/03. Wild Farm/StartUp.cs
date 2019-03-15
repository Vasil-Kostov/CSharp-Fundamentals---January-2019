namespace WildFarm
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] animalInfo = line.Split();
                Animal animal = AnimalFactory.CreateAnimal(animalInfo);

                Console.WriteLine(animal.ProduceSound());

                string[] foodInfo = Console.ReadLine().Split();
                Food food = FoodFactory.CreateFood(foodInfo);

                try
                {
                    animal.Eat(food, 1);
                }
                catch (InvalidFoodException invFoodEx)
                {
                    Console.WriteLine(invFoodEx.Message);
                }

                animals.Add(animal);    

                line = Console.ReadLine();
            }

            animals.ForEach(a => Console.WriteLine(a));
        }        
    }
}
