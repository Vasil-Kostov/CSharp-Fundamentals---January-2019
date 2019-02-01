namespace _02._Line_Numbers
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new StreamReader("../../../text.txt"))
            using (var writer = new StreamWriter("../../../Output.txt"))
            {
                var line = reader.ReadLine();

                int counter = 1;

                while (line != null)
                {
                    var punctuationMarks = Regex.Matches(line, @"[^A-Za-z ]").Count;
                    var characters = Regex.Matches(line, @"[A-Za-z]").Count;

                    writer.WriteLine($"Line {counter}: {line} ({characters})({punctuationMarks})");

                    line = reader.ReadLine();
                    counter++;
                }
            }
        }
    }
}
