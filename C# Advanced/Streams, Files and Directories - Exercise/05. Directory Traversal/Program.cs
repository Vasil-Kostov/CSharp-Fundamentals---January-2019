namespace _05._Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string path = Console.ReadLine();

            var files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);

            Dictionary<string, List<FileInfo>> extensionAndFilesInfo = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                FileInfo curentFileInfo = new FileInfo(file);

                if (!extensionAndFilesInfo.ContainsKey(curentFileInfo.Extension))
                {
                    extensionAndFilesInfo.Add(curentFileInfo.Extension, new List<FileInfo>());
                }

                extensionAndFilesInfo[curentFileInfo.Extension].Add(curentFileInfo);
            }

            using (var writer = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/TopDirectoryReport.txt"))
            {
                foreach (var kvp in extensionAndFilesInfo.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key))
                {
                    writer.WriteLine(kvp.Key);

                    foreach (var file in kvp.Value.OrderBy(f => f.Length))
                    {
                        writer.WriteLine($"--{file.Name} - {(double)file.Length / 1024:F3}kB");
                    }
                }
            }
        }
    }
}
