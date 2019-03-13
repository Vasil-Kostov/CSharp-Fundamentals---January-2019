namespace MilitaryElite.Interfaces.Soldiers.Private.SpecialisedSoldiers
{
    using Models;
    using System.Collections.Generic;

    public interface ICommando
    {
        IReadOnlyList<Mission> Misions { get; }
    }
}
