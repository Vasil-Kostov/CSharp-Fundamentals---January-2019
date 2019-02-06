namespace DefiningClasses
{
    using DefiningClasses;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var family = new Family();

            int numberOfMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] memberInfo = Console.ReadLine().Split();

                family.AddMember(new Person(memberInfo[0], int.Parse(memberInfo[1])));
            }

            Person oldestMember = family.GetOledestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
