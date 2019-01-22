namespace _03._Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            SortedDictionary<string, List<string>> shopsInfo = new SortedDictionary<string, List<string>> ();

            string input = Console.ReadLine();

            while (input != "Revision")
            {
                string[] inputArr = input.Split(", ");

                string shopName = inputArr[0];
                string product = inputArr[1];
                double price = double.Parse(inputArr[2]);

                if (!shopsInfo.ContainsKey(shopName))
                {
                    shopsInfo.Add(shopName, new List<string>());
                }

                shopsInfo[shopName].Add($"Product: {product}, Price: {price}");

                input = Console.ReadLine();
            }

            foreach (var shop in shopsInfo)
            {
                Console.WriteLine($"{shop.Key}->{Environment.NewLine}{string.Join(Environment.NewLine, shop.Value)}");
            }
        }
    }
}
