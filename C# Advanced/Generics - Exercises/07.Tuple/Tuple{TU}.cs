namespace _07.Tuple
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tuple<T, U>
    {
        public T Item1 { get; set; }
        public U Item2 { get; set; }

        public Tuple(T item1, U item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
