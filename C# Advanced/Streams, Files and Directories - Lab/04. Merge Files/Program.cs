namespace _04._Merge_Files
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string[] fileOne = File.ReadAllLines("../../../FileOne.txt");
            string[] fileTwo = File.ReadAllLines("../../../FileTwo.txt");

            using (StreamWriter writer = File.CreateText("../../../Output.txt"))
            {
                int lineNum = 0;

                while (lineNum < fileOne.Length || lineNum < fileTwo.Length)
                {
                    if (lineNum < fileOne.Length)
                        writer.WriteLine(fileOne[lineNum]);
                    if (lineNum < fileTwo.Length)
                        writer.WriteLine(fileTwo[lineNum]);
                    lineNum++;
                }
            }
        }
    }
}
