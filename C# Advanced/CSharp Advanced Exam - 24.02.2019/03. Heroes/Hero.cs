namespace Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Hero
    {
        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public Item Item { get; set; }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();

            printFormat.AppendLine($"Hero: {this.Name} – {this.Level}lvl");
            printFormat.Append(this.Item.ToString());

            return printFormat.ToString();
        }
    }
}
