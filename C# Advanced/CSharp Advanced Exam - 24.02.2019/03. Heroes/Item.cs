namespace Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Item
    {
        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public int Strength { get; set; }

        public int Ability { get; set; }

        public int Intelligence { get; set; }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();

            printFormat.AppendLine("Item:");
            printFormat.AppendLine($"  * Strength: {this.Strength}");
            printFormat.AppendLine($"  * Ability: {this.Ability}");
            printFormat.Append($"  * Intelligence: {this.Intelligence}");

            return printFormat.ToString();
        }
    }
}
