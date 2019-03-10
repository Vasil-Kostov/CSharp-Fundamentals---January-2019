namespace _01._Rhombus_of_Stars
{
    using System;
    using System.Text;

    public class Program
    {
        static StringBuilder rhombus = new StringBuilder();

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            FillRhombus(n);

            PrintRhombus(n);
        }

        private static void FillRhombus(int n)
        {
            AddUpperPart(n);
            AddLowerPart(n);
        }

        private static void AddLowerPart(int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                rhombus.AppendLine(Line(i, n));
            }
        }

        private static void AddUpperPart(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                rhombus.AppendLine(Line(i, n));
            }
        }

        private static void PrintRhombus(int n)
        {
            Console.WriteLine(rhombus.ToString().TrimEnd());
        }

        private static string Line(int i, int n)
        {
            return (new string(' ', n - i) + string.Join(" ", new string('*', i).ToCharArray()) + new string(' ', n - i));
        }
    }
}
