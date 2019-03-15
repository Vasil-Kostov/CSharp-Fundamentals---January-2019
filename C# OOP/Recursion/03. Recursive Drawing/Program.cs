namespace _03._Recursive_Drawing
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Draw(int n)
        {
            if (n == 0)
            {
                return; 
            }

            Console.WriteLine(new string('*', n));

            Draw(n - 1);

            Console.WriteLine(new string('#', n));
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Draw(n);
        }
    }
}
