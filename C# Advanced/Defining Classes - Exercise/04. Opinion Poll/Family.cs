namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> family = new List<Person>();
        
        public void AddMember(Person member)
        {
            this.family.Add(member);
        }

        public List<Person> GetMembersOverTrirtyYearsOld()
        {
            return this.family.Where(m => m.Age > 30).ToList();
        }
    }
}
