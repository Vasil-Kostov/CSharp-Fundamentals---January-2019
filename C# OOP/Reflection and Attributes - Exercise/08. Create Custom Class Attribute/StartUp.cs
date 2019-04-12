namespace _07._Inferno_Infinity
{
    using Weapons;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Type type = typeof(Weapon);
            var attribute = (CustomClassAttribute)type.GetCustomAttributes(false).First();

            while (true)
            {
                string command = Console.ReadLine();

                switch (command)
                {   
                    case "Author":
                        Console.WriteLine($"Author: {attribute.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"Revision: {attribute.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {attribute.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {string.Join(", ", attribute.Reviewers)}");
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
