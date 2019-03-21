namespace _01.StreamProgress
{
    using Contracts;

    public class Music : IStreamable
    {
        private string artist;
        private string album;

        public Music(string artist, string album, int length)
        {
            this.artist = artist;
            this.album = album;
            this.Length = length;
        }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}
