namespace ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int currentIndex;

        public ListyIterator(params T[] elements)
        {
            this.collection = elements.ToList();
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex + 1 < this.collection.Count)
            {
                return true;
            }

            return false;
        }

        public string Print()
        {
            if (this.collection.Count == 0)
            {
                return "Invalid Operation!";
            }
            return $"{this.collection[this.currentIndex]}";
        }

        public string PrintAll()
        {
            return string.Join(" ", this.collection);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.collection)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
