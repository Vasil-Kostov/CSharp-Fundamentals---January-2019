namespace P01.Database
{
    using System;
    using System.Collections.Generic;

    public class Database
    {
        private const int Capacity = 16;

        private int[] collection;
        private int index;

        public Database(params int[] inputCollection)
        {
            this.ValidateInput(inputCollection);
            this.index = 0;
            this.collection = new int[Capacity];
            this.Collection = inputCollection;
        }

        private int[] Collection
        {
            get
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < this.index; i++)
                {
                    numbers.Add(this.collection[i]);
                }

                return numbers.ToArray();
            }

            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    this.collection[i] = value[i];
                    this.index++;
                }
            }
        }

        public void Add(int element)
        {
            if (this.index >= Capacity)
            {
                throw new InvalidOperationException("Capacity is full");
            }

            this.collection[this.index++] = element;
        }

        public void Remove()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Collection is empty");
            }

            this.collection[--this.index] = 0;
        }

        public int[] Fetch()
        {
            return this.Collection;
        }

        private void ValidateInput(int[] collection)
        {
            if (collection.Length < 1 || collection.Length > Capacity)
            {
                throw new InvalidOperationException("Invalid collection size!");
            }
        }
    }
}
