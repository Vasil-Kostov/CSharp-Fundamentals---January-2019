namespace _04._Copy_Binary_File
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new FileStream("../../../copyMe.png", FileMode.Open, FileAccess.Read))
            using (var writer = new FileStream("../../../copyOfTheBinaryFile.png", FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = new byte[4096];

                var totalRead = reader.Read(buffer, 0, buffer.Length);

                while (totalRead > 0)
                {
                    writer.Write(buffer, 0, totalRead);

                    totalRead = reader.Read(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
