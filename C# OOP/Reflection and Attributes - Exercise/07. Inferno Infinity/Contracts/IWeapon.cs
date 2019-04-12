namespace _07._Inferno_Infinity.Contracts
{
    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        void AddGem(int index, IGem gem);

        void RemoveGem(int index);        
    }
}
