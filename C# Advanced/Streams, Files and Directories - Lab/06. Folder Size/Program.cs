namespace _06._Folder_Size
{
    using System;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dir = new DirectoryInfo("../../../TestFolder");

            long size = 0;

            foreach (var fileInfo in dir.GetFiles())
            {
                size += fileInfo.Length;
            }

            using (var writer = new StreamWriter("../../../Output.txt"))
            {
                writer.WriteLine($"{(double)size / 1024 / 1024} MB");
            }
        }
    }
}
