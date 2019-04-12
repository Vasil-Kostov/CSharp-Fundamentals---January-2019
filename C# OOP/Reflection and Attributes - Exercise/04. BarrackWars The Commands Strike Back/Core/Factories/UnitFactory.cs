namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Models.Units;
    using Contracts;
    using System.Linq;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var type = Type.GetType($"{typeof(Unit).Namespace}.{unitType}");

            return (IUnit)Activator.CreateInstance(type);
        }
    }
}
