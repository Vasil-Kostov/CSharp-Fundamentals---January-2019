namespace OnlineRadioDatabase.SongExeptions
{
    using System;

    public class InvalidSongException : ArgumentException
    {
        public  InvalidSongException(string message = "Invalid song.")
            : base(message)
        {

        }
    }
}
