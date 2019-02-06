namespace DefiningClasses
{
    using DefiningClasses;
    using System;
    using System.Linq;

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

            var olderThanThirty = family.GetMembersOverTrirtyYearsOld();

            Console.WriteLine(string.Join(Environment.NewLine, olderThanThirty.OrderBy(p => p.Name)));
        }
    }
}
