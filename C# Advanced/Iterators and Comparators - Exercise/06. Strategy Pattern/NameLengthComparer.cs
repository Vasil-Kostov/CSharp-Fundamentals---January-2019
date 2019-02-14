namespace StratrgyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class NameLengthComparer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int result = first.Name.Length.CompareTo(second.Name.Length);

            if (result == 0)
            {
                return first.Name.ToLower()[0].CompareTo(second.Name.ToLower()[0]);
            }

            return result;
        }
    }
}
