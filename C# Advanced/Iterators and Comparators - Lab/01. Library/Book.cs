namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Book
    {        
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors.ToList());
        }

        public string Title { get; private set; }

        public int Year { get; private set; }

        public List<string> Authors { get; private set; }
    }
}
