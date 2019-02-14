namespace _05.GenericCountMethodString
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T> where T : IComparable<T>
    {
        private List<T> values;

        public Box()
        {
            this.values = new List<T>();
        }

        public void Add(T value)
        {
            this.values.Add(value);
        }

        public void Swap(int first, int second)
        {
            T temp = this.values[first];
            this.values[first] = this.values[second];
            this.values[second] = temp;
        }

        public int CountGraterElements(T compareTo)
        {
            int counter = 0;

            foreach (var value in this.values)
            {
                if (value.CompareTo(compareTo) > 0) counter++;
            }

            return counter;
        }

        public override string ToString()
        {
            StringBuilder printAllValues = new StringBuilder();

            foreach (var value in this.values)
            {
                printAllValues.AppendLine($"{value.GetType()}: {value}");
            }

            return printAllValues.ToString();
        }
    }
}
