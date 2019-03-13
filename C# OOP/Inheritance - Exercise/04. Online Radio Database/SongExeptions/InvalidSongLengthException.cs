namespace OnlineRadioDatabase.SongExeptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException(string message = "Invalid song length.")
            : base(message)
        {

        }
    }
}
