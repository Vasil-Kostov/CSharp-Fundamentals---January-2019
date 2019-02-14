namespace CustomStack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class CustomSack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public CustomSack()
        {
            this.stack = new List<T>();
        }

        public void Push(params T[] elements)
        {
            this.stack.AddRange(elements);
        }

        public T Pop()
        {
            if (!this.stack.Any())
            {
                throw new ArgumentException("No elements");
            }

            T last = this.stack.Last();
            this.stack.RemoveAt(this.stack.Count - 1);
            return last;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.stack.Count - 1; i >= 0; i--)
            {
                yield return this.stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
