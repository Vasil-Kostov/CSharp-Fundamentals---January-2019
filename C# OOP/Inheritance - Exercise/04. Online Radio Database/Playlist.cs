namespace OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Playlist
    {
        private List<Song> songs;

        public Playlist()
        {
            this.songs = new List<Song>();
        }

        public void Add(Song song)
        {
            this.songs.Add(song);
        }

        public override string ToString()
        {
            TimeSpan length = TimeSpan.FromSeconds(this.songs.Sum(s => s.Minutes * 60 + s.Seconds));

            return $"Songs added: {this.songs.Count}{Environment.NewLine}" +
                $"Playlist length: {length.Hours}h {length.Minutes}m {length.Seconds}s";
        }
    }
}
