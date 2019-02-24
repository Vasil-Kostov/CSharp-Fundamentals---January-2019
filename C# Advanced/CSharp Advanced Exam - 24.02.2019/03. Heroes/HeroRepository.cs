namespace Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count => this.data.Count;

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            this.data.Remove(this.data.Find(h => h.Name == name));
        }

        public Hero GetHeroWithHighestStrength()
        {
            return this.data.OrderByDescending(h => h.Item.Strength).First();
        }

        public Hero GetHeroWithHighestAbility()
        {
            return this.data.OrderByDescending(h => h.Item.Ability).First();
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return this.data.OrderByDescending(h => h.Item.Intelligence).First();
        }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();

            for (int i = 0; i < this.data.Count; i++)
            {
                printFormat.AppendLine(this.data[i].ToString());
            }

            return printFormat.ToString().TrimEnd();
        }
    }
}
