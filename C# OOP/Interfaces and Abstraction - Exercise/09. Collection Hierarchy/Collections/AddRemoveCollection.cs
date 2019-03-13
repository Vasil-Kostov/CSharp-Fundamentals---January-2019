namespace CollectionHierarchy.Collections
{
    using Interfaces;
    using System;
    using System.Linq;

    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
        public override int Add(string element)
        {
            base.Collection.Insert(0, element);
            return 0;
        }

        public virtual string Remove()
        {
            string lastElement = base.Collection.Last();
            base.Collection.RemoveAt(base.Collection.Count - 1);
            return lastElement;
        }
    }
}
