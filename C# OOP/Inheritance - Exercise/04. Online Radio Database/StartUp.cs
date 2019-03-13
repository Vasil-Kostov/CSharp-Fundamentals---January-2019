namespace OnlineRadioDatabase
{
    using SongExeptions;
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Playlist playlist = new Playlist();

            for (int i = 0; i < n; i++)
            {
                string[] songInfo = Console.ReadLine().Split(";");

                try
                {
                    if (!int.TryParse(songInfo[2].Split(":").First(), out int minutes) 
                        || !int.TryParse(songInfo[2].Split(":").Last(), out int seconds))
                    {
                        throw new InvalidSongLengthException();
                    }

                    Song song = new Song(songInfo[0], songInfo[1], minutes, seconds);

                    playlist.Add(song);

                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException invSongEx)
                {
                    Console.WriteLine(invSongEx.Message);
                }
            }

            Console.WriteLine(playlist);
        }
    }
}
