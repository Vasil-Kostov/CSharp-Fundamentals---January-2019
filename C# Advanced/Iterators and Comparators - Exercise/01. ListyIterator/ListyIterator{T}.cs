namespace ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class ListyIterator<T>
    {
        private List<T> collction;
        private int currentIndex;

        public ListyIterator(params T[] elements)
        {
            this.collction = elements.ToList();
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
            if (this.currentIndex + 1 < this.collction.Count)
            {
                return true;
            }

            return false;
        }

        public string Print()
        {
            if (this.collction.Count == 0)
            {
                return "Invalid Operation!";
            }
            return $"{this.collction[this.currentIndex]}";
        }
    }
}
