namespace _01.StreamProgress.Contracts
{
    public interface IStreamable
    {
        int Length { get; }

        int Sent { get; }
    }
}
