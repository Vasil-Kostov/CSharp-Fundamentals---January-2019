namespace _01.StreamProgress
{
    using Contracts;

    public class StreamProgressInfo
    {
        private readonly IStreamable stream;

        public StreamProgressInfo(IStreamable stream)
        {
            this.stream = stream;
        }

        public int CurrentPercent()
        {
            return this.stream.Sent * 100 / this.stream.Length;
        }
    }
}
