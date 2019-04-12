namespace P02.ExtendedDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Database
    {
        private const int Capacity = 16;

        private Person[] collection;
        private int index;

        public Database(params Person[] inputCollection)
        {
            this.ValidateInput(inputCollection);
            this.index = 0;
            this.collection = new Person[Capacity];
            this.Collection = inputCollection;
        }

        private Person[] Collection
        {
            get
            {
                List<Person> people = new List<Person>();
                for (int i = 0; i < this.index; i++)
                {
                    people.Add(this.collection[i]);
                }

                return people.ToArray();
            }

            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    this.Add(value[i]);
                }
            }
        }

        public void Add(Person person)
        {
            if (this.index >= Capacity)
            {
                throw new InvalidOperationException("Capacity is full!");
            }

            if (this.collection.Any(p => p != null && p.Username == person.Username))
            {
                throw new InvalidOperationException($"Person with username {person.Username} already exist!");
            }

            if (this.collection.Any(p => p != null && p.Id == person.Id))
            {
                throw new InvalidOperationException($"Person with Id {person.Id} already exist!");
            }

            this.collection[this.index++] = person;
        }

        public void Remove()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Collection is empty!");
            }

            this.collection[--this.index] = null;
        }

        public Person FindById(long id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("People with negative Id doesn't exist!");
            }

            if (!this.collection.Any(p => p != null && p.Id == id))
            {
                throw new InvalidOperationException($"Person with Id: {id} doesn't exist");
            }

            return this.collection.First(p => p.Id == id);
        }

        public Person FindByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("People with empty Username doesn't exist!");
            }

            if (!this.collection.Any(p => p != null && p.Username == username))
            {
                throw new InvalidOperationException($"Person with username {username} doesn't exist!");
            }

            return this.collection.First(p => p.Username == username);
        }

        public Person[] Fetch()
        {
            return this.Collection;
        }

        private void ValidateInput(Person[] collection)
        {
            if (collection.Length < 1 || collection.Length > Capacity)
            {
                throw new InvalidOperationException("Invalid collection size!");
            }
        }
    }
}
