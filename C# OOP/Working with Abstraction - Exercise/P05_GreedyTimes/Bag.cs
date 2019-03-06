namespace P05_GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Bag
    {
        private long capacity;
        private long currentAmount;

        public Bag(long capacity)
        {
            this.capacity = capacity;
            this.currentAmount = 0;

            this.Gold = new List<Item>();
            this.Gem = new List<Item>();
            this.Cash = new List<Item>();
        }

        public List<Item> Gold { get; set; }

        public List<Item> Gem { get; set; }

        public List<Item> Cash { get; set; }

        public void AddItem(Item item)
        {
            if (this.CanBeAdded(item.Amount))
            {
                if (item.Type == "Gold")
                {
                    if (this.Gold.Any(i => i.Name == item.Name))
                    {
                        this.Gold.Find(i => i.Name == item.Name).Amount += item.Amount;
                    }
                    else
                    {
                        this.Gold.Add(item);
                    }

                    this.currentAmount += item.Amount;

                }
                else if (item.Type == "Gem" && this.Gem.Sum(i => i.Amount) + item.Amount <= this.Gold.Sum(i => i.Amount))
                {
                    if (this.Gem.Any(i => i.Name == item.Name))
                    {
                        this.Gem.Find(i => i.Name == item.Name).Amount += item.Amount;
                    }
                    else
                    {
                        this.Gem.Add(item);
                    }

                    this.currentAmount += item.Amount;
                }
                else if (item.Type == "Cash" && this.Cash.Sum(i => i.Amount) + item.Amount <= this.Gem.Sum(i => i.Amount))
                {
                    if (this.Cash.Any(i => i.Name == item.Name))
                    {
                        this.Cash.Find(i => i.Name == item.Name).Amount += item.Amount;
                    }
                    else
                    {
                        this.Cash.Add(item);
                    }

                    this.currentAmount += item.Amount;
                }
            }
        }

        private bool CanBeAdded(long amount)
        {
            return this.currentAmount + amount <= this.capacity;
        }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();

            if (this.Gold.Any())
            {
                printFormat.AppendLine($"<Gold> ${Gold.Sum(i => i.Amount)}");
                foreach (var item in this.Gold.OrderByDescending(i => i.Name).ThenBy(i => i.Amount))
                {
                    printFormat.AppendLine($"##{item.Name} - {item.Amount}");
                }

                if (this.Gem.Any())
                {
                    printFormat.AppendLine($"<Gem> ${Gem.Sum(i => i.Amount)}");
                    foreach (var item in this.Gem.OrderByDescending(i => i.Name).ThenBy(i => i.Amount))
                    {
                        printFormat.AppendLine($"##{item.Name} - {item.Amount}");
                    }

                    if (this.Cash.Any())
                    {
                        printFormat.AppendLine($"<Cash> ${Cash.Sum(i => i.Amount)}");
                        foreach (var item in this.Cash.OrderByDescending(i => i.Name).ThenBy(i => i.Amount))
                        {
                            printFormat.AppendLine($"##{item.Name} - {item.Amount}");
                        }
                    }
                }
            }

            return printFormat.ToString().Trim();
        }
    }
}
