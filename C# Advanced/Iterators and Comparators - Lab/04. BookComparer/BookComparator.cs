namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            var result = first.Title.CompareTo(second.Title);

            if (result == 0)
            {
                return second.Year.CompareTo(first.Year);
            }

            return result;
        }
    }
}
