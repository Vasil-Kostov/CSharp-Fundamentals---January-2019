namespace _03._Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            Regex wordRegex = new Regex(@"[A-Za-z]+");

            Dictionary<string, int> words = new Dictionary<string, int>();

            words = ReadWords();

            using (var reader = new StreamReader("../../../text.txt"))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var wordsInLine = wordRegex.Matches(line);

                    foreach (var word in wordsInLine)
                    {
                        if (words.ContainsKey(word.ToString().ToLower()))
                        {
                            words[word.ToString().ToLower()]++;
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            Console.WriteLine(AreFilesEqual());

            using (var writer = new StreamWriter("../../../actualResult.txt"))            
            {
                foreach (var word in words.OrderByDescending(kvp => kvp.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }

        private static bool AreFilesEqual()
        {
            bool areEqual = false;

            var firstFile = File.ReadAllLines("../../../actualResult.txt");
            var secondFile = File.ReadAllLines("../../../expectedResult.txt");

            if (firstFile.SequenceEqual(secondFile))
            {
                areEqual = true;
            }

            return areEqual;
        }

        private static Dictionary<string, int> ReadWords()
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            using (var reader = new StreamReader("../../../words.txt"))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    foreach (var word in line.Split())
                    {
                        if (!words.ContainsKey(word))
                        {
                            words.Add(word, 0);
                        }
                    }


                    line = reader.ReadLine();
                }
            }

            return words;
        }
    }
}
