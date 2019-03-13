namespace MilitaryElite.Interfaces.Soldiers.Private.SpecialisedSoldiers
{
    using Models;
    using System.Collections.Generic;

    public interface IEngineer
    { 
        IReadOnlyList<Repair> Repairs { get; }
    }
}
