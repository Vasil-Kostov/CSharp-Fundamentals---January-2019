namespace _07._Equality_Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person : IEquatable<Person>, IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public bool Equals(Person other)
        {
            return this.Name.Equals(other.Name) && this.Age.Equals(other.Age);
        }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                return this.Age.CompareTo(other.Age);
            }

            return result;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
