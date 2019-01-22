namespace _06._Parking_Lot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            HashSet<string> carNumbers = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string direction = input.Split(", ").First();
                string carNumber = input.Split(", ").Last();

                if (direction == "IN") 
                {
                    carNumbers.Add(carNumber);                
                }
                else
                {
                    carNumbers.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (carNumbers.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, carNumbers));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
