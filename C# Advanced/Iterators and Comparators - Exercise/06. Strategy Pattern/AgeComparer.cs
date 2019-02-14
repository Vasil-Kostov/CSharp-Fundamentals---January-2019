namespace StratrgyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class AgeComparer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            return first.Age.CompareTo(second.Age);
        }
    }
}
