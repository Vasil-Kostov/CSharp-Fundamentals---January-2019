namespace P05_GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Item
    {
        public Item(string name, long amount)
        {
            this.Name = name;
            this.Amount = amount;

            if (name.ToLower() == "gold")
            {
                this.Type = "Gold";
            }
            else if (name.ToLower().EndsWith("gem") && name.Length > 3)
            {
                this.Type = "Gem";
            }
            else if (name.Length == 3)
            {
                this.Type = "Cash";
            }
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public long Amount { get; set; }
    }
}
