namespace _05._Fashion_Boutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Stack<int> delivery = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());

            int racksNeeded = 0;

            int sumOfClothes = 0;

            while (delivery.Any())
            {
                sumOfClothes += delivery.Pop();
                
                if (delivery.Any())
                {
                    if (sumOfClothes + delivery.Peek() > rackCapacity)
                    {
                        racksNeeded++;
                        sumOfClothes = 0;
                    }
                }
                else
                {
                    racksNeeded++;
                }            
            }

            Console.WriteLine(racksNeeded);
        }
    }
}
