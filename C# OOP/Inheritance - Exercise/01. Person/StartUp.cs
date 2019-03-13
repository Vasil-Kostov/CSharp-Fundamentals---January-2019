namespace _01._Person
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ergEx)
            {
                Console.WriteLine(ergEx.Message);
            }
        }
    }
}
