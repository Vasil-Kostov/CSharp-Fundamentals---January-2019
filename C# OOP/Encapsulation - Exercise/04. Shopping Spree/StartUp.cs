namespace _04._Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static List<Person> people = new List<Person>();
        static List<Product> products = new List<Product>();

        public static void Main()
        {
            string[] peopleArr = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            string[] productsArr = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var person in peopleArr)
            {
                string[] args = person.Split("=", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    people.Add(new Person(args[0], decimal.Parse(args[1])));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            foreach (var product in productsArr)
            {
                string[] args = product.Split("=", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    products.Add(new Product(args[0], decimal.Parse(args[1])));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] args = command.Split();
                string personName = args[0];
                string productName = args[1];

                try
                {
                    people.Find(p => p.Name == personName)
                          .BuyProduct(products.Find(p => p.Name == productName));

                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
