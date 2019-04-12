namespace _07._Inferno_Infinity
{
    using Contracts;
    using Gems;
    using Weapons;

    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<IWeapon> weapons = new List<IWeapon>();
            
            while (true)
            {
                string[] commandArgs = Console.ReadLine().Split(";");

                switch (commandArgs[0])
                {
                    case "Create":
                        string weaponRarity = commandArgs[1].Split()[0];
                        string weponType = commandArgs[1].Split()[1];

                        Type type = Type.GetType($"{typeof(Weapon).Namespace}.{weponType}");

                        weapons.Add((IWeapon)Activator.CreateInstance(type, new object[] { commandArgs[2], weaponRarity}));
                        break;

                    case "Add":
                        string weaponNmae = commandArgs[1];
                        int index = int.Parse(commandArgs[2]);
                        string gemClarity = commandArgs[3].Split()[0];
                        string gemType = commandArgs[3].Split()[1];

                        Type typeOfGem = Type.GetType($"{typeof(Gem).Namespace}.{gemType}");

                        IGem gem = (IGem)Activator.CreateInstance(typeOfGem, new object[] { gemClarity });

                        weapons.Find(w => w.Name == weaponNmae).AddGem(index, gem);
                        break;

                    case "Remove":
                        string name = commandArgs[1];
                        int fromIndex = int.Parse(commandArgs[2]);

                        weapons.Find(w => w.Name == name).RemoveGem(fromIndex);
                        break;

                    case "Print":
                        string weaponToPrint = commandArgs[1];

                        Console.WriteLine(weapons.Find(w => w.Name == weaponToPrint));
                        break;

                    default:
                        return;
                }
            }
        }
    }
}
