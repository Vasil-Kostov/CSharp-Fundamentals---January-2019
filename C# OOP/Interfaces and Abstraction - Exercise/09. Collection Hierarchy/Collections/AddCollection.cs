namespace CollectionHierarchy.Collections
{
    using Interfaces;
    using System.Collections.Generic;

    public class AddCollection : IAddCollection
    {
        public AddCollection()
        {
            this.Collection = new List<string>(100);
        }

        public List<string> Collection;

        public virtual int Add(string element)
        {
            this.Collection.Add(element);
            return this.Collection.LastIndexOf(element);
        }
    }
}
