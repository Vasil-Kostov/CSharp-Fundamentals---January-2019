namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Repository
    {
        private Dictionary<int, Person> data;
        private int id;

        public int Count => data.Count;

        public Repository()
        {
            this.data = new Dictionary<int, Person>();
            this.id = 0;
        }

        public void Add(Person person)
        {
            data.Add(id, person);
            id++;
        }

        public Person Get(int id)
        {
            return data.First(d => d.Key == id).Value;
        }

        public bool Update(int id, Person newPerson)
        {
            if (data.ContainsKey(id))
            {
                data[id] = newPerson;
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            if (data.ContainsKey(id))
            {
                data.Remove(id);
                return true;
            }

            return false;
        }        
    }
}
