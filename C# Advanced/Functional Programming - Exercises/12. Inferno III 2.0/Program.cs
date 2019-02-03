namespace _12._Inferno_III_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Func<string, int, List<int>, int> func = (criterion, index, nums) => criterion == "Sum Left" ?
                                       index > 0 ? nums[index - 1] + nums[index] : 0 + nums[index]
                                       : criterion == "Sum Right" ?
                                       index > nums.Count - 2 ? 0 + nums[index] : nums[index + 1] + nums[index]
                                       : index > 0 && index <= nums.Count - 2 ? nums[index - 1] + nums[index] + nums[index + 1]
                                       : index > 0 && index > nums.Count - 2 ? 0 + nums[index] + nums[index - 1]
                                       : index == 0 && index <= nums.Count - 2 ? 0 + nums[index] + nums[index + 1] : nums[index];

            List<int> gems = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int?> indexator = gems.Select(x => (int?)x).ToList();

            List<string> commands = new List<string>();

            string[] command = Console.ReadLine().Split(';');

            while (command[0] != "Forge")
            {
                switch (command[0])
                {
                    case "Exclude": commands.Add($"{command[1]};{command[2]}"); break;
                    case "Reverse": commands.Remove($"{command[1]};{command[2]}"); break;
                }

                command = Console.ReadLine().Split(';');
            }

            foreach (var comm in commands)
            {
                string sides = comm.Split(';').First();
                int compareTo = int.Parse(comm.Split(';').Last());

                foreach (var gem in gems)
                {
                    int index = gems.IndexOf(gem);
                    int sum = func(sides, index, gems);

                    if (sum == compareTo)
                    {
                        indexator[index] = null;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", indexator.Where(x => x != null)));
        }
    }
}