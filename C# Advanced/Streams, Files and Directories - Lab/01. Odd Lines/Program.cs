namespace _01._Odd_Lines
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
                var line = reader.ReadLine();

                int counter = 0;

                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        writer.WriteLine(line);
                    }

                    line = reader.ReadLine();
                    counter++;
                }
            }

        }
    }
}
