namespace CustomStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return !this.Any();
        }

        public void AddRange(IEnumerable<string> colction)
        {
            foreach (var str in colction)
            {
                this.Push(str);
            }
        }
    }
}
