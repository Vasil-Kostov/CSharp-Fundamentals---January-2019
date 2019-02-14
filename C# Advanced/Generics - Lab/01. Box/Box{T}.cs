namespace BoxOfT
{
    using System.Collections.Generic;

    public class Box<T>
    {
        private Stack<T> values;
        
        public int Count
        {
            get => this.values.Count;
        }

        public Box()
        {
            this.values = new Stack<T>();
        }

        public void Add(T value)
        {
            this.values.Push(value);
        }

        public T Remove()
        {
            return this.values.Pop();
        }
    }
}
