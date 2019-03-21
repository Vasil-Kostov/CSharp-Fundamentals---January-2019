namespace _01.StreamProgress
{
using Contracts;

    public class File : IStreamable
    {
        private string name;

        public File(string name, int length)
        {
            this.name = name;
            this.Length = length;
        }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}
