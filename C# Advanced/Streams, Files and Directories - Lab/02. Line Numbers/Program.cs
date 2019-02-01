namespace _02._Line_Numbers
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new StreamReader("../../../Input.txt"))
            using (var writer = new StreamWriter("../../../Output.txt"))
            {
                int counter = 1;

                var line = reader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine($"{counter}. {line}");

                    line = reader.ReadLine();
                    counter++;
                }
            }

        }
    }
}
