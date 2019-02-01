namespace _01._Even_Lines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new StreamReader("../../../text.txt"))
            using (var writer = new StreamWriter("../../../Output.txt"))
            {
                int counter = 0;

                string line = reader.ReadLine();

                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        line = Regex.Replace(line, @"[-,.!?]", "@");

                        writer.WriteLine(string.Join(" ", 
                            line
                            .Split(" ")
                            .Reverse()));
                    }

                    line = reader.ReadLine();
                    counter++;
                }
            }
        }
    }
}
