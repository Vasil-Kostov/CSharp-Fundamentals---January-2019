namespace _07._Inferno_Infinity.Contracts
{
    using Enums;

    public interface IWeapon
    {
        string Name { get; }
        int MinDamage { get; }
        int MaxDamage { get; }
        int NumberOfSockets { get; }
        Rarity Rarity { get; }

        void AddGem(int index, IGem gem);
        void RemoveGem(int index);        
    }
}
