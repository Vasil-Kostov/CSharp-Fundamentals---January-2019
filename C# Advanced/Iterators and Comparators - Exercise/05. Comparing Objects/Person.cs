namespace _05._Comparing_Objects
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    partial class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string townName;

        public Person(string name, int age, string townName)
        {
            this.name = name;
            this.age = age;
            this.townName = townName;
        }

        public int CompareTo(Person other)
        {
            int result = this.name.CompareTo(other.name);

            if (result == 0)
            {
                result = this.age.CompareTo(other.age);

                if (result == 0)
                {
                    return this.townName.CompareTo(other.townName);
                }

                return result;
            }

            return result;
        }
    }
}
