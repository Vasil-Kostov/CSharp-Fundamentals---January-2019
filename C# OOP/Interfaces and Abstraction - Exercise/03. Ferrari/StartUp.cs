namespace _03._Ferrari
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string driversName = Console.ReadLine();

            ICar car = new Ferrari(driversName);

            Console.WriteLine(car);
        }
    }
}
