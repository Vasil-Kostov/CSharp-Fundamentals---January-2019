namespace _04.GenericSwapMethodInteger
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }

            int[] swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.Swap(swapIndexes[0], swapIndexes[1]);

            Console.WriteLine(box);
        }
    }
}
