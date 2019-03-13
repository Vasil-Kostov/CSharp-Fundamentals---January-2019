namespace ExplicitInterfaces
{
    using Interfaces;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] personInfo = line.Split();

                Citizen citizen = new Citizen(personInfo[0], personInfo[1], int.Parse(personInfo[2]));

                Console.WriteLine(citizen.GetName());
                Console.WriteLine(((IResident)citizen).GetName());

                line = Console.ReadLine();
            }
        }
    }
}
