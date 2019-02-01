namespace _05._Slice_File
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            int parts = 4;

            using (var reader = new FileStream("../../../sliceMe.txt", FileMode.Open))
            {
                long singelPieceSize = (long)Math.Ceiling((double)reader.Length / parts);

                for (int i = 0; i < parts; i++)
                {
                    long currentPieceSize = 0;

                    using (var streamCreateFile = new FileStream($"../../../Part-{i+1}.txt", FileMode.Create))
                    {

                        byte[] buffer = new byte[128]; //Buffer size is 128B so the last file (Part-4.txt) can be as close as posible to the others by size!

                        var totalRead = reader.Read(buffer, 0, buffer.Length);

                        while (totalRead > 0)
                        {

                            currentPieceSize += totalRead;
                            streamCreateFile.Write(buffer, 0, totalRead);

                            if (currentPieceSize >= singelPieceSize)
                            {
                                break;
                            }

                            totalRead = reader.Read(buffer, 0, buffer.Length);
                        }
                    }
                }


            }
        }
    }
}
